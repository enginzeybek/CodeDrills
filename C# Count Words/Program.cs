while(true)
{
    Console.WriteLine("Bir cümle giriniz");
    string sentence = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(sentence))
    {
        Console.WriteLine("Boş geçmeyiniz");
        return;
    }
    sentence = sentence.ToLower();

    string[] sentenceArray = sentence.Split(" ");

    int count = 0;

    for (int i = 0; i < sentenceArray.Length; i++)
    {
        count++;
    }

    Console.WriteLine($"Word count: {count}");

}