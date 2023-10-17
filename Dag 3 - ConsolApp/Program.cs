int playerHealth = 10;
int monsterHealth = 10;
int damage = 0;
Random random = new Random();
while (playerHealth > 0 && monsterHealth > 0)
{
	damage = random.Next(1, 10);
	monsterHealth -= damage;
	Console.WriteLine("=====================================");
	Console.WriteLine($"Monster was hit for {damage}");
	Console.WriteLine($"Current Monster HP: {monsterHealth}");
	if (monsterHealth > 0)
	{
		damage = random.Next(1, 10);
		playerHealth -= damage;
		Console.WriteLine("=====================================");
		Console.WriteLine($"Player was hit for {damage}");
		Console.WriteLine($"Current Player HP: {playerHealth}");
	}
}
Console.WriteLine("=====================================");
if (playerHealth > 0)
{
	Console.WriteLine("Player won!");
}
else
{
	Console.WriteLine("Monster won!");
}