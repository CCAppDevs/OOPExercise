namespace OOPExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we want to simulate a round of combat with a player and an enemy
            Player myCharacter = new Player("Thor", 100);

            Console.WriteLine(myCharacter.Name + " has entered the battle.");

            Console.WriteLine("Pos X,Y" + myCharacter.PosX + "," + myCharacter.PosY);

            myCharacter.Teleport(1000, 1000);

            Console.WriteLine("Pos X,Y" + myCharacter.PosX + "," + myCharacter.PosY);

            Enemy goblin = new Enemy("Gobbo", 10, 1);
            Enemy troll = new Enemy("Trolli", 100, 3);

            while (DoCombatRound(myCharacter, troll))
            {
                Console.WriteLine("running the combat");
            }

            
        }

        static bool DoCombatRound(Character attacker, Character defender)
        {
            if (attacker.CurrentHealth <= 0)
            {
                // attacker is dead
                return false;
            }

            if (defender.CurrentHealth <= 0)
            {
                // defender is dead
                return false;
            }

            defender.TakeDamage(attacker.AttackPower);
            attacker.TakeDamage(defender.AttackPower);

            return true;
        }
    }
}
