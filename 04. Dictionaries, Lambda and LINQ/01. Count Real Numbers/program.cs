List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

Dictionary<int, int> countDic = new();

foreach (var number in numbers)
{
    if (countDic.ContainsKey(number))
    {
        countDic[number]++;
    }

    else
    {
        countDic.Add(number, 1);
    }

}

foreach (var kvp in countDic.OrderBy(x => x.Key))
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}
