import subprocess
import os
from os.path import sys, dirname
import ntpath
from main import RKR_GST
from main import Winnowing
import hashlib
import re
from pygments import lexers
import Lexing
from pathlib import Path

valid_decompilers = ("ilspy", "justdecompile")

parent_folder = dirname(dirname(sys.path[0]))

decompiler_names = {
	"justdecompile": parent_folder + r"\Decompilers\JustDecompile\Libraries\JustDecompile.exe",
	"ilspy": parent_folder + r"\Decompilers\ILSpyCMD\tools\ilspycmd.exe",
}

result_folder = parent_folder + r"/PPP/rezultati_usporedbe/"

obfuscated_result_folder = parent_folder + r"/PPP/rezultati_usporedbe_obfuscirani/"

decompiling_destinations = {
	"justdecompile": parent_folder + "/Rezultati/JustDecompileEngine/",
	"ilspy": parent_folder + "/Rezultati/ILSpy/",
}

decompiling_obfuscated_destinations = {
	"justdecompile": parent_folder + "/Rezultati/JustDecompileEngine/obfuscated/",
	"ilspy": parent_folder + "/Rezultati/ILSpy/obfuscated/",
}

decompiler_options = {
	"justdecompiledecompile": [parent_folder + r"\Decompilers\JustDecompile\Libraries\JustDecompile.exe", "/out:",
							   "/target:"],
	"ilspydecompile": [parent_folder + r"\Decompilers\ILSpyCMD\tools\ilspycmd.exe", "-o", "-p"],
}

multipliers = {
	"with_original_multipliers" : (0.2, 0.1, 0.1, 0.2, 0.2, 0.2),
	"no_original_multipliers" : (0.25, 0.1, 0.2, 0.2, 0.25),
}
with_original_multipliers = (0.2, 0.1, 0.1, 0.2, 0.2, 0.2)

no_original_multipliers = (0.25, 0.1, 0.2, 0.2, 0.25)


def choose_decompiler(decompiler_name):
	while not (decompiler_name in valid_decompilers):
		decompiler_name = input("Nije izabrano pravilno ime dekompajlera, opcije su - 'justdecompile', 'ilspy':");
	return decompiler_name


def choose_binary(bin_path):
	filename, file_extension = os.path.splitext(bin_path)
	while not (os.path.isfile(bin_path) and (file_extension == ".exe" or file_extension == ".dll")):
		bin_path = input("Dataoteka mora imati ekstenziju .exe ili .dll")
		filename, file_extension = os.path.splitext(bin_path)
	return bin_path


def choose_file(file_path, source_string):
	while not os.path.isfile(file_path):
		print(file_path)
		file_path = input("Nije odabrana datoteka. Odaberite ispravnu " + source_string + " datoteku: ")
	return file_path


def get_decompiler_option(decompiler, option, file, destination):
	if not os.path.exists(destination):
		os.mkdir(destination)
	option = decompiler_options.get(decompiler + option).copy()
	if decompiler == "ilspy":
		option.insert(1, file)
		option.insert(3, destination)
	elif decompiler == "justdecompile":
		option[1] = option[1] + " " + destination
		option[2] = option[2] + " " + file
	return option


def process_decompile(arguments):
	if len(arguments) > 1:
		decompiler = choose_decompiler(arguments[0])
		binary_file = choose_binary(arguments[1])
		decompiler_options = get_decompiler_option(decompiler, "decompile", binary_file,
												   decompiling_destinations.get(decompiler) +
												   ntpath.basename(binary_file).split(".")[0] + ".decompiled")
		subprocess.Popen(decompiler_options, stdout=subprocess.PIPE, shell=True, universal_newlines=True)
	else:
		print("Netočni argumenti")


def print_grade(file, program, results, grade):
	line = Path(dirname(program)).stem + "/" +  Path(program).stem + " results: " + str(results) + "	Grade: " + str(grade) + "\n"
	file.write(line)

def calculate_grade(results, with_original):
	grade = 0
	if with_original:
		for i in range(0, len(with_original_multipliers)):
			grade += with_original_multipliers[i] * results[i]
	else:
		for i in range(0, len(no_original_multipliers)):
			grade += no_original_multipliers[i] * results[i]
	return grade


def process_compare(arguments, mode):
	if len(arguments) == 0:
		print("Unesite barem jednu datoteku.")
	folder = result_folder if mode == "normal" else obfuscated_result_folder
	normalized_file = open(r"" + folder + Path(dirname(arguments[0])).stem + "_" + Path(arguments[0]).stem + "NormalizedResults" + ".txt", "w")
	non_normalized_file = open(r"" + folder + Path(dirname(arguments[0])).stem + "_" + Path(arguments[0]).stem + "Results.txt", "w")
	normalized_file.write("Score legend:			if/else		break/continue		label count			local variables			conditional complexity			RKR-GST/Winnowing similiarity			Grade\n\n")
	non_normalized_file.write(
		"Score legend:			if/else		break/continue		label count			local variables			conditional complexity			RKR-GST/Winnowing similiarity			Grade\n\n")
	original_tokens = Lexing.lex(arguments[0])
	original_results = Lexing.get_results()

	for i in range(0, len(original_results)):
		original_results[i] = 1 if original_results[i] == 0 else original_results[i]
	print_grade(non_normalized_file, arguments[0], original_results, "NOGRADE")
	print_grade(normalized_file, arguments[0], [1] * len(original_results), 1)

	for argument in arguments[1:]:
		argument_tokens = Lexing.lex(argument)
		argument_results = Lexing.get_results()
		argument_results[-1] = (RKR_GST.compare_programs(original_tokens.copy(), argument_tokens.copy()) + Winnowing.process_compare(original_tokens.copy(), argument_tokens.copy())) / 2
		for i in range(0, len(original_results)):
			argument_results[i] = 1 if argument_results[i] == 0 else argument_results[i]
		print_grade(non_normalized_file, argument, argument_results, "NOGRADE")
		for i in range(0, len(argument_results)):
			argument_results[i] = argument_results[i] / original_results[i]
		for i in range(0, len(original_results)):
			argument_results[i] = 1 if argument_results[i] == 0 else argument_results[i]
		argument_results[-1] = 1 / (argument_results[-1] ** 2)
		print_grade(normalized_file, argument, argument_results, calculate_grade(argument_results, True))
		print(argument + str(argument_results))
		grade = 0
		for i in range(0, len(argument_results)):
			grade += with_original_multipliers[i] * argument_results[i]
		print("Final grade: " + str(grade))





def decompile_all(binary):
	if len(binary) > 1:
		binary_file = choose_binary(binary)
		process_decompile(["justdecompile", binary_file])
		process_decompile(["ilspy", binary_file])
	else:
		print("Netočni argumenti")


def help():
	print(
		"\n################################################################################################################################################################################################################################")
	print("Naredbe ovog programa su: -D, -C, -DA, -DQ\n")
	print(
		"Naredba -D (Decompile) dekompajlira jednu izvršnu datoteku i prima 2 argumenta: Dekompajler koji se koristiti (ilspy/justdecompile) i putanja do datoteke kompajliranog C# programa (.exe ili .dll).")
	print(
		"Naredba -CO (Compare) uspoređuje n datoteka")
	print(
		"Naredba -DA (Decompile All) dekompajlira jednu izvršnu datoteku koristeći svaki dekompajler i prima 1 arugment: putanju do datoteke kompajliranog C# programa (.exe ili .dll).")
	print(
		"Naredba -DQ (Decompiler Quality) uspoređuje dvije dekompajlirane datoteka istog izvršnog koda i prima 2 argumenta: putanje do datoteka dekompajliranih s 2 različita dekompajlera.")
	print(
		"        -DQ može primiti dodatni paramtetar SHOW koja će pokazivati međurezultate dobivene tijekom izvođenja programa")
	print(
		"################################################################################################################################################################################################################################\n")


def process_decompile_quality(arguments):
	return


def process(commands):
	if len(commands) > 1:
		if commands[0].lower() == "-d":
			process_decompile(commands[1:])
		elif commands[0].lower() == "-cn":
			process_compare(commands[1:], "normal")
		elif commands[0].lower() == "-co":
			process_compare(commands[1:], "obfuscated")
		elif commands[0].lower() == "-da":
			decompile_all(commands[1])
		elif commands[0].lower() == "-dq":
			process_decompile_quality(commands[1:])
		elif commands[0].lower() == "-h":
			help()
		elif commands[0].lower() == "-exit":
			sys.exit(0)


def shell():
	if (len(sys.argv)) > 1:
		process(sys.argv[1:])
	else:
		help()
	while True:
		process(input("\nUnesi sljedeću naredbu. Upiši '-H HELP' za pomoć: ").split())


if __name__ == '__main__':
	shell()
