import hashlib

def find_min_index(fingerprints):
	minimum = fingerprints[0]
	min_index = 0
	for i in range(0, len(fingerprints)):
		if int(fingerprints[i]) < int(minimum):
			minimum = fingerprints[i]
			min_index = i

	return min_index


def winnowing_algorithm(fingerprints, w):
	winnowing_arr = []
	min_relative_index = -1
	min_relative_value = 0
	for i in range(0, len(fingerprints) - w):
		if min_relative_index == -1:
			min_relative_index = find_min_index(fingerprints[i:i + w])
			min_relative_value = fingerprints[i + min_relative_index]
			winnowing_arr.append(min_relative_value)
			min_relative_index -= 1
		else:
			min_relative_index -= 1
			if int(min_relative_value) > int(fingerprints[i + w - 1]):
				min_relative_index = w - 1
				min_relative_value = fingerprints[i + w - 1]
				winnowing_arr.append(min_relative_value)
	return winnowing_arr


def h11(word):
	return int(hashlib.md5(word.encode('utf-8')).hexdigest()[:9], 16)


def extract_word(tokens, i, k):
	word = ""
	for j in range(i, i + k):
		word += tokens[i][1]
	return word


def create_fingerprints(tokens, k):
	fingerprint_arr = []
	for i in range(0, len(tokens) - k):
		fingerprint_arr.append(h11(extract_word(tokens, i, k)))
	return fingerprint_arr


def process_compare(original, decompiled):
	decompiled_fingerprints = create_fingerprints(decompiled, 10)
	original_fingerprints = create_fingerprints(original, 10)
	winnowing_original = winnowing_algorithm(original_fingerprints, 40)
	winnowing_decompiled = winnowing_algorithm(decompiled_fingerprints, 40)

	intersection_counter = 0;
	for fingerprint in winnowing_decompiled:
		if fingerprint in winnowing_original:
			intersection_counter += 1;

	for fingerprint in winnowing_original:
		if fingerprint in winnowing_decompiled:
			intersection_counter += 1;
	if len(set(winnowing_original)) + len(set(winnowing_decompiled)) == 0:
		return 0
	return (len(set(winnowing_original).intersection(winnowing_decompiled)) * 2) / (
		len(set(winnowing_original)) + len(set(winnowing_decompiled)))
