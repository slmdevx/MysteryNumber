namespace MysteryNumber;

public static class Game
{
	/// <summary>
	/// Initializes the game
	/// </summary>
	/// <param name="players"></param>
	public static void Play(List<Player> players)
	{
		foreach (var player in players)
		{
			Console.Write($"{player.Name} - ");
			player.NumOfIteractions = RunGame();			
		}

		ProcessWinner(players);
	}


	/// <summary>
	/// Compares the random and the guess numbers, then returns the number of attempts
	/// </summary>
	/// <returns></returns>
	private static int RunGame()
	{
		int guessNum = GameHelpers.ChooseNumber();
		int generatedNumber = GameHelpers.GenerateRandomNumber();
		int numberOfAttempts = 1;

		while (guessNum != generatedNumber)
		{
			Console.WriteLine($"Chosen number: {guessNum}");

			if (generatedNumber > guessNum)
			{
				Console.WriteLine($"Mystery number is Higher than {guessNum}");
			}
			else if (generatedNumber < guessNum)
			{
				Console.WriteLine($"Mystery number is lower than {guessNum}");
			}

			numberOfAttempts++;
			guessNum = GameHelpers.ChooseNumber();
		}
		return numberOfAttempts;
	}


	/// <summary>
	/// Verifies which player has lowest number of iteractions, declares the winner or tie.
	/// </summary>
	/// <param name="players">List of players</param>
	private static void ProcessWinner(IEnumerable<Player> players)
	{
		foreach (var player in players)
		{
			Console.WriteLine($"{player.Name} attempts: {player.NumOfIteractions}");
		}

		var orderedResultsByNumOfIteractions = players.OrderBy(p => p.NumOfIteractions).ToList();

		int numberOfLowestIteractions = orderedResultsByNumOfIteractions.FindAll(p => p.NumOfIteractions == orderedResultsByNumOfIteractions[0].NumOfIteractions).Count;

		if (numberOfLowestIteractions > 1)
		{
			Console.WriteLine($"Game tied");
			return;
		}

		var winner = players.MinBy(num => num.NumOfIteractions);
		Console.WriteLine($"The winner is {winner.Name}");
	}

}