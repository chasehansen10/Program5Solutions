using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=20;i++)
            {
                FizzBuzz(i);
            }
            Console.ReadKey();
            Console.Clear();
            for(int i= 92;i>=72;i--)
            {
                FizzBuzz(i);
            }
            Console.ReadKey();
            Console.Clear();
            Yodaizer("i like code");
            Console.ReadKey();
            Console.Clear();
            TextStats("Things I like. Paper cuts between my fingers and toes. Stepping on legos in the dark.");
            Console.ReadKey();
            Console.Clear();
            for (int i = 1; i < 26;i+=2 )
            {
                IsPrime(i);
            }
            Console.ReadKey();
            Console.Clear();
            DashInsert(8675309);
            Console.ReadKey();
          
           

        }
        static void FizzBuzz(int number)
        {
            if(number%3==0&&number%5==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number%3==0)
            {
                Console.WriteLine("Buzz");
            }
            else if(number%5==0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(number);
            }
            
        }
        static void Yodaizer (string text)
        {
            string[] myArray= text.Split(' ');
            for(int i=myArray.Count()-1;i>=0;i--)
            {
                if (myArray.Count() < 4)
                {
                    Console.WriteLine(myArray[2] + " " + myArray[0] + " " + myArray[1]);
                    break;
                }
                else
                {
                    Console.WriteLine(myArray[i]);
                }
                
                
            }
           
        }
        static void TextStats(string input)
        {
            int numChar = 0;
            int numWords = 0;
            int numVowels = 0;
            int numConstanants = 0;
            int numSpecialChar = 0;
            string[] myArray = input.Split(' ');
            for(int i =0;i<input.Length;i++)
            {
                numChar++;
                string currentNumber = input[i].ToString().ToLower();
                if("aeiou".Contains(currentNumber))
                {
                    numVowels++;
                }
                else if(" .,?".Contains(currentNumber))
                {
                    numSpecialChar++;
                }
                else
                {
                    numConstanants++;
                }
            }
            numWords = myArray.Count();
            Console.WriteLine("Number of characters: " + numConstanants);
            Console.WriteLine("number of words: " + numWords);
            Console.WriteLine("Number of vowels: " + numVowels);
            Console.WriteLine("Number of constanants: " + numConstanants);
            Console.WriteLine("Number of special characters: " + numSpecialChar);
        }
        static void IsPrime(int number)
        {
            int divisors=0;
            for(int i=1;i<=number;i++)
            {
                if(number%i==0)
                {
                    divisors++;
                }
            }
            if(divisors==2)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number);
            }
            
        }
        static void DashInsert(int number)
        {
            string aNumberString =number.ToString();
            for(int i=0; i<=aNumberString.Length-1;i++)
            {
                if(int.Parse(aNumberString[i].ToString())%2!=0)
                {
                    if(int.Parse(aNumberString[i-1].ToString())%2!=0)
                    {
                        Console.Write("-" + aNumberString[i].ToString());
                    }
                    else
                    {
                        Console.Write(aNumberString[i].ToString());
                    }
                }
                else
                {
                    Console.Write(aNumberString[i].ToString());
                }
                
            
                
            }
            
        }


    }
}
//Hey

//Jenny, Jenny, who can I turn to?
//You give me somethin' I can hold on to
//I know you think I'm like the others before
//Who saw your name and number on the wall

//Jenny, I got your number
//I need to make you mine
//Jenny, don't change your number
//867-5309
//867-5309
//867-5309
//867-5309

//Jenny, Jenny, you're the girl for me
//Oh, you don't know me, but you make me so happy
//I tried to call you before, but I lost my nerve
//I tried my imagination, but I was disturbed

//Jenny, I got your number
//I need to make you mine
//Jenny, don't change your number
//867-5309
//867-5309
//867-5309
//867-5309

//I got it, (I got it), I got it
//I got your number on the wall
//I got it, (I got it), I got it
//For a good time, for a good time call

//Jenny, don't change your number
//I need to make you mine
//Jenny, I call your number
//867-5309
//867-5309
//867-5309
//867-5309

//Jenny, Jenny, who can I turn to?
//867-5309

//For the price of a dime I can always turn to you
//867-5309

//867-5309
//867-5309
//867-5309
//867-5309
//5309
//867-5309 (5309)
//867-5309 (5309)
//867-5309

