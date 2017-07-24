using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace MersennePrimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsoleLogger logger = new ConsoleLogger();

            logger.WriteLine("Welcome to FedGroup Mersenne Prime Calculator by Linda. \nPress the esc key to show mersenner prime numbers that have been calculated so far.");
            
            List<long> mersennePrimes = new List<long>();
            do
            {
                while (!Console.KeyAvailable)
                {
                    for (long i = 0;i<long.MaxValue; i++)
                    {
                        if (IsPrime(i))
                        {
                            long mersennePrime = (long)Math.Pow(2, i) - 1;

                            if (mersennePrime < long.MaxValue)
                            {
                                mersennePrimes.Add(mersennePrime);
                            }

                            if (Console.KeyAvailable)
                                break;
                        }
                    }
                }
                
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            foreach (long m in mersennePrimes)
            {
                logger.WriteLine(m.ToString());
            }

            logger.ReadLine();
        } 

        private static bool IsPrime(long number)
        {
            if (number == 0)
                return false;

            if (number == 1)
                return false;

            if(number == 2)
                return true;

            if (number % 2 == 0) return false;    

            for (long i = 2; i < number; i++)
            { 
                if (number % i == 0) return false;
            }

            return true;
        }
    }

    //Pseudocode
    //Welcome note
    //Go through each number starting from 2 
    //Check if number is a prime number - prime number is only divisible by itself and 1
    //If number is prime number then 
        //Calculate Mersenne Prime - (M = 2 ^n - 1 )

}
