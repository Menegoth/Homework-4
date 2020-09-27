using System;

/// Week 4		Homework 2
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  September 27th 2020

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables
            int heads = 0;
            int tails = 0;

            //ask for user input
            Console.WriteLine("Choose heads(h) or tails(h) 8 times.");

            //loop flip 8 times
            for (int i = 0; i < 8; i++)
            {

                char coin = char.Parse(Console.ReadLine());

                if (coin == 'h')
                {
                    heads++;
                } else if (coin == 't')
                {
                    tails++;
                } else
                {
                    Console.WriteLine("Invalid argument.");
                    i--;
                }
            }

            //output results
            Console.WriteLine("Number of heads: " + heads);
            Console.WriteLine("Number of tails: " + tails);
            Console.WriteLine("Percent heads: " + (heads / 8.0) * 100);
            Console.WriteLine("Percent tails: " + (tails / 8.0) * 100);

        }
    }
}
