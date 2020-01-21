import subprocess
import os
from os.path import sys, dirname
import ntpath
import hashlib
import re


valid_decompilers = ("ilspy","justdecompile")

parent_folder = dirname(dirname(sys.path[0]));

decompiler_names = {
    "justdecompile": parent_folder + r"\Decompilers\JustDecompile\Libraries\JustDecompile.exe",
    "ilspy": parent_folder +  r"\Decompilers\ILSpyCMD\tools\ilspycmd.exe",
}

decompiling_destinations = {
    "justdecompile": parent_folder + "/Rezultati/JustDecompileEngine/",
    "ilspy": parent_folder +  "/Rezultati/ILSpy/",
}

decompiler_options = {
    "justdecompiledecompile": [parent_folder + r"\Decompilers\JustDecompile\Libraries\JustDecompile.exe","/out:", "/target:"],
    "ilspydecompile": [parent_folder +  r"\Decompilers\ILSpyCMD\tools\ilspycmd.exe", "-o", "-p"],
}

def choose_decompiler(decompiler_name):
    while(not (decompiler_name in valid_decompilers)):
        decompiler_name = input("Nije izabrano pravilno ime dekompajlera, opcije su - 'justdecompile', 'ilspy':");
    return decompiler_name;

def choose_binary(bin_path):
    filename, file_extension = os.path.splitext(bin_path);
    while(not (os.path.isfile(bin_path) and (file_extension == ".exe" or file_extension == ".dll"))):
        bin_path = input("Dataoteka mora imati ekstenziju .exe ili .dll");
        filename, file_extension = os.path.splitext(bin_path);
    return bin_path;

def choose_file(file_path, source_string):
    while(not os.path.isfile(file_path)):
        print(file_path)
        file_path = input("Nije odabrana datoteka. Odaberite ispravnu " + source_string + " datoteku: ");
    return file_path;

def get_decompiler_option(decompiler, option, file, destination):
    if not os.path.exists(destination):
        os.mkdir(destination);
    option = decompiler_options.get(decompiler + option).copy();
    if decompiler == "ilspy":
        option.insert(1, file);
        option.insert(3,destination);
    elif decompiler == "justdecompile":
        option[1] = option[1] + " " +  destination;
        option[2] = option[2] + " " + file;
    return option;

def remove_blanklines(text):
    blankless_text = "";
    for letter in text:
        if (not re.match(r'^\s*$', letter)):
            blankless_text += letter;
    return blankless_text;
            
def remove_empty_lines(lines):
    no_blanks_arr = [];
    for line in lines:
        blank_line = remove_blanklines(line)
        if len(blank_line) > 0:
            no_blanks_arr.append(blank_line)
    return no_blanks_arr;

def count_constructs(lines):
    construct_counter = 1;
    for line in lines:
        if "if else" in line or "if" in line or "else" in line or "switch" in line or "case" in line:
            construct_counter += 1
        elif "break" in line or "continue" in line:
            construct_counter += 2
    return construct_counter;

def calculate_line_conditional_complexity(line):
    previous_letter = "";
    result = 0;
    for letter in line:
        if(previous_letter=="<" or previous_letter == ">"):
            previous_letter = "";
        elif(previous_letter=="&" or previous_letter == "|"):
            if(letter == "&" or letter == "|"):
                result += 1
            previous_letter = "";
        elif(previous_letter == "" and (letter == "<" or letter == ">" or letter == "!")):
            result += 0.5;
            previous_letter = letter;
        elif((letter == "=" or letter == "&" or letter == "|") and previous_letter == ""):
            previous_letter = letter;
        elif(previous_letter == "="):
            if(letter == "="):
                result += 0.5
            previous_letter = "";
    return result;

def calculate_conditional_complexity(lines):
    result = 1;
    logically_complex_lines_counter = 1;
    for line in lines:
        line_complexity =calculate_line_conditional_complexity(line);
        result += line_complexity;
        logically_complex_lines_counter = logically_complex_lines_counter if line_complexity == 0 else logically_complex_lines_counter + 1; 
    return result/logically_complex_lines_counter;

def remove_imports(lines):
    text = "";
    for line in lines:
        if not line.startswith("using "):
            text += line.lower();
    return text;
            
def h11(word):
    return int(hashlib.md5(word.encode('utf-8')).hexdigest()[:9], 16)

def create_fingerprints(text, k):
    fingerprint_arr = [];
    for i in range (0, len(text) - k):
        fingerprint_arr.append(h11(text[i: i + k]));
    return fingerprint_arr;

def find_min_index(fingerprints):
    minimum = fingerprints[0]
    min_index = 0;
    for i in range (0, len(fingerprints)):
        if(int(fingerprints[i]) < int(minimum)):
            minimum = fingerprints[i];
            min_index = i;

    return min_index;


def winnowing_algorithm(fingerprints, w):
    winnowing_arr = [];
    min_relative_index = -1;
    min_relative_value = 0;
    for i in range (0, len(fingerprints) - w):
        if(min_relative_index == -1):
            min_relative_index = find_min_index(fingerprints[i:i + w]);
            min_relative_value = fingerprints[i + min_relative_index];
            winnowing_arr.append(min_relative_value);
            min_relative_index -= 1;
        else:
            min_relative_index -= 1;
            if(int(min_relative_value) > int(fingerprints[i +  w - 1])):
                min_relative_index = w - 1;
                min_relative_value = fingerprints[i + w - 1];
                winnowing_arr.append(min_relative_value);
    return winnowing_arr;

def process_decompile(arguments):
    if(len(arguments) > 1):
        decompiler = choose_decompiler(arguments[0]);
        binary_file = choose_binary(arguments[1]);
        decompiler_options = get_decompiler_option(decompiler, "decompile", binary_file, decompiling_destinations.get(decompiler) + ntpath.basename(binary_file).split(".")[0] + ".decompiled")
        process  = subprocess.Popen(decompiler_options,stdout=subprocess.PIPE, shell = True, universal_newlines=True);
    else:
        print("Netočni argumenti");
        
def process_compare(arguments):
    if(len(arguments) > 1):
        original_file = open(choose_file(arguments[0], "IZVORNU"), "r").readlines();
        decompiled_file = open(choose_file(arguments[1], "DEKOMPAJLIRANU"), "r").readlines();
        decompiled_fingerprints = create_fingerprints(remove_blanklines(remove_imports(decompiled_file)), 10)
        original_fingerprints = create_fingerprints(remove_blanklines(remove_imports(original_file)), 10);
        winnowing_original = winnowing_algorithm(original_fingerprints, 40)
        winnowing_decompiled = winnowing_algorithm(decompiled_fingerprints, 40);
        
        intersection_counter = 0;
        for fingerprint in winnowing_decompiled:
            if fingerprint in winnowing_original:
                intersection_counter += 1;
        
        for fingerprint in winnowing_original:
            if fingerprint in winnowing_decompiled:
                intersection_counter += 1;
        result = (intersection_counter * 100) / (len(winnowing_original) + len(winnowing_decompiled));
        print('\n{0:.3g}'.format(result) + "%");
        result_message =  "Program nije dobro dekompajliran.\n" if result < 45 else "Program je dobro dekompajliran.\n";
        print(result_message)
    else:
        print("Netočni argumenti")
        
def decompile_all(binary):
    if(len(binary) > 1):
        binary_file = choose_binary(binary);
        process_decompile(["justdecompile", binary_file]);
        process_decompile(["ilspy", binary_file])
    else:
        print("Netočni argumenti");
        
def help():
    print("\n################################################################################################################################################################################################################################")
    print("Naredbe ovog programa su: -D, -C, -DA, -DQ\n")
    print("Naredba -D (Decompile) dekompajlira jednu izvršnu datoteku i prima 2 argumenta: Dekompajler koji se koristiti (ilspy/justdecompile) i putanja do datoteke kompajliranog C# programa (.exe ili .dll).")
    print("Naredba -C (Compare) uspoređuje dvije datoteke i prima 2 argumenta: Izvorni program i dekompajlirani program.")
    print("Naredba -DA (Decompile All) dekompajlira jednu izvršnu datoteku koristeći svaki dekompajler i prima 1 arugment: putanju do datoteke kompajliranog C# programa (.exe ili .dll).")
    print("Naredba -DQ (Decompiler Quality) uspoređuje dvije dekompajlirane datoteka istog izvršnog koda i prima 2 argumenta: putanje do datoteka dekompajliranih s 2 različita dekompajlera.")
    print("        -DQ može primiti dodatni paramtetar SHOW koja će pokazivati međurezultate dobivene tijekom izvođenja programa")
    print("################################################################################################################################################################################################################################\n")
   
   
   

def process_decompile_quality(arguments):
    show = True if len(arguments) > 2 and arguments[2].lower() == "show" else False;

    first_file = remove_empty_lines(open(choose_file(arguments[0], "IZVORNU"), "r").readlines());
    second_file = remove_empty_lines(open(choose_file(arguments[1], "DEKOMPAJLIRANU"), "r").readlines());
    first_size_result = 1 if len(first_file) >= len(second_file) else len(first_file)/len(second_file);
    second_size_result = 1 if len(first_file) <= len(second_file) else len(second_file)/len(first_file);
    
    first_construct_count = count_constructs(first_file);
    second_construct_count = count_constructs(second_file);
    
    first_construct_result = 1 if first_construct_count >= second_construct_count else first_construct_count/second_construct_count;
    second_construct_result = 1 if first_construct_count <= second_construct_count else second_construct_count/first_construct_count;
    
    first_conditional_complexity = calculate_conditional_complexity(first_file);
    second_conditional_complexity = calculate_conditional_complexity(second_file);
    
    first_conditional_complexity_result = second_conditional_complexity/first_conditional_complexity if first_conditional_complexity >= second_conditional_complexity else 1;
    second_conditional_complexity_result = first_conditional_complexity/second_conditional_complexity if first_conditional_complexity <= second_conditional_complexity else 1;
    
    first_final_result = first_size_result + first_construct_result + first_conditional_complexity_result;
    second_final_result = second_size_result + second_construct_result + second_conditional_complexity_result;
    
    if(show):
        print("\nMEĐUREZULTAT VELIČINA - PRVI: " + str(first_size_result) + " DRUGI: " + str(second_size_result));
        print("MEĐUREZULTAT IF/ELSE KONSTRUKTI - PRVI: " + str(first_construct_result) + " DRUGI: " + str(second_construct_result));
        print("MEĐUREZULTAT PROSJEČNA KOMPLEKSNOST - PRVI: " + str(first_conditional_complexity_result) + " DRUGI: " + str(second_conditional_complexity_result));
        
    print("\nUsporedba: Kompajler koji je kompajlirao prvu datoteku ima ocjenu " + '{0:.3g}'.format(first_final_result));
    print("Usporedba: Kompajler koji je kompajlirao drugu datoteku ima ocjenu " + '{0:.3g}'.format(second_final_result));
    relative_result = first_final_result - second_final_result;
    
    if(relative_result < -0.5):
        print("Prvi compiler kompajlira vidljivo bolje nego prvi\n");
    elif(relative_result > 0.5):
        print("Drugi compiler kompajlira vidljivo bolje nego prvi\n");
    else:
        print("Compileri imaju sličnu kvalitetu kompilacije.\n");
    
    
     
def process(commands):
    if(len(commands) > 1):
        if (commands[0].lower() == "-d") :
            process_decompile(commands[1:])
        elif (commands[0].lower() == "-c"):
            process_compare(commands[1:])
        elif (commands[0].lower() == "-da"):
            decompile_all(commands[1]);
        elif (commands[0].lower() == "-dq"):
            process_decompile_quality(commands[1:]);
        elif (commands[0].lower() == "-h"):
            help();
        if(input("Gotov s programom? Upiši 'da' za izlaz: ").lower() == "da"):
            sys.exit(0);
        
def shell():
    if(len(sys.argv)) > 1:
        process(sys.argv[1:]);
    else:
        help()
    while(True):
        process(input("\nUnesi sljedeću naredbu. Upiši '-H HELP' za pomoć: ").split());

if __name__ == '__main__':
    shell();