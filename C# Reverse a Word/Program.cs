using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Bir kelime giriniz");
string? word = Console.ReadLine();
if (string.IsNullOrWhiteSpace(word))
{
    Console.WriteLine("Geçerli bir ifade giriniz!");
    return;
}
//İlk yol
/*word = word.ToLower();
string? reverseWord = new string(word.Reverse().ToArray());
Console.WriteLine($"Sonuç: {reverseWord}");*/

//İkinci yol
char[] reverseWord = new char[word.Length];
for (int i = word.Length - 1; i >= 0; i--)
{
    reverseWord[word.Length - 1 - i] = word[i];
}
string reverseNew = new string(reverseWord);
Console.WriteLine($"Sonuç: {reverseNew}");
