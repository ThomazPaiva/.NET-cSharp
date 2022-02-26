using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number inbetween 0 and 100: ");
                int n = int.Parse(Console.ReadLine());

                if(n > winNum)
                {
                    Console.WriteLine("To high ! Guess lower");
                }

                else if (n < winNum)
                {
                    Console.WriteLine("To low");
                }
                
                else if (n == winNum)
                {
                    Console.WriteLine("You win !");
                    win = true;
                }
                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank you for playing the game");
            Console.Write("Press any key to finish");
            Console.ReadKey(true);
        }

    }
}
