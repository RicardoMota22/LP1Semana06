using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Declare and instance  
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            //Count
            crono1.Start();

            //Pause upon 0.5 seconds (500 miliseconds)
            Thread.Sleep(500); 

            
            
            //Stop timers
            crono1.Stop();


        }
    }
}
