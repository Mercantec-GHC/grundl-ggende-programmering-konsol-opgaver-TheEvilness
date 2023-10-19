Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
	PlayGame();
}

void PlayGame()
{
	bool play = true;

	while (play)
	{
		int target = GetTargetNumber();
		int roll = GetRollNumber();

		Console.WriteLine($"Roll a number greater than {target} to win!");
		Console.WriteLine($"You rolled a {roll}");
		Console.WriteLine(WinOrLose(target, roll));
		Console.WriteLine("\nPlay again? (Y/N)");

		play = ShouldPlay();
	}
}

bool ShouldPlay()
{
	while (true)
	{
		string? readResult = Console.ReadLine();
		if (readResult == "Y")
		{
			return true;
		}
		if (readResult == "N")
		{
			return false;
		}
		Console.WriteLine("Invalid input.");
	}
}

int GetTargetNumber()
{
	return random.Next(1, 5);
}

int GetRollNumber()
{
	return random.Next(1, 5);
}

string WinOrLose(int target, int roll)
{
	if (roll > target)
	{
		return "You win!";
	}
	return "You lose!";
}