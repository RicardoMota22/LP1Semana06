using System;


namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Create a new Enemy
            Enemy loki = new Enemy("Loki");
            // Changed my mind. Let ’s use the full name.
            loki.SetName(" Grindalokki ");
            // Show name and health
            Console.WriteLine ($"Name is {loki.GetName()} and HP is {loki.GetHealth()}");

        }
    }
}
