using System;

Random r = new Random();
int SecretNum = r.Next(1, 100);

void NumberPrompt(string question, int secretNum)
{
    Console.WriteLine(secretNum);
    Console.WriteLine("easy, medium, hard or cheater?");
    string difficultyAnswer = Console.ReadLine();

    int numOfTurns = 0;

    if (difficultyAnswer == "easy")
    {
        numOfTurns = 8;
    }
    if (difficultyAnswer == "medium")
    {
        numOfTurns = 6;
    }
    if (difficultyAnswer == "hard")
    {
        numOfTurns = 4;
    }
    if (difficultyAnswer == "cheater")
    {
        numOfTurns = int.MaxValue;
    }
    for (int i = 0; i < numOfTurns; i++)
    {
        Console.WriteLine($"{question}");
        string answer = Console.ReadLine();
        int parsedAnswer = int.Parse(answer);
        if (parsedAnswer == secretNum)
        {
            Console.WriteLine("Correct Number");
            return;
        }
        else
        {
            if (parsedAnswer < secretNum)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("Too High");
            }
            Console.WriteLine($"You have {numOfTurns - (i + 1)} guesses remaining");
        }
    }
}

NumberPrompt("Guess number", SecretNum);