using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Insert the proper values");
            }

            //Parse values from console from string to int
            int start = int.Parse(args[0]);
            int seed = int.Parse(args[1]);

            int roll = 0;
            Random random = new Random(seed);

            //Throws the amount of dice and calculates amount
            for (int i = 0; i < start; i++)
            {
                roll += random.Next(1, 7); //1 to 6 dice
            }
            Console.WriteLine(roll);

        }
    }
}
