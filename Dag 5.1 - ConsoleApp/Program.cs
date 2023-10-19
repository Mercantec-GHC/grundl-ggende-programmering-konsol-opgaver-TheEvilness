string[,] corporate =
{
	{"Robert", "Bavin"}, {"Simon", "Bright"},
	{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
	{"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
	{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
	{"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
	string firstPart = corporate[i, 0].Substring(0, 2);
	string lastPart = corporate[i, 1];
	DisplayEmail(firstPart.ToLower(), lastPart.ToLower());
}

for (int i = 0; i < external.GetLength(0); i++)
{
	string firstPart = external[i, 0].Substring(0, 2);
	string lastPart = external[i, 1];
	DisplayEmail(firstPart.ToLower(), lastPart.ToLower(), externalDomain);
}

void DisplayEmail(string firstPart, string lastPart, string domain = "contoso.com")
{
	string username = firstPart + lastPart;
	string email = $"{username}@{domain}";
	Console.WriteLine(email);
}