Console.WriteLine("Bir metin giriniz.");
string sentence = Console.ReadLine();
if (string.IsNullOrWhiteSpace(sentence))
{
    Console.WriteLine("Boş geçmeyiniz");
    return;
}

int count = 0;

foreach (var item in sentence)
{
    if (char.IsDigit(item))
    {
        count++;
    }
}

Console.WriteLine($"Digit count: {count}");
