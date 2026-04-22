Console.WriteLine("Lütfen virgül ile ayırarak rakamlar giriniz.");
string? strNumbers = Console.ReadLine();
if (string.IsNullOrWhiteSpace(strNumbers))
{
    Console.WriteLine("GEÇERLİ BİR İFADE GİRİNİZ!!!");
    return;
}
string[] strArrays = strNumbers.Split(',');
int[] intArrays = Array.ConvertAll(strArrays,int.Parse);
int maxNumber = intArrays[0];
for (int i = 1; i < intArrays.Length; i++)
{
    strArrays[i] = strArrays[i].Trim();
    if (maxNumber < intArrays[i])
    {
        maxNumber = intArrays[i];
    }
}

Console.WriteLine($"Max number: {maxNumber}");
