int n = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!synonyms.ContainsKey(word))
    {
        synonyms[word] = new List<string>();
    }

    synonyms[word].Add(synonym);
}

foreach (var kvp in synonyms)
{
    string word = kvp.Key;
    List<string> synonymList = kvp.Value;

    Console.WriteLine($"{word} - {string.Join(", ", synonymList)}");
}
