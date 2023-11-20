Dictionary<string, List<decimal>> products = new();

string input = Console.ReadLine();

while (input != "buy")
{
        string[] inputAray = input.Split();

        string product = inputAray[0];

        decimal price = decimal.Parse(inputAray[1]);

        decimal quantity = decimal.Parse(inputAray[2]);

    if (!products.ContainsKey(product))
    {
        products.Add(product, new List<decimal>());
        products[product].Add(price);
        products[product].Add(quantity);
    }

    else
    {
        products[product][0] = price;
        products[product][1] += quantity;
    }

    input = Console.ReadLine();
}

foreach (KeyValuePair<string, List<decimal>> pair in products)
{
    string currentProductName = pair.Key;
    decimal currentProductPrice = pair.Value[0];
    decimal currentProductQuantity = pair.Value[1];

    decimal currentProductAmount = currentProductPrice * currentProductQuantity;

    Console.WriteLine($"{currentProductName} -> {currentProductAmount}");
}
