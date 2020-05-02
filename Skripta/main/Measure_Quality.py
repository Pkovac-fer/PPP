import Lexing


def count_constructs(tokens):
	ifelse_cnt = 0
	brk_cont_cnt = 0
	labeled_blocks = 0
	prev_value = None
	for token in tokens:
		if str(token[0]) == "Token.Keyword":
			if token[1] == "if" or token[1] == "else":
				ifelse_cnt += 1
			if token[1] == "break" or token[1] == "continue" or token[1] == "goto" or (token[1] == "return" and prev_value == "yield"):
				brk_cont_cnt += 1
		if token[1] == ":":
			if prev_value == "<IDENTIFIER>":
				labeled_blocks += 1
		prev_value = token[1]
		print(token)
	print(labeled_blocks)
	print(brk_cont_cnt)
	print(ifelse_cnt)


def main():
	original = Lexing.lex(r"C:\Users\Petar\OneDrive\Desktop\Petar\6.  Semestar\ZavrsniRad\PPP\Originalni_Primjeri\CSharpConsoleGames\Snake\Program.cs")
	count_constructs(original)


if __name__ == '__main__':
	main()