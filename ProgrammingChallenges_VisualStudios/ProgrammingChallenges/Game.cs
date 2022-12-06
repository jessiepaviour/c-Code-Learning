using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenges
{
    public class Game
    {
        public void Start()
        {
            Console.WriteLine("game started");

            Console.Write("Name:");
            string characterName = Console.ReadLine();
            int maxHP = 100;
            bool isPlayer = true;

            Character player = new Character(characterName, maxHP, isPlayer);
            Character enemy = new Character("Titan", 50, false);

            player.Attack(enemy);
            enemy.Attack(player);
        }
    }
}