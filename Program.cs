#region Analysis - MULTIPLAYER
/**
GAME ALGORITHM / FLOW
=====================

player1 PLAYS the game (UNTIL find the mystery number)
player1 gets the result1 (= number of iterations)

player2 PLAYS the game (UNTIL find the mystery number)
player2 gets the result2 (= number of iterations)

computer compares result1 and result2. lower value wins!
**/
#endregion

using MysteryNumber;

Player player1 = new()
{
	Name = "Player 1"
};

Player player2 = new()
{
	Name = "Player 2"
};

Console.WriteLine("MYSTERY NUMBER");
Console.WriteLine("==============");
Console.WriteLine();
Console.WriteLine($"Name: {player1.Name}");
Console.WriteLine($"Name: {player2.Name}");
Console.WriteLine();

List<Player> players = new() { player1, player2 };

Game.Play(players);

Console.ReadLine();