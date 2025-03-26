using System;

namespace RandomTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random r1 = new Random(22);
            Random r2 = new Random(22);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r1.Next());
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r2.Next());
            Console.WriteLine();
            
            //Show changing one doesnt change the other
            r1 = new Random(23);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r1.Next());
            Console.WriteLine();
            
            //Stand in for r2
            Random r3 = new Random(22);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r3.Next());
            Console.WriteLine();

        }
    }
}
