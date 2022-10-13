int guessNum = ChooseNumber();
int generatedNumber = GenerateRandomNumber();
int numOfIterations = 0;

while (guessNum != generatedNumber)
{
    Console.WriteLine($"Numero gerado: {generatedNumber}");
    Console.WriteLine($"Numero escolhido: {guessNum}");

    if(generatedNumber > guessNum)
    {
        Console.WriteLine($"Mystery number is Higher than {guessNum}");
    }
    else if(generatedNumber < guessNum)
    {
        Console.WriteLine($"Mystery number is lower than {guessNum}");
    }

    numOfIterations++;
    guessNum = ChooseNumber();
}

Console.WriteLine($"That is correct. You guessed the number after {numOfIterations} times!");
Console.ReadLine();

static int GenerateRandomNumber()
{
    Random randomNum = new();
    var generatedNumber = randomNum.Next(1, 5);
    return generatedNumber;
}

static int ChooseNumber()
{
    int guessNum;

    Console.WriteLine("Choose a number between 1 and 5");
    string? strGuess = Console.ReadLine();

    while (int.TryParse(strGuess, out guessNum) == false || guessNum < 1 || guessNum > 100)
    {
        Console.WriteLine("Invalid value");
    };
    return guessNum;
}