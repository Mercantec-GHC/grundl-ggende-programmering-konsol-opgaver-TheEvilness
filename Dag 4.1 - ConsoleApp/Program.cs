/* First exercise
string pangram = "The quick brown fox jumps over the lazy dog";

string[] split = pangram.Split(" ");
List<string> reversedWords = new List<string>();
foreach (string word in split)
{
	char[] array = word.ToCharArray();
	Array.Reverse(array);
	reversedWords.Add(new string(array));
}
foreach (string word in reversedWords)
{
	Console.Write($"{word} ");
}*/

/* Second exercise
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
List<string> split = orderStream.Split(',').ToList();
split.Sort();

foreach (string orderid in split)
{
	string error = "";
	if (orderid.Length != 4)
	{
		error = "\t- Error";
	}
	Console.WriteLine($"{orderid}{error}");
}*/

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine("Dear Ms. Barros,");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\r\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentProduct:P}.\r\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\r\n");
Console.WriteLine("Here's a quick comparison:\n");
string comparisonMessage = "";
comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Your logic here

Console.WriteLine(comparisonMessage);