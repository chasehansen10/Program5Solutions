using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0&&i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3==0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            LetterFinder("f", "ffffuck");
            
            Console.ReadKey();
        }
        static void LetterFinder(string letter, string word)
        {
            int count = 0;
            
            
            for(int i = 0; i<word.Length;i++)
            {
                string currentLetter = word[i].ToString().ToLower();
                if(letter.ToLower()== currentLetter)
                {

                    count++;
                }

            }
            Console.WriteLine(word+" has "+count+" "+letter+"'s in it");
        }
        static void WordFinder(string word, string bunchOfWords)
        {
            int wordCounter = 0;
            

        }

    }
}
