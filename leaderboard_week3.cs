using System;
using System.Collections.Generic;

class Program
{
    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Game Leaderboard!");
    }

    static Player GetPlayerInfo()
    {
        Console.Write("Enter player name: ");
        string playerName = Console.ReadLine();

        Console.Write("Enter player score: ");
        int playerScore = int.Parse(Console.ReadLine());

        return new Player { Name = playerName, Score = playerScore };
    }

    static void DisplayPlayerInfo(Player player)
    {
        Console.WriteLine($"Player: {player.Name}, Score: {player.Score}");
    }

    static void UpdateLeaderboard(List<Player> leaderboard, Player player)
    {
        leaderboard.Add(player);
        leaderboard.Sort((p1, p2) => p2.Score.CompareTo(p1.Score));
    }

    static void DisplayLeaderboard(List<Player> leaderboard)
    {
        Console.WriteLine("\nLeaderboard:");
        foreach (var player in leaderboard)
        {
            DisplayPlayerInfo(player);
        }
    }

    static void Main()
    {
        WelcomeMessage();

        // Get the number of players
        Console.Write("Enter the number of players: ");
        int numberOfPlayers = int.Parse(Console.ReadLine());

        List<Player> leaderboard = new List<Player>();

        // Get player information and update leaderboard dynamically
        for (int i = 0; i < numberOfPlayers; i++)
        {
            Console.WriteLine($"\nPlayer {i + 1} Information:");
            Player currentPlayer = GetPlayerInfo();
            UpdateLeaderboard(leaderboard, currentPlayer);
        }

        // Display the final leaderboard
        DisplayLeaderboard(leaderboard);
    }
}