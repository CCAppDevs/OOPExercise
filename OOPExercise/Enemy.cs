using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    public class Enemy : Character
    {
        public Enemy(string name, int health, int strength) : base(name, health)
        {
            Strength = strength;
        }
    }
}
