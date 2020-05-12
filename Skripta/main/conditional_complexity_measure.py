import re


relational = ("<", ">", "!", "=")
logical = ("&", "|")


def is_empty_line(token):
	return re.match(r'^\s+$', token[1])


class ConditionalMeasure:

	def __init__(self):
		self.state = 0
		self.logicals = dict()
		self.bracket_counter = 0
		self.previous_token = None
		self.conditional_counter = 0
		self.current_complexity = 0
		self.total_complexity = 0
		self.left_side = True
		self.last_tokens = []

	def process_token(self, token):
		if (str(token[0]) == "Token.Punctuation" and str(token[1]) == ";" and not self.state == 7) or (str(token[0]) == "Token.Punctuation" and str(token[1]) in ("{", "}")):
			self.state = 0
			self.bracket_counter = 0
			#if (len(self.last_tokens) > 0):
			#	print(self.last_tokens)
			#	print(self.current_complexity)
			#self.last_tokens = []
			self.total_complexity += self.current_complexity
			self.current_complexity = 0

		if self.state == 0:
			self.left_side = True
			if str(token[0]) == "Token.Keyword.Type" and token[1] == "bool":
				self.state = 1
			elif str(token[0]) == "Token.Keyword":
				if token[1] == "for":
					self.state = 6
				if token[1] == "while":
					self.state = 8
				if token[1] == "if":
					self.state = 8
			elif str(token[0]) == "Token.Name" and self.logicals.get(token[1]) is not None:
				self.state = 1

		elif self.state == 1:
			if (str(token[0]) == "Token.Punctuation" and token[1] == ",") or str(
					token[0]) == "Token.Name" or is_empty_line(token):
				if str(token[0]) == "Token.Name":
					self.logicals[token[1]] = token[1]
			elif str(token[0]) == "Token.Punctuation" and token[1] == "=":
				self.left_side = True
				self.conditional_counter += 1
				self.current_complexity = 0
				self.bracket_counter = 0
				self.state = 2
			else:
				self.state = 0

		elif self.state == 2:
			if token[1] in ("<", ">") and str(self.previous_token[0]) == "Token.Punctuation" and self.previous_token[1] == token[1]:
				self.left_side = False
				self.current_complexity -= 0.5
			elif str(token[0]) == "Token.Punctuation" and token[1] in (":", "?"):
				self.left_side = True
			elif str(token[0]) == "Token.Name" or str(token[0]) == "Token.Literal.Number":
				if self.logicals.get(token[1]) is not None:
					self.current_complexity += 1
				elif self.left_side:
					self.current_complexity += 1
					self.left_side = False
			elif str(token[0]) == "Token.Keyword" and token[1] in ("true", "false"):
				self.current_complexity += 1
			elif str(token[0]) == "Token.Punctuation" and (token[1] in relational or token[1] in logical):
				if token[1] in ("<", ">", "!"):
					self.left_side = True
					self.current_complexity += 0.5
				elif not (str(self.previous_token[0]) == "Token.Punctuation" and self.previous_token[1] in ("<", ">", "!")):
					self.state = 3
			elif str(token[0]) == "Token.Punctuation" and token[1] == ".":
				self.state = 4
			elif str(token[0]) == "Token.Punctuation" and (token[1] == "," or token[1] == "{"):
				#print(self.last_tokens)
				#print(self.current_complexity)
				#self.last_tokens = []
				self.total_complexity += self.current_complexity
				self.current_complexity = 0
				self.state = 1

		elif self.state == 3:
			if str(token[0]) == "Token.Punctuation":
				if token[1] == "=" and self.previous_token[1] in relational:
					self.current_complexity += 0.5
				elif token[1] in logical and self.previous_token[1] == token[1]:
					self.current_complexity += 1

				self.left_side = True
			self.state = 2

		elif self.state == 4:
			if str(token[0]) == "Token.Punctuation":
				if token[1] == "(":
					self.bracket_counter = 1
					self.state = 5
				elif token[1] in relational or token[1] in logical:
					if token[1] in ("<", ">", "!"):
						self.current_complexity += 0.5
						self.left_side = True
						self.state = 2
					else:
						self.state = 3
				elif token[1] == ",":
					#print(self.last_tokens)
					#print(self.current_complexity)
					#self.last_tokens = []
					self.total_complexity += self.current_complexity
					self.state = 1

		elif self.state == 5:
			if str(token[0]) == "Token.Punctuation":
				if token[1] == "(":
					self.bracket_counter += 1
				elif token[1] == ")":
					self.bracket_counter -= 1

			if self.bracket_counter == 0:
				self.state = 2

		elif self.state == 6:
			if token[1] == "(":
				self.state = 7

		elif self.state == 7:
			if str(token[0]) == "Token.Punctuation" and token[1] == ";":
				self.conditional_counter += 1
				self.state = 2

		elif self.state == 8:
			if token[1] == "(":
				self.conditional_counter += 1
				self.state = 2

		#if( self.state > 1):
		#	self.last_tokens.append(token)

		self.previous_token = token

	def finish_measurement(self):
		if (len(self.last_tokens) > 0):
			print(self.last_tokens)
		self.total_complexity += self.current_complexity
		self.current_complexity = 0

	def get_results(self):
		self.finish_measurement()
		return 0 if self.conditional_counter == 0 else self.total_complexity / self.conditional_counter




