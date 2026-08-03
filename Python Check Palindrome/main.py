while True:
    word = input(" Bir kelime giriniz")
    print(f"Kelimeniz: {word}")

    if not word.strip():
        print("Boş Geçmeyiniz")
        break

    word = word.lower()

    word_array = []

    for item in range(len(word) - 1, -1, -1):
        word_array.append(word[item])

    update_word = "".join(word_array)

    print(f"Ters olması gereken kelime: {update_word}")

    if word == update_word:
        print("Palindrome")
    else:
        print("Palindrome Değil")
