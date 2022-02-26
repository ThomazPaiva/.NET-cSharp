using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Second = 10s = 10 seconds");
            Console.WriteLine("M = Minute = 1m = 1 minute");
            Console.WriteLine("0 = 0s = Exit");
            Console.WriteLine("");
            Console.WriteLine("How long do you want to count?");

            string data = Console.ReadLine().ToLower();
            //pega o último caracter
            char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplier = 1;

            if(type == 'm')
            {
                multiplier = 60;
            }
            if(time == 0)
            {
                System.Environment.Exit(0);
            }

            PrepStart(time * multiplier);
        }

        static void PrepStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch completed !!");
            Thread.Sleep(1000);
            Menu();
        }

    }
}
