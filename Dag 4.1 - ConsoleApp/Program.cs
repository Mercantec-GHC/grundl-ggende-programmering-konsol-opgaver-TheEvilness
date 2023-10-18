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
}