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
        private Enemy goblin;

        // things it can do
        public Game()
        {
            // set things it knows to a default
            isPlaying = false;
            player = new Player("Player1", 100);
            goblin = new Enemy("Goblin", 10, 1);
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
            Console.WriteLine("The goblin sneers at you!");
            Console.WriteLine("The goblin takes a wild swing!");
            player.TakeDamage(goblin.AttackPower);
          

            // check for game end
            if (!player.IsAlive())
            {
                Console.WriteLine("You have died. Ending the game.");
                StopGame();
            }

            Console.WriteLine("You swing back at the goblin.");
            goblin.TakeDamage(player.AttackPower);

            if (!goblin.IsAlive())
            {
                Console.WriteLine("The goblin is slain!");
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

    }
}
