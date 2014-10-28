using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            int myAgeDoubled = DoubleIt(19);
            Console.WriteLine(myAgeDoubled);
            VowelCounter3000Tests();
            //keep console open
            Console.ReadKey();
        }
        /// <summary>
        /// prints hello world to the console
        /// </summary>
        /// <returns></returns>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        static int DoubleIt(int num1)
        {
            return num1 * 2;
        }
        /// <summary>
        /// looping through some number
        /// </summary>
        /// <param name="startNumber"></param>
        /// <param name="endNumber"></param>
        static void LoopSomeNumbers(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// testing the loop
        /// </summary>
        static void LoopTests()
        {
            LoopSomeNumbers(5, 10);
            LoopSomeNumbers(19, DoubleIt(19));
        }
        static int VowelCounter3000(string inputString)
        {
            int numberOfVowelIsFound = 0;
            for(int i=0;i<inputString.Length; i++)
            {
                string letter = inputString[i].ToString().ToLower();
                if(letter == "a"|| letter == "e"|| letter=="i"||letter=="o"||letter=="u")
                {
                    numberOfVowelIsFound = numberOfVowelIsFound +1;
                }
                if("aeiou".Contains(letter)){}

            }
            Console.WriteLine(inputString + " has " + numberOfVowelIsFound + " vowels in it");
            return numberOfVowelIsFound;
        }
        static void VowelCounter3000Tests()
        {
            //count the number of vowels counted
            int totalNumberOfVowelsCounted = 0;
            totalNumberOfVowelsCounted += VowelCounter3000("jackie seems like he likes nickleback");
            totalNumberOfVowelsCounted += VowelCounter3000("the names crystal but its pronounced crist al");
            Console.WriteLine("Total vowels counted: " + totalNumberOfVowelsCounted);
        }

        }

    }

