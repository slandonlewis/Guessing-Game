using System;

Console.WriteLine("*** GAME MODES ***");
Console.WriteLine("--(e)Easy (8 Attempts)");
Console.WriteLine("--(m)Medium (6 Attempts)");
Console.WriteLine("--(h)Hard (4 Attempts)");
Console.Write("\nChoose Difficuly: ");
string difficulty = Console.ReadLine().ToLower();
int attemptsRemaining = 0;
switch (difficulty)
{
    case "e":
        attemptsRemaining = 8;
        Console.WriteLine($"\nEASY Mode Selected! Attempts: {attemptsRemaining}");
        break;

    case "m":
        attemptsRemaining = 6;
        Console.WriteLine($"\nMEDIUM Mode Selected! Attempts: {attemptsRemaining}");
        break;

    case "h":
        attemptsRemaining = 4;
        Console.WriteLine($"\nHARD Mode Selected! Attempts: {attemptsRemaining}");
        break;
}

Console.Write("Guess a secret number:");
int secretNumber = new Random().Next(1, 101);
while (attemptsRemaining > 0)
{
    attemptsRemaining--;
    int guessedNumber = int.Parse(Console.ReadLine());
    string highOrLow = (guessedNumber > secretNumber)
    ? "Too High!" : "Too Low!";
    string attemptsMessage = (attemptsRemaining > 0) ? $"\n{highOrLow} {attemptsRemaining} attempts left... " : $"\nSecret number was {secretNumber}...\nGAME OVER";
    bool correct = (guessedNumber == secretNumber);
    string result = (guessedNumber == secretNumber)
    ? "\nYou guessed the secret number!" : attemptsMessage;
    Console.WriteLine(result);
    if (correct)
    {
        break;
    }
};