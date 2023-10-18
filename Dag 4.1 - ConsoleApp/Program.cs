string[] values = { "12,3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0m;
foreach (string value in values)
{
	if (decimal.TryParse(value, out decimal result))
	{
		total += result;
	}
	else
	{
		message += value;
	}
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");