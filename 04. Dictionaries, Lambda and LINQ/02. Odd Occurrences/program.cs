string[] words = Console.ReadLine().Split(' ');

Dictionary<string, int> wordCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

foreach (var word in words)
{
    if (wordCounts.ContainsKey(word.ToLower()))
    {
        wordCounts[word.ToLower()]++;
    }
    else
    {
        wordCounts[word.ToLower()] = 1;
    }
}

List<string> result = new List<string>();

foreach (var word in words)
{
    if (wordCounts[word.ToLower()] % 2 != 0)
    {
        if (!result.Contains(word.ToLower()))
        {
            result.Add(word.ToLower());
        }
    }
}

Console.WriteLine(string.Join(" ", result));
