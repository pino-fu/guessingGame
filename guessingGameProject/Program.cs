using System;

Console.WriteLine("Welcome to the Guessing Game");
Console.WriteLine("-----------------------------");

string question = "What do you think the secret number is?";


void GameAsks(string question)
{
    Console.WriteLine($"{question}");
    string answer = Console.ReadLine();
    Console.WriteLine($"You guessed the number {answer}");
};

GameAsks(question);
