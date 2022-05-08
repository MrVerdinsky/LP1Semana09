using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insert number of players: ");
            byte nPlayers = byte.Parse(Console.ReadLine());

            List<Player> listPlayers = new List<Player>() { new Player("Player 1", 0), new Player("Player 2", 0) };
            List<Player> templistPlayers;

            for (int i = 0; i < nPlayers; i++)
            {
                Console.Write($"Insert name of player {i + 1}: ");
                string pName = Console.ReadLine();

                Console.Write($"Insert score of player {i + 1}: ");
                byte pScore = byte.Parse(Console.ReadLine());

                Player p = new Player(pName, pScore);

                listPlayers.Add(p);
            }

            for (int i = 0; i < nPlayers; i++)
            {
                Console.WriteLine($"Name of player {i + 1}: {listPlayers[i].Name}");
                Console.WriteLine($"Score of player {i + 1}: {listPlayers[i].Score}");
                Console.WriteLine();
            }

            Console.WriteLine("Insert Score to search: ");
            byte scoreToSearch = byte.Parse(Console.ReadLine());

            

            Console.WriteLine($"Name of players with score bigger then {scoreToSearch}: ");
            while (true)
            {
                Player tempPlayer = (Player)GetPlayersWithScoreGreaterThen(listPlayers, scoreToSearch);
                Console.WriteLine($"{tempPlayer.Name}");
                Console.WriteLine();
            }
            
        }

        static IEnumerable<Player> GetPlayersWithScoreGreaterThen(List<Player> lPlayers, int s)
        {
            foreach (Player p in lPlayers)
            {
                if (p.Score > s)
                {
                   yield return p;
                }
            }
            yield break;

        }
    }
}
