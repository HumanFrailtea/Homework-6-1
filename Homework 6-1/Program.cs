using System;

namespace Homework_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int heads = 0;
            int tails = 0;
            String toss;
            Console.WriteLine("For each coin enter either h for heads or t for tails");

            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine("Toss" + i + ":");
                toss = Console.ReadLine();

                if (toss.Equals("h"))
                    {
                    heads++;
                        }
                else
                {
                    tails++;
                }


                Console.WriteLine("Number of heads: " + heads);
            Console.WriteLine("Number of tails: " + tails);
            Console.WriteLine("Percent heads: " + (heads*100/8));
            Console.WriteLine("Percent tailss: " + (tails*100/8));







            }
    }
    }
}
