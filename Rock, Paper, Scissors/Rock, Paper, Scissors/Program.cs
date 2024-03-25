using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors!");
            Console.WriteLine("Enter your choice (rock, paper, or scissors) or 'quit' to exit:");

            string playerChoice = Console.ReadLine().ToLower();
            if (playerChoice == "quit")
                break;

            string computerChoice = GetComputerChoice();

            Console.WriteLine($"Computer chooses {computerChoice}.");

            string result = GetWinner(playerChoice, computerChoice);
            Console.WriteLine(result);
        }
    }

    static string GetComputerChoice()
    {
        Random random = new Random();
        int choice = random.Next(1, 4);
        switch (choice)
        {
            case 1:
                return "rock";
            case 2:
                return "paper";
            case 3:
                return "scissors";
            default:
                return "";
        }
    }

    static string GetWinner(string playerChoice, string computerChoice)
    {
        if (playerChoice == computerChoice)
            return "It's a tie!";
        else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                 (playerChoice == "paper" && computerChoice == "rock") ||
                 (playerChoice == "scissors" && computerChoice == "paper"))
            return "You win!";
        else
            return "Computer wins!";
    }
}
