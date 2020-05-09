import typing

T = typing.TypeVar('T', bound='QualityMeasure')


def calculate_character_complexity(word):
	if len(word) == 1:
		return 1
	complex_in_a_row = 0
	complex_letters = 0
	non_complex_letters = 0
	for letter in word:
		if letter.isalnum():
			non_complex_letters += 1
			non_complex_letters += 1 if complex_in_a_row == 1 else 0
			complex_in_a_row = 0
		else:
			complex_in_a_row += 1
			if complex_in_a_row == 2:
				complex_letters += 2
			elif complex_in_a_row > 2:
				complex_letters += 1
	return (complex_letters + non_complex_letters) / non_complex_letters


def calculate_total_character_complexity(array, multiplier):
	total_sum = 0
	for item in array:
		total_sum += calculate_character_complexity(item)
	return multiplier * total_sum


class QualityMeasure:
	def __init__(self):
		self.function_decls = None
		self.class_fields = []
		self.classes = dict()
		self.formal_args = []
		self.local_vars = None
		self.last_token = None
		self.ifelse_cnt = 0
		self.brk_cont_cnt = 0
		self.labeled_blocks = 0
		self.previous_value = None

	def process_token(self, token, mode, declaration, diamond, parent):
		if str(token[0]) == "Token.Name.Class":
			self.classes[token[1]] = token[1]

		if str(token[0]) == "Token.Name":
			if declaration and diamond:
				if mode == 1:
					self.formal_args.append(token[1])
				elif parent.get_name() == "class":
					self.class_fields.append(token[1])

		if str(token[0]) == "Token.Keyword":
			if token[1] == "if" or token[1] == "else":
				self.ifelse_cnt += 1
			if token[1] == "break" or token[1] == "continue" or token[1] == "goto" or (token[1] == "return" and self.previous_value == "yield"):
				self.brk_cont_cnt += 1
		if token[1] == ":":
			if self.previous_value == "<IDENTIFIER>":
				self.labeled_blocks += 1
		self.previous_value = token[1]

	def set_local_vars(self, local_vars):
		self.local_vars = local_vars

	def set_function_decls(self, declarations):
		self.function_decls = declarations

	def get_construct_count(self):
		return self.ifelse_cnt, self.brk_cont_cnt, self.labeled_blocks, len(self.local_vars)

	def calculate_all_character_complexities(self):
		return  (calculate_total_character_complexity(self.function_decls, 4) +
				calculate_total_character_complexity(self.classes.values(), 3) +
				calculate_total_character_complexity(self.class_fields, 2) +
				calculate_total_character_complexity(self.formal_args, 1.5) +
				calculate_total_character_complexity(self.local_vars, 1))

