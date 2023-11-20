string[] words = Console.ReadLine().Split();

var filteredWords = words.Where(word => word.Length % 2 == 0);

foreach (var word in filteredWords)
{
    Console.WriteLine(word);
}
