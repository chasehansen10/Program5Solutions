using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins(10000);
            FlipForHeads(10000);
            Console.ReadKey();
        }
        //creates new function
        static void FlipCoins(int numberOfFlips)
        {
            //setup for the loop and counters
            int numberOfHeads = 0;
            int numberOfTails = 0;
            Random rng = new Random();
            
            for(int i=0; i<numberOfFlips; i++)
            {
                int randomNumber = rng.Next(0, 2);
                if(randomNumber==0)
                {
                    numberOfHeads++;
                }
                else
                {
                    numberOfTails++;
                }
            }
            Console.WriteLine("We flipped a coin " + numberOfFlips + " times.");
            Console.WriteLine("Number of heads: " + numberOfHeads);
            Console.WriteLine("Number of tails: " + numberOfTails);
        }
        static void FlipForHeads(int numberOfHeads)
        {
            //setup for my numberOfHeadsFlipped and totalFlips
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;
            Random rng= new Random();
            //loops until numheadflip
            while(numberOfHeadsFlipped<=numberOfHeads)
            {
                totalFlips++;
                int randomNumber=rng.Next(0, 2);
                if(randomNumber==0)
                {
                    numberOfHeadsFlipped++;
                }

                
            }
            
            Console.WriteLine("We are flipping a coin until we find " + numberOfHeads + " heads.");
            Console.WriteLine("It took " + totalFlips + " to find " + numberOfHeads + " heads.");
            
            

            

        }
    }
}
