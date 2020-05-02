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


def determine_window_size(original, decompiled):
	win_size = 40
	k = 8
	decompiled_len = len(decompiled)
	original_len = len(original)
	if original_len + 1 < win_size + k:
		win_size = int((original_len + 1) // 1.2) - 1
	k = win_size // 5;
	if decompiled_len + 1 < win_size + k:
		win_size = int((decompiled_len + 1) // 1.2) - 1
	return win_size


def process_compare(original, decompiled):
	win_size = determine_window_size(original, decompiled)
	fingerprint_size = win_size // 5
	if fingerprint_size < 3:
		return 0
	decompiled_fingerprints = create_fingerprints(decompiled, fingerprint_size)
	original_fingerprints = create_fingerprints(original, fingerprint_size)
	winnowing_original = winnowing_algorithm(original_fingerprints, win_size)
	winnowing_decompiled = winnowing_algorithm(decompiled_fingerprints, win_size)

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
