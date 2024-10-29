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

            for (int i = 0; i < 10; i++)
            {
                myCharacter.TakeDamage(1);
            }

            Enemy goblin = new Enemy("Gobbo", 10, 1);
            Enemy troll = new Enemy("Trolli", 100, 3);
        }
    }
}
