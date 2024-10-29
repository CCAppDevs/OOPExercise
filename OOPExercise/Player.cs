using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    public class Player : Character
    {
        public Player(string name, int health) : base(name, health)
        {
        }

        public void Respawn()
        {
            Console.WriteLine(Name + " comes back to life!");
            CurrentHealth = MaxHealth;
        }

        public override void HitReact()
        {
            Console.WriteLine(Name + ": Ouch! That hurt!");
        }
    }
}
