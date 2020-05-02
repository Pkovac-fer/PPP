import Winnowing
import Lexing
from main import RKR_GST


test_home = "../test/"


def get_grade_winnowing(file_a, file_b):
	a_tokens = Lexing.lex(file_a)
	b_tokens = Lexing.lex(file_b)
	return Winnowing.process_compare(a_tokens, b_tokens)


def get_grade_gst(file_a, file_b):
	a_tokens = Lexing.lex(file_a)
	b_tokens = Lexing.lex(file_b)
	return RKR_GST.compare_programs(a_tokens, b_tokens)


def test_if_same_grade(file_a, file_b, file_program, test_number):
	a_score_winnowing = get_grade_winnowing(file_a, file_program)
	b_score_winnowing = get_grade_winnowing(file_b, file_program)
	a_score_gst = get_grade_gst(file_a, file_program)
	b_score_gst = get_grade_gst(file_b, file_program)

	if a_score_winnowing != b_score_winnowing:
		print("Test " + str(test_number) + " je neuspješan. RKR-GST ocjena nije ista! - " + str(
			a_score_winnowing) + "," + str(b_score_winnowing))
		return

	if a_score_gst != b_score_gst:
		print(
			"Test " + str(test_number) + " je neuspješan. RKR-GST ocjena nije ista! - " + str(a_score_gst) + "," + str(
				b_score_gst))
		return

	print("Test " + str(test_number) + " je uspješan!")


def test_if_same(file_a, file_b, test_number):
	score_winnowing = get_grade_winnowing(file_a, file_b)
	score_gst = get_grade_gst(file_a, file_b)

	if score_winnowing != score_gst:
		print("Test " + str(test_number) + " je neuspješan. Ocjena nije ista! - " + str(
			score_winnowing) + "," + str(score_gst))
		return

	print("Test " + str(test_number) + " je uspješan!")


def test_grade_similarity_in_range(file_a, file_b, expected_grade_winnowing_lower, expected_grade_winnowing_upper, expected_grade_gst_lower, expected_grade_gst_upper, test_number):
	score_winnowing = get_grade_winnowing(file_a, file_b)
	score_gst = get_grade_gst(file_a, file_b)

	if not(expected_grade_winnowing_lower < score_winnowing < expected_grade_winnowing_upper):
		print("Test " + str(test_number) + " je neuspješan. Winnowing ocjena nije blizu očekivanja! - " + str(
			expected_grade_winnowing_lower) + "-" + str(expected_grade_winnowing_upper) + "," + str(score_winnowing))
		return

	if not(expected_grade_gst_lower < score_gst < expected_grade_gst_upper):
		print("Test " + str(test_number) + " je neuspješan. GST ocjena nije blizu očekivanja! - " + str(
			expected_grade_gst_lower) + "-" + str(expected_grade_gst_upper) + "," + str(score_gst))
		return

	print("Test " + str(test_number) + " je uspješan!")


def test_grade_similarity(file_a, file_b, expected_grade_winnowing, expected_grade_gst, test_number):
	return test_grade_similarity_in_range(file_a, file_b, expected_grade_winnowing - 0.05, expected_grade_winnowing + 0.05, expected_grade_gst - 0.05, expected_grade_gst + 0.05, test_number)


def main():
	test_if_same_grade(test_home + "test1/a.cs", test_home + "test1/b.cs", test_home + "test1/Program.cs", 1)
	test_if_same(test_home + "test2/a.cs", test_home + "test2/b.cs", 2)
	test_grade_similarity(test_home + "test3/a.cs", test_home + "test3/b.cs", 1, 0.66, 3)
	test_grade_similarity(test_home + "test4/a.cs", test_home + "test4/b.cs", 0.9, 0.9, 4)
	test_grade_similarity(test_home + "test5/a.cs", test_home + "test5/b.cs", 0.9, 0.66, 5)
	test_grade_similarity_in_range(test_home + "test6/a.cs", test_home + "test6/b.cs", 0.75, 0.9, 0.46, 0.66, 6)


if __name__ == '__main__':
    main()