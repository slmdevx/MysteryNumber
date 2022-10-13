namespace MysteryNumber;

internal static class GameHelpers
{

    /// <summary>
    /// Read a guessing number
    /// </summary>
    /// <returns></returns>
    internal static int ChooseNumber()
    {
        int guessNum;
        do
        {
            Console.Write("Choose a number (Between 1 and 5): ");
            int.TryParse(Console.ReadLine(), out guessNum);
        } while (guessNum < 1 || guessNum > 5);

        return guessNum;
    }


    /// <summary>
    /// Generates a random number
    /// </summary>
    /// <returns></returns>
    internal static int GenerateRandomNumber()
    {
        Random randomNum = new();
        var generatedNumber = randomNum.Next(1, 5);
        return generatedNumber;
    }
}