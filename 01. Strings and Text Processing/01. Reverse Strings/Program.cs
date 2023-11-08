string input = Console.ReadLine();

while (input != "end")
{
    Console.WriteLine(input + " = " + Reverse(input));

    input = Console.ReadLine();
}

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}