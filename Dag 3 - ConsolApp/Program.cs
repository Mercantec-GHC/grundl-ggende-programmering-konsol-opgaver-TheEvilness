/* Project 1 section.
while (true)
{
	Console.Clear();
	Console.WriteLine("Input a number between 5 and 10.");
	Console.Write("Input: ");
	string? input = Console.ReadLine();
	int inputAsNumber = -9999;
	int.TryParse(input, out inputAsNumber);
	if (inputAsNumber == -9999)
	{
		Console.WriteLine("Input was not a valid integer.");
		Console.WriteLine("Press any key to try again.");
		Console.ReadKey();
	}
	if (inputAsNumber > 5 && inputAsNumber < 10)
	{
		break;
	}
	else
	{
		Console.WriteLine("Input needs to be between 5 and 10.");
		Console.WriteLine("Press any key to try again.");
		Console.ReadKey();
	}
}
Console.WriteLine("Input was valid");
End project 1 section. */

/*Project 2 section.
string[] roles = new string[] { "administrator", "manager", "user" };
string? input = "";
while (true)
{
	Console.Clear();
	Console.WriteLine("Enter your role (Administrator, Manager or User).");
	Console.Write("Input: ");
	input = Console.ReadLine();
	if (roles.Contains(input.ToLower().Trim()))
	{
		break;
	}
	else
	{
		Console.WriteLine($"{input} is not a valid role.");
		Console.WriteLine("Press any key to try again.");
		Console.ReadKey();
	}
}
Console.WriteLine($"Role {input} was accepted.");
End project 2 section. */

/*Project 3 section.
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
foreach (string text in myStrings)
{
	string myString = text;
	periodLocation = myString.IndexOf('.');

	while (periodLocation != -1)
	{
		string output = myString.Remove(periodLocation);
		myString = myString.Substring(periodLocation + 1);
		myString = myString.TrimStart();
		periodLocation = myString.IndexOf('.');
		Console.WriteLine(output);
	}
	myString = myString.TrimStart();
	Console.WriteLine(myString);
}
End project 3 section. */