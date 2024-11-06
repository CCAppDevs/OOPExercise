using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    public class Game
    {
        // things it knows
        private bool isPlaying;

        private Player player;
        private Enemy enemy;

        // things it can do
        public Game()
        {
            // set things it knows to a default
            isPlaying = false;
            player = new Player("Player1", 100);
            enemy = new Enemy("Troll", 1000, 1);
        }

        // Action: startGame
        public void StartGame()
        {
            isPlaying = true;
            Console.WriteLine("Starting Game");
            Run();
        }

        // Action: stopGame
        public void StopGame()
        {
            isPlaying = false;
            Console.WriteLine("Stopping Game");
        }

        public void Update()
        {
            Console.Clear();
            PrintMenu();
            PrintHUD();

            // make a decision on what to do
            int answer = -1;

            Console.Write("What would you like to do? ");
            answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 0:
                    Console.WriteLine("Exiting");
                    StopGame();
                    break;
                case 1:
                    DoCombat();
                    break;
                case 2:
                    // run here
                    Console.WriteLine("You attempt to run but are stopped.");
                    DoCombat();
                    break;
                default:
                    Console.WriteLine("Invalid Option. Please Try Again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private void DoCombat()
        {
            Console.WriteLine($"The {enemy.Name} sneers at you!");
            Console.WriteLine($"The {enemy.Name} takes a wild swing!");
            player.TakeDamage(enemy.AttackPower);

            if (player.IsAlive())
            {
                Console.WriteLine($"You swing back at the {enemy.Name}.");
                enemy.TakeDamage(player.AttackPower);
            }


            // check for game end
            if (!player.IsAlive())
            {
                Console.WriteLine("You have died. Ending the game.");
                StopGame();
            }

            if (!enemy.IsAlive())
            {
                Console.WriteLine($"The {enemy.Name} is slain!");
                StopGame();
            }
        }

        private void Run()
        {
            while (isPlaying)
            {
                Update();
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Combat Menu");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run");
            Console.WriteLine("0. Exit Game");
            Console.WriteLine();
        }

        private void PrintHUD()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Health: {player.CurrentHealth}/{player.MaxHealth}");
            Console.WriteLine("------------------------------");
        }
    }
}
