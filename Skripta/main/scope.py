import typing

T = typing.TypeVar('T', bound='Scope')


class Scope:
	children: typing.List[T]
	parent: T

	def __init__(self, parent: T, name):
		self.children = []
		self.parent = parent
		self.name = name
		self.identifiers = dict()
		self.declaration = False
		self.in_diamond = 0
		if self.parent is not None:
			self.parent.children.append(self)

	@property
	def get_parent(self):
		if self.parent is None:
			return self
		return self.parent

	@property
	def get_children(self) -> typing.List[T]:
		return self.children

	def add_identifier(self, idn):
		self.identifiers[idn] = idn

	@property
	def get_identifiers(self):
		return self.identifiers

	def found_diamond(self, diamond):
		if diamond == "<":
			self.in_diamond += 1
		if diamond == ">":
			if self.in_diamond > 0:
				self.in_diamond -= 1

	def set_declaration(self, in_declaration):
		self.declaration = in_declaration

	def reset_diamond(self):
		self.in_diamond = 0

	def get_in_diamond(self):
		return self.in_diamond == 0

	def get_declaration(self):
		return self.declaration

	def reset_all(self):
		self.reset_diamond()
		self.set_declaration(False)

	def get_name(self):
		return self.name

	def count_identifiers(self):
		cnt = len(self.identifiers)
		for child in self.get_children:
			cnt += child.count_identifiers()
		return cnt

	def get_local_vars(self):
		locals_vars = []
		for child in self.get_children:
			for local in child.get_local_vars():
				locals_vars.append(local)
		for local in self.get_identifiers.values():
			locals_vars.append(local)
		return locals_vars

	def var_is_defined(self, var_name):
		if self.name == "global":
			return False
		elif self.identifiers.get(var_name) is not None:
			return True
		else:
			return self.parent.var_is_dedfined(var_name)
