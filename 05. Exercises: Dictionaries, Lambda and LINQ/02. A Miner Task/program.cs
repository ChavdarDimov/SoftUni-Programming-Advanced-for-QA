Dictionary<string, int> resourceAndQuantity = new();

string resource = Console.ReadLine();

while (resource != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (resourceAndQuantity.ContainsKey(resource))
    {
        resourceAndQuantity[resource] += quantity;
    }
    else
    {
        resourceAndQuantity.Add(resource, quantity);
    }

    resource = Console.ReadLine();
}

foreach (var pair in resourceAndQuantity)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
