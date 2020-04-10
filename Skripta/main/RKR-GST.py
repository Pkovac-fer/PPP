import Lexing


# Provjeri ako je token pokriven
def marked(tokens, index):
	return tokens[index][0] is None


# Nadi sljedeci nepokriveni token pocevsi od pokrivenog
def find_next_position(index, tokens):
	tokens_len = len(tokens)
	for i in range(index, tokens_len):
		if not marked(tokens, index):
			return i
	return tokens_len


# Nadi index nepokrivenog ako postoji udaljenog za manje od s od trenutnog tokena
def distance_to_next(index, search_len, tokens):
	for i in range(index, index + search_len):
		if tokens[i][0] is None:
			return i
	return None


# Provjeri ako smo unutar granica dva skupa tokena
def out_of_bounds(match_t, match_p, k, tokens_t, tokens_p):
	return not (match_t + k < len(tokens_t) and match_p + k < len(tokens_p))


def compute_token_ord(token):
	length = len(token)
	adder = 0
	for i in range(length):
		adder += ord(token[i])
	return adder


def update_hash(index, length, tokens, previous_hash):
	base = 7 if length < 20 else 3
	return ((previous_hash - compute_token_ord(tokens[index - 1][1]))//base) + (compute_token_ord(tokens[index + length - 1][1]) * (base ** (length - 1)))


def create_hash(index, length, tokens):
	base = 7 if length < 20 else 3
	hash_val = 0
	for i in range(index, index + length):
		hash_val += compute_token_ord(tokens[i][1]) * (base ** (i - index))
	return hash_val


def rolling_hash(index, length, tokens, previous_hash):
	if previous_hash is not None:
		return update_hash(index, length, tokens, previous_hash)
	else:
		return create_hash(index, length, tokens)


def add_to_hashtable(index, hash_value, hash_dict):
	value = hash_dict.get(hash_value)
	if value is None:
		hash_dict[hash_value] = []
	hash_dict[hash_value].append(index)


def check_for_match(hash_val, hash_dict):
	return hash_dict.get(hash_val)


def record_match(index_t, index_p, length, match_dict):
	value = match_dict.get(length)
	if value is None:
		match_dict[str(length)] = []
	match_dict[str(length)].append((index_t, index_p))


def scanpattern(search_len, tokens_t, tokens_p, match_dict, hash_dict):
	if search_len < 1:
		print("Search length must be bigger than 1! \n")
		return -1
	token_t_len = len(tokens_t) - search_len + 1
	token_p_len = len(tokens_p) - search_len + 1
	if token_p_len < 1 or token_t_len < 1:
		print("Search length too big!")
		return
	global_max = 0
	previous_hash = None
	# Hashiranje programa T
	for i in range(0, token_t_len):
		new_index = distance_to_next(i, search_len, tokens_t)
		if new_index is not None:
			i = find_next_position(new_index, tokens_t) - 1
			previous_hash = None
			continue
		else:
			token_hash = rolling_hash(i, search_len, tokens_t, previous_hash)
			previous_hash = token_hash
			add_to_hashtable(i, token_hash, hash_dict)

	# Hashiranje programa P
	previous_hash = None
	for i in range(0, token_p_len):
		new_index = distance_to_next(i, search_len, tokens_p)
		if new_index is not None:
			i = find_next_position(new_index, tokens_p) - 1
			previous_hash = None
			continue
		else:
			token_hash = rolling_hash(i, search_len, tokens_p, previous_hash)
			previous_hash = token_hash
			matches = check_for_match(token_hash, hash_dict)
			# Usporedivanje jednakih hasheva u potrazi za najduljim nepokrivenim podudaranjem
			if matches is not None:
				for match in matches:
					max_len = search_len
					while (not out_of_bounds(match, i, max_len, tokens_t, tokens_p)) and (not marked(tokens_t, match + max_len) and (not marked(tokens_p, i + max_len))):
						first = tokens_t[match + max_len]
						second = tokens_p[i + max_len]
						if tokens_t[match + max_len][1] == tokens_p[i + max_len][1]:
							max_len += 1
						else:
							break
					if max_len > 2 * search_len:
						return max_len
					else:
						record_match(match, i, max_len, match_dict)
					# Ako je ovo najduze podudaranje zabiljezi
					if max_len > global_max:
						global_max = max_len
	# Vrati duljinu najduljeg podudaranja
	return global_max


def find_marked_parts(match, length, tokens_t, tokens_p):
	start = 0
	end = length
	occluded_flag = False
	if tokens_t[match[0]][0] is None or tokens_p[match[1]][0] is None:
		occluded_flag = True
		for i in range(0, length):
			if tokens_t[match[0] + i][0] is not None and tokens_p[match[1] + i][0] is not None:
				start = i
	if tokens_t[match[0] + length - 1][0] is None or tokens_p[match[1] + length - 1][1] is None:
		occluded_flag = True
		for i in range(length - 1, -1, -1):
			if tokens_t[match[0] + i][0] is not None and tokens_p[match[1] + i][0] is not None:
				end = i
	if not occluded_flag:
		return None
	else:
		if start == 0 and end == length:
			return 0, 0
		else:
			return start, end


def replace_unmarked(match, not_occluded, match_dict):
	record_match(match[0] + not_occluded[0], match[1] + not_occluded[0], not_occluded[1] - not_occluded[0] + 1, match_dict)


def originals_match(match, search_len, tokens_t, tokens_p):
	for i in range(0, search_len):
		if tokens_t[match[0] + i] != tokens_p[match[1] + i]:
			return False
	return True


def markstrings(max_len, search_len, match_dict, tokens_t, tokens_p):
	tokens_tiled = 0;
	for i in range(max_len, 0, -1):
		current_matches = match_dict.get(str(i))
		if current_matches is None:
			continue
		else:
			for match in current_matches:
				not_occluded = find_marked_parts(match, i, tokens_t, tokens_p)
				if not_occluded is None:
					if originals_match(match, search_len, tokens_t, tokens_p):
						for j in range(0, i):
							tokens_t[match[0] + j] = (None, tokens_t[match[0] + j][1])
							tokens_p[match[1] + j] = (None,  tokens_p[match[1] + j][1])
						tokens_tiled += i
				# Ako je duljina nepodudarnog dijela veca od s
				elif not_occluded[1] - not_occluded[0] + 1 >= search_len:
					# U match_dict stvavi nepodudarni dio
					replace_unmarked(match, not_occluded, match_dict)
	return tokens_tiled


def print_grade(coverage, len_a, len_b):
	result = (coverage * 2) / (len_a + len_b)
	print('\n{0:.3g}'.format(result * 100) + "%");


def algorithm(initial_size, min_len, tokens_t, tokens_p):
	search_len = initial_size
	coverage = 0
	while True:
		match_dict = dict();
		hash_dict = dict();
		max_len = scanpattern(search_len, tokens_t, tokens_p, match_dict, hash_dict)
		if max_len > 2 * search_len:
			search_len = max_len
		else:
			coverage += markstrings(max_len, search_len, match_dict, tokens_t, tokens_p)
			if search_len > 2 * min_len:
				search_len = search_len // 2;
			elif search_len > min_len:
				search_len = min_len
			else:
				print_grade(coverage, len(tokens_t), len(tokens_p))
				break
	return (coverage * 2) / (len(tokens_t) + len(tokens_p))


def compare_programs(tokens_t, tokens_p):
	return algorithm(20, 6, tokens_t, tokens_p)

