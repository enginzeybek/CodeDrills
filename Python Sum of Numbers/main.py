strNumbers = input("Virgül ile rakamlar giriniz.")
if not strNumbers:
    print("BOŞ GEÇMEYİNİZ")
    exit()

strNumbers = strNumbers.strip()
strNumbers = strNumbers.split(",")   
intNumbers = list(map(int,strNumbers))
numbersSum = 0
for number in intNumbers:
    numbersSum = number + numbersSum

print(f"Toplam: {numbersSum}")