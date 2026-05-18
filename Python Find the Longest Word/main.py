words = input("Kelimeler giriniz(Virgül kullanın)")
if words is None or not words.strip():
    print("Geçerli ifade giriniz!")
    exit()

strWords = words.split(",")
longest = strWords[0].strip()

for item in strWords:
    item = item.strip()
    if len(item) > len(longest):
        longest = item

print(f"Longest word: {longest}")
