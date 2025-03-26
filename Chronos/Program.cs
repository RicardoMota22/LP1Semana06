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
            //Stop timer
            crono1.Stop();

            //count crono2
            crono2.Start();
            Thread.Sleep(250);
            
            //Stop timer2
            crono2.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;

            // Format and display the TimeSpan value (4DP).
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts2.Hours, ts2.Minutes, ts2.Seconds,
                ts2.Milliseconds / 10);
            
            Console.WriteLine($"RunTime = {ts.TotalSeconds:F4}");
            Console.WriteLine($"RunTime = {ts2.TotalSeconds:F4}");

            


        }
    }
}
