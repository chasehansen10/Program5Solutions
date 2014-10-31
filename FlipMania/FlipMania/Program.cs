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
            Console.WriteLine();
            FlipForHeads(10000);
            Console.WriteLine();
            rollingDie(50000);
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
        static void rollingDie(int numberOfTimesRolled)
        {
            int numberOfSideOneRolled = 0;
            int numberOfSideTwoRolled = 0;
            int numberOfSideThreeRolled = 0;
            int numberOfSideFourRolled = 0;
            int numberOfSideFiveRolled = 0;
            int numberOfSideSixRolled = 0;
            Random rng = new Random();
            for(int i=0; i<numberOfTimesRolled;i++)
            {
                int randomSide = rng.Next(0,6);
                if(randomSide==0)
                {
                    numberOfSideOneRolled++;
                }
                else if(randomSide==1)
                {
                    numberOfSideTwoRolled++;
                }
                else if(randomSide==2)
                {
                    numberOfSideThreeRolled++;
                }
                else if(randomSide==3)
                {
                    numberOfSideFourRolled++;
                }
                else if(randomSide==4)
                {
                    numberOfSideFiveRolled++;
                }
                else
                {
                    numberOfSideSixRolled++;
                }
                

            }
            Console.WriteLine("You rolled the die " + numberOfTimesRolled + " times.");
            Console.WriteLine();
            Console.WriteLine("You rolled side one " + numberOfSideOneRolled + " times.");
            Console.WriteLine("You rolled side two " + numberOfSideTwoRolled + " times.");
            Console.WriteLine("You rolled side three " + numberOfSideThreeRolled + " times.");
            Console.WriteLine("You rolled side four " + numberOfSideFourRolled + " times.");
            Console.WriteLine("You rolled side five " + numberOfSideFiveRolled + " times.");
            Console.WriteLine("You rolled side six " + numberOfSideSixRolled + " times.");

        }

    }
}
