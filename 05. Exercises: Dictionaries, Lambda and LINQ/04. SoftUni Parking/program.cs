Dictionary<string, string> regs = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] commandArray = Console.ReadLine().Split().ToArray();

    string command = commandArray[0];
    string employee = commandArray[1];

    if (command == "register")
    {
        string plateNumber = commandArray[2];
        if (!regs.ContainsKey(employee))
        {
            regs.Add(employee, plateNumber);

            Console.WriteLine($"{employee} registered {plateNumber} successfully");
        }

        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {regs[employee]}");
        }
    }
    else if (command == "unregister")
    {
        if (regs.ContainsKey(employee))
        {
            regs.Remove(employee);
            Console.WriteLine($"{employee} unregistered successfully");
        }

        else
        {
            Console.WriteLine($"ERROR: user {employee} not found");
        }
    }
}

foreach (var pair in regs)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}
