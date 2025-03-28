using System;


namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Create a new Enemy
            //Enemy loki = new Enemy("Loki");
            // Changed my mind. Let ’s use the full name.
            //loki.SetName(" Grindalokki ");
            // Show name and health
            //Console.WriteLine ($"Name is {loki.GetName()} and HP is {loki.GetHealth()}");

            int size = int.Parse(args[0]);
            Enemy[] array = new Enemy[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}:");
                string name = Console.ReadLine();
                array[i] = new Enemy(name);
            }

            foreach (Enemy name in array)
            {
                Console.WriteLine($"{name.GetName()} {name.GetHealth()} {name.GetShield()} ");
            }

            //PowerUps + Damage
            array[0].PickupPowerUp(PowerUp.Health, 20);
            array[0].PickupPowerUp(PowerUp.Shield, 30);
            array[1].TakeDamage(40);

            
            foreach (Enemy name in array)
            {
                
                Console.WriteLine($"{name.GetName()} {name.GetHealth()} {name.GetShield()} ");
            }

            Console.WriteLine($"PowerUps Collected : {Enemy.GetPowerUps()}");


        }
    }
}
