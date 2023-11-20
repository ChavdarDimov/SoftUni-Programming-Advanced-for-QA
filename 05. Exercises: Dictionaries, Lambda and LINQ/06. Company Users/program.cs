Dictionary<string, HashSet<string>> companies = new Dictionary<string, HashSet<string>>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "End")
    {
        break;
    }

    string[] tokens = input.Split(" -> ");
    string companyName = tokens[0];
    string employeeId = tokens[1];

    if (!companies.ContainsKey(companyName))
    {
        companies[companyName] = new HashSet<string>();
    }

    companies[companyName].Add(employeeId);
}

foreach (var kvp in companies)
{
    Console.WriteLine($"{kvp.Key}");
    foreach (var employeeId in kvp.Value)
    {
        Console.WriteLine($"-- {employeeId}");
    }
}
