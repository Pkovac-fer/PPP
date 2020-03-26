from pygments import lexers
import pygments
import re

numeric_types = ("byte", "short", "int", "long", "float", "double")
string_types = ("string")
access_modificators = ("private", "protected", "public", "internal", "static")

def remove_imports(lines):
	text = "";
	for line in lines:
		if not line.startswith("using "):
			text += line.lower();
	return text;

def h11(word):
    return int(hashlib.md5(word.encode('utf-8')).hexdigest()[:9], 16)



def token_is_comment(token):
	return str(token[0]).startswith("Token.Comment");

def is_empty_line(token) :
	return re.match(r'^\s+$', token[1]);

def token_is_redundant(token):
	return (token[1] == ";" or token[1] == "namespace" or token[1] == "using" or str(token[0]) == "Token.Name.Namespace" or str(token[0]) == "Token.Error" or token[1] == "ï");

def token_is_modifier(token):
	return token[1] in access_modificators


def rename_variable(token, last_remembered_type, type_counter, names):
	counter  = type_counter.get(last_remembered_type);
	if(counter == None):
		counter = 1
	else:
		counter += 1
	new_name = (last_remembered_type + str(counter)).upper()
	type_counter[last_remembered_type] = counter
	names[str(token[1])] = str(new_name)
	return (token[0], new_name)

def preprocess(tokens):
	names = dict();
	type_counter = dict();
	last_remembered_type = "none"
	building_number = False
	processed_tokens = [];
	for token in tokens:
		if(not (token_is_comment(token) or token_is_redundant(token) or token_is_redundant(token) or is_empty_line(token) or token_is_modifier(token))):
			if(str(token[0]) == "Token.Name"):
				token = (token[0], "<IDENTIFIER>");
			elif str(token[1]) == ";":
				last_remembered_type="none"
			elif str(token[0]) == "Token.Keyword.Type":
				if(token[1] in numeric_types):
					last_remembered_type = str(token[1]);
					token = (token[0], "<NUMERIC_TYPE>")
				elif(token[1] in string_types):
					last_remembered_type = str(token[1]);
					token = (token[0], "<STRING_TYPE>")

			if(str(token[0]) == "Token.Literal.Number"):
				if(last_remembered_type in numeric_types):
					token = (token[0], "<NUMERIC_VALUE>")
					if(not building_number):
						processed_tokens.append(token)
						building_number = True;
					continue

			if(str(token[0]) == "Token.Literal.String"):
				if(last_remembered_type in string_types):
					token = (token[0], "<STRING_VALUE>")
			if(building_number):
				building_number = False
			processed_tokens.append(token);
	return processed_tokens;

def process_tokens(tokens):
	tokens = preprocess(tokens)

	return tokens


def main():
	c_sharp_lexer = lexers.get_lexer_by_name("csharp")
	file = (open(r"C:\Users\Petar\OneDrive\Desktop\5.Semestar\Decompiling_PPP\Originalni_Primjeri\CSharpConsoleGames\PingPong/Program.cs", "r").read());
	tokens = list(pygments.lex(file, c_sharp_lexer))

	print(len(tokens))
	for token in tokens:
		print(token)
	tokens = process_tokens(tokens)
	text = ""
	for token in tokens:
		print(token)

	print(len(tokens))


	exit(1)

if __name__ == '__main__':
    main()