﻿using System;

Console.Write("Guess a secret number:");
int secretNumber = 42;

int attemptsRemaining = 4;
while (attemptsRemaining > 0)
{
    attemptsRemaining--;
    int guessedNumber = int.Parse(Console.ReadLine());
    string attemptsMessage = (attemptsRemaining > 0) ? $"{attemptsRemaining} attempts left... " : "GAME OVER";
    bool correct = (guessedNumber == secretNumber);
    string result = (guessedNumber == secretNumber)
    ? "You guessed the secret number!" : attemptsMessage;
    Console.WriteLine(result);
    if (correct)
    {
        break;
    }
};