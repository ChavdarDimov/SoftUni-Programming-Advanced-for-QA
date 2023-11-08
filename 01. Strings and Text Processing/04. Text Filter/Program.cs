string[] banWOrds = Console.ReadLine().Split(", ");

string text = Console.ReadLine();

foreach (string banWord in banWOrds)
{
    if (text.Contains(banWord))
    {
        text = text.Replace(banWord, new string('*', banWord.Length));
    }
}

Console.WriteLine(text);
