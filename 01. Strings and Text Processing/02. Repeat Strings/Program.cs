string[] arrayOfStrings = Console.ReadLine().Split();

string result = "";

foreach (string word in arrayOfStrings)
{
    int repeatCoutner = word.Length;

    for (int i = 0; i < repeatCoutner; i++)
    {
        result = result + word;
    }
}

Console.WriteLine(result);

