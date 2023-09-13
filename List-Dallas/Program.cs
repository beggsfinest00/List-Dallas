
//creats a list of strings
List<string> games = new List<string>
{
    "CS:GO",
    "Halo 3",
    "Borderland 3",
    "Fifa 22",
    "Minecraft"
};

//creats a list of other game
string[] otherGames = new string[]
{
    "Tiny TinaWonderlands",
    "Farcry 3",
};

//makes a foreach statmennt for game
foreach (string game in games)
{
    Console.WriteLine(game);
}

//prints each game in the list
Console.WriteLine($"\nGames in list: {games.Count}");
//creats a Range for otherGames
games.AddRange(otherGames);
//prints each game in the list
Console.WriteLine($"\nGame in list: {games.Count}");

//makes a if statement that prints MASTER CHEIF is in the house!! and if not prints Halo
if (games.Contains("Halo"))
{
    Console.WriteLine("\nMASTER CHEIF is in the house!!");
}
else
{
    games.Add("Halo");
}

//creats a int object named myInt and set the vaule to 6
int myInt = 6;

//creats a if statment that removes and if not  then prints game not found
if (myInt < games.Count)
{
    games.RemoveAt(myInt);
}
else
{
    Console.WriteLine("\nGame not found!");
}
//prints All games in the list for each game writes the name of the game
Console.WriteLine("\nAll games in the list:");
foreach (string game in games)
{
    Console.WriteLine(game);
}

//sorts the games and writes them out in a list named sorted games list.
games.Sort();

Console.WriteLine("\nSorted games list:");
foreach (string game in games)
{
    Console.WriteLine(game);
}
//makes a new list of strings
string[] newList = new string[games.Count];
//copys games to newlist
games.CopyTo(newList);
//clears games
games.Clear();
//wirtes new list and makes a list componet for each game
Console.WriteLine("\nNew list:");
foreach (string game in newList)
{
    Console.WriteLine(game);
}