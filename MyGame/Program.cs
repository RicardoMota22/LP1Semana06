using System;


namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
        // Creating an instance of the Enemy class
        Enemy enemy1 = new Enemy("Orc");
        Enemy enemy2 = new Enemy("Goblin");

        Console.WriteLine("Enemies created successfully!");
        Console.WriteLine(enemy1);
        }
    }
}
