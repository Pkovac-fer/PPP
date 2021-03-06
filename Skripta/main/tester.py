import Winnowing
import Lexing
from main import RKR_GST
from main.conditional_complexity_measure import ConditionalMeasure

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


def test_conditional_complexity_on_file(file, expected_average_complexity, test_number):
	cond_measure = ConditionalMeasure()
	tokens = Lexing.lex_without_processing(file)
	for token in tokens:
		cond_measure.process_token(token)
	if abs(cond_measure.get_results() - expected_average_complexity) < (10 ** -2):
		print("Test " + str(test_number) + " je uspješan!")
	else:
		print("Test " + str(test_number) + " je neuspješan. Proječna složenost nije jednaka očekivanju - " + str(
			str(cond_measure.get_results()) + ", " + str(expected_average_complexity)))


def test_construct_count(file, expected_construct_count, test_number):
	Lexing.lex(file)
	if Lexing.get_construct_count() == expected_construct_count:
		print("Test " + str(test_number) + " je uspješan!")
	else:
		print("Test " + str(test_number) + " je neuspješan. Broj konstrukata nije jednak očekivanju - " + str(
			str(Lexing.get_construct_count()) + ", " + str(expected_construct_count)))


def test_identifier_count(file, expected_identifier_count, test_number):
	Lexing.lex(file)
	if Lexing.get_all_identifiers() == expected_identifier_count:
		print("Test " + str(test_number) + " je uspješan!")
	else:
		print("Test " + str(test_number) + " je neuspješan. Broj identifikatora nije jednak očekivanju - " + str(
			str(Lexing.get_all_identifiers()) + ", " + str(expected_identifier_count)))


def main():
	test_if_same_grade(test_home + "test1/a.cs", test_home + "test1/b.cs", test_home + "test1/Program.cs", 1)
	test_if_same(test_home + "test2/a.cs", test_home + "test2/b.cs", 2)
	test_grade_similarity(test_home + "test3/a.cs", test_home + "test3/b.cs", 1, 0.66, 3)
	test_grade_similarity(test_home + "test4/a.cs", test_home + "test4/b.cs", 0.9, 0.9, 4)
	test_grade_similarity(test_home + "test5/a.cs", test_home + "test5/b.cs", 0.9, 0.66, 5)
	test_grade_similarity_in_range(test_home + "test6/a.cs", test_home + "test6/b.cs", 0.75, 0.9, 0.46, 0.66, 6)
	test_conditional_complexity_on_file(test_home + "test7/a.cs", 5, 7)
	test_conditional_complexity_on_file(test_home + "test8/a.cs", 6.5, 8)
	test_conditional_complexity_on_file(test_home + "test9/a.cs", 10.5, 9)
	test_conditional_complexity_on_file(test_home + "test10/a.cs", 4.167, 10)
	test_conditional_complexity_on_file(test_home + "test11/a.cs", 4.167, 11)
	test_conditional_complexity_on_file(test_home + "test12/a.cs", 2.884, 12)
	test_construct_count(test_home + "test13/a.cs", (0, 0, 0, 10), 13)
	test_construct_count(test_home + "test14/a.cs", (0, 0, 0, 10), 14)
	test_identifier_count(test_home + "test15/a.cs", (2, 1, 4, 3, 3), 15)
	test_identifier_count(test_home + "test16/a.cs", (2, 2, 2, 3, 24), 16)
	test_construct_count(test_home + "test17/a.cs", (21, 4, 3, 24), 17)


if __name__ == '__main__':
    main()