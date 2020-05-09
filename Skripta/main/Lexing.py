import hashlib

from pygments import lexers
import pygments
import re
from main.scope import Scope
from main.quality_measure import QualityMeasure
from main.identifier_finder import IdentifierFinder
from main.conditional_complexity_measure import ConditionalMeasure

numeric_types = ("byte", "short", "int", "long", "float", "double")
string_types = "string"
access_modifiers = ("private", "protected", "public", "internal", "static")
declaration_keyword = ("Token.Keyword.Type", "Token.Name")

lexer_helper = [["last_remembered_type", "none"], ["building_number", False]]
global_scope = Scope(None, "global")

q_measure = QualityMeasure()
idn_finder = IdentifierFinder(global_scope)
c_measure = ConditionalMeasure()


def get_construct_count():
	return q_measure.get_construct_count()


def remove_imports(lines):
	text = ""
	for line in lines:
		if not line.startswith("using "):
			text += line.lower()
	return text


def h11(word):
	return int(hashlib.md5(word.encode('utf-8')).hexdigest()[:9], 16)


def token_is_comment(token):
	return str(token[0]).startswith("Token.Comment")


def is_empty_line(token):
	return re.match(r'^\s+$', token[1])


def token_is_redundant(token):
	return token[1] == ";" or token[1] == "namespace" or token[1] == "using" or str(
		token[0]) == "Token.Name.Namespace" or str(token[0]) == "Token.Error" or token[1] == "ï"


def token_is_modifier(token):
	return token[1] in access_modifiers


def rename_variable(token, last_remembered_type, type_counter, names):
	counter = type_counter.get(last_remembered_type)
	if counter is None:
		counter = 1
	else:
		counter += 1
	new_name = (last_remembered_type + str(counter)).upper()
	type_counter[last_remembered_type] = counter
	names[str(token[1])] = str(new_name)
	return (token[0], new_name)


def process_token(processed_tokens, token):
	if not (token_is_comment(token) or token_is_redundant(token) or is_empty_line(token) or token_is_modifier(token)):
		if str(token[0]) == "Token.Name":
			token = (token[0], "<IDENTIFIER>")
		elif str(token[0]) == "Token.Keyword.Type":
			if token[1] in numeric_types:
				lexer_helper[0][1] = str(token[1])
				token = (token[0], "<NUMERIC_TYPE>")
			elif token[1] in string_types:
				lexer_helper[0][1] = str(token[1])
				token = (token[0], "<STRING_TYPE>")
		if str(token[0]) == "Token.Literal.Number":
			if lexer_helper[0][1] in numeric_types:
				token = (token[0], "<NUMERIC_VALUE>")
				if not lexer_helper[1][1]:
					processed_tokens.append(token)
					lexer_helper[1][1] = True
				return

		if str(token[0]) == "Token.Literal.String":
			if lexer_helper[0][1] in string_types:
				token = (token[0], "<STRING_VALUE>")
		if lexer_helper[1][1]:
			lexer_helper[1][1] = False
		processed_tokens.append(token)

	if str(token[1]) == ";":
		lexer_helper[0][1] = "none"


def preprocess(tokens):
	processed_tokens = []
	for token in tokens:

		idn_finder.process_token(token)
		current_scope = idn_finder.get_scope()
		q_measure.process_token(token, idn_finder.get_mode(), current_scope.get_declaration(), current_scope.get_in_diamond(), current_scope.get_parent)
		process_token(processed_tokens, token)

	q_measure.set_function_decls(idn_finder.function_decls.values())
	q_measure.set_local_vars(global_scope.get_local_vars())
	return processed_tokens


def process_tokens(tokens):
	global q_measure, idn_finder, c_measure, lexer_helper, global_scope
	lexer_helper = [["last_remembered_type", "none"], ["building_number", False]]
	global_scope = Scope(None, "global")
	q_measure = QualityMeasure()
	c_measure = ConditionalMeasure()
	idn_finder = IdentifierFinder(global_scope)
	tokens = preprocess(tokens)
	return tokens


def lex(filename):
	c_sharp_lexer = lexers.get_lexer_by_name("csharp")
	file = (open(
		filename,
		"r").read())
	tokens = process_tokens(list(pygments.lex(file, c_sharp_lexer)))
	return tokens


def lex_without_processing(filename):
	c_sharp_lexer = lexers.get_lexer_by_name("csharp")
	file = (open(
		filename,
		"r").read())
	tokens = list(pygments.lex(file, c_sharp_lexer))
	return tokens

def lex_string(string):
	c_sharp_lexer = lexers.get_lexer_by_name("csharp")
	tokens = list(pygments.lex(string, c_sharp_lexer))
	return tokens
