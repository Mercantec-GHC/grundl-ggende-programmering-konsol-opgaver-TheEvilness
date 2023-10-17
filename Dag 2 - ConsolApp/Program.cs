//This code section reverses a message, returns the amount a certain character appears, and prints it to the console.

string originalMessage = "The quick brown fox jumps over the lazy dog.";
char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int charCount = 0;
foreach (char letter in message)
{
	if (letter == 'o')
	{
		charCount++;
	}
}

string modifiedMessage = new String(message);
Console.WriteLine(modifiedMessage);
Console.WriteLine($"'o' appears {charCount} times.");