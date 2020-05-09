from main.scope import Scope
import Lexing

declaration_keyword = ("Token.Keyword.Type", "Token.Name")


class IdentifierFinder:

	def __init__(self, current_scope):
		self.current_scope = current_scope
		self.checker = current_scope
		self.declaration_flag = True
		self.definition_flag = False
		self.bracket_counter = 0
		self.function_decls = dict()
		self.mode = 3
		self.token = None

	def process_token(self, token):
		self.token = token
		self.determine_current_scope()
		self.determine_mode()

		if str(token[0]) == "Token.Name":
			self.check_identifier_candidate()

		if self.definition_flag:
			self.skip_definition()
		else:
			if str(token[0]) == "Token.Punctuation" and token[1] == "=":
				self.definition_flag = True
			else:
				self.valid_declaration_check()

		self.declaration_start_check()

		if str(token[0]) == "Token.Punctuation" and token[1] in ("<", ">"):
			self.current_scope.found_diamond(token[1])

		if str(token[0]) == "Token.Punctuation" and token[1] == ";":
			self.reset_conditions()


	def determine_current_scope(self):
		if (str(self.token[0]) == "Token.Name.Function" and self.function_decls.get(self.token[1]) is None) or self.token[1] in ("for", "foreach", "{"):
			name = "func" if str(self.token[0]) == "Token.Name.Function" else self.token[1]
			if name == "func":
				self.function_decls[self.token[1]] = self.token[1]
			self.current_scope.reset_all()
			self.current_scope = Scope(self.current_scope, name)
		elif self.token[1] == "}":
			while self.current_scope.get_parent is not None and (
				self.current_scope.get_parent.get_name() in ("for", "foreach", "class")):
				self.current_scope = self.current_scope.get_parent
			self.current_scope = self.current_scope.get_parent
		elif str(self.token[0]) == "Token.Name.Class":
			self.current_scope.reset_all()
			self.current_scope = Scope(self.current_scope, "class")

		if self.checker != self.current_scope:
			self.checker = self.current_scope
			self.reset_conditions()

	def check_identifier_candidate(self):
		if self.current_scope.get_declaration() and self.current_scope.get_in_diamond() and not self.definition_flag:
			if self.mode == 0 and self.current_scope.get_parent.get_name() != "class":
				self.current_scope.add_identifier(self.token[1])

	def determine_mode(self):
		if self.current_scope.get_name() in ("{", "for", "foreach"):
			self.mode = 0
		elif self.current_scope.get_name() == "func":
			self.mode = 1
		elif self.current_scope.get_name() == "class":
			self.mode = 2
		else:
			self.mode = 3

	def get_scope(self):
		return self.current_scope

	def get_mode(self):
		return self.mode

	def skip_definition(self):
		if self.bracket_counter == 0 and str(self.token[0]) == "Token.Punctuation" and self.token[1] == ",":
			self.definition_flag = False
			self.current_scope.set_declaration(True)
		else:
			if str(self.token[0]) == "Token.Punctuation":
				if self.token[1] == "(":
					self.bracket_counter += 1
				elif self.token[1] == ")":
					self.bracket_counter -= 1

	def valid_declaration_check(self):
		if not str(self.token[0]) == "Token.Name" and self.current_scope.get_declaration() and self.current_scope.get_in_diamond():
			if not Lexing.token_is_comment(self.token) and not Lexing.is_empty_line(self.token):
				if self.mode == 0:
					if not self.token[1] in ("[", "]", "<", ">", ",", "for", "foreach", "(", ")", "{", "}"):
						self.current_scope.set_declaration(False)
				elif self.mode == 1:
					if not self.token[1] in ("[", "]", "<", ">", "(", ")"):
						self.current_scope.set_declaration(False)

	def declaration_start_check(self):
		if not self.current_scope.get_declaration() and str(self.token[0]) in declaration_keyword and not self.definition_flag:
			if self.declaration_flag or self.mode == 1:
				self.current_scope.set_declaration(True)
				self.declaration_flag = False

	def reset_conditions(self):
		self.bracket_counter = 0
		self.current_scope.set_declaration(False)
		self.current_scope.reset_diamond()
		self.declaration_flag = True
		self.definition_flag = False
