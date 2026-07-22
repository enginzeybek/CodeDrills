word = input("Kelime giriniz= ")
print(f"Girdiğiniz kelime {word}")

word = word.lower()

vowels = ["a","e","ı","i","o","ö","u","ü"]

if not word:
    print("Lütfen geçerli bir kelime giriniz")
    exit()

count = 0

for item in word:
    if item in vowels:
        count += 1


print(f"Vowel count: {count}")

