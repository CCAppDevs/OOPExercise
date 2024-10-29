using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    public class Character
    {
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public double Speed { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        private int _BaseDamage;

        public int AttackPower
        {
            get { return _BaseDamage * Strength; }
        }

        public Character(string name, int health)
        {
            Name = name;
            MaxHealth = health;
            CurrentHealth = health;
            Speed = 1.0;
            Strength = 1;
            Intelligence = 1;
            Charisma = 1;
            _BaseDamage = 10;
            PosX = 0;
            PosY = 0;
        }

        // actions of a character
        public void MoveRight(int delta)
        {
            PosX += delta;
        }

        public void Teleport(int x, int y)
        {
            PosX = x;
            PosY = y;
        }

        public void TakeDamage(int damage)
        {
            if (CurrentHealth - damage < 0)
            {
                CurrentHealth = 0;
                // trigger a death
            }
            else
            {
                CurrentHealth -= damage;
                HitReact();
            }
        }

        public virtual void HitReact()
        {
            Console.WriteLine(Name + ": OOF!");
        }
    }
}
