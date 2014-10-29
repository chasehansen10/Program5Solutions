using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Chase";
            int myAge = 19;
            bool myBool = true;
            List<string> productList = new List<string>() { "basketball", "baseball glove", "tennis shoes", "hockey puck" };
            Console.WriteLine("My name is "+myName+" and i'm a beast of a programmer");
            Console.WriteLine("I am " + myAge + " years awesome.");
            Console.WriteLine("I set my boolean value to " + myBool);
            // loop through product list
            for (int i = 0; i < productList.Count();i++ )
            {
                Console.WriteLine(productList[i]);
            }
            //looping through 1 to 10
            for (int i = 1; i <= 10;i++ )
            {
                Console.WriteLine(i);
            }
            //loop starting at 10 and going to 1
            for (int i = 10; i >= 1;i-- )
            {
                Console.WriteLine(i);
            }
            //loops 10 to 30 only doing evens
            for (int i = 10; i < 31;i=i+2 )
            {
                Console.WriteLine(i);
            }
            //prints 100 to 75 only printing every 5th number
            for (int i = 100; i > 74;i=i-5 )
            {
                Console.WriteLine(i);
            }
            //started variables cause it was just easier
            newVariable1();
            newVariable2();
            newVariable3();
            newVariable4();
            newVariable5(myBool);
            newVariable6(myName);
            newVariable7(productList.Count());
            newVariable8(productList);
            Greeting("Beef Hardchest");
            Greeting(myName);
            DoubleIt(1337);
            DoubleIt(myAge);
            Multiply(2, 8);
            Multiply(3, myAge);
            LoopThis(20, 30);
            LoopThis(0, myAge);
            LoopThis(50, myAge);
            SuperLoop(0, 100, 15);
            SuperLoop(0, 200, myAge);
            SuperLoop(200, 0, myAge);
            Console.WriteLine(NewGreeting("Niel deGrasse-Tyson"));
            Console.WriteLine(NewGreeting(myName));
            Console.WriteLine("10 tripled is " + TripleIt(10));
            Console.WriteLine(myAge + " tripled is " + TripleIt(myAge));
            Console.WriteLine(RealMultiply(5, 10));
            Console.WriteLine(RealMultiply(2, myAge));
            SuperLoop(RealMultiply(1, 5), TripleIt(myAge), TripleIt(myAge - 10));
            SuperLoop(RealMultiply(1, TripleIt(3)),TripleIt(RealMultiply(myAge,7)),TripleIt(myAge-RealMultiply(2,4)));

                Console.ReadKey();

        }
        //looping 1 to 10
        static void newVariable1()
        {
            int i = 0;
            while(i<11)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
        }
        // looping 10 to 1
        static void newVariable2()
        {
            int i = 10;
            while(i>0)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        // looping 15 to 30 only printing evens
        static void newVariable3()
        {
            int i = 16;
            while(i<31)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
        }
        //looping every 5 numbers from 100 to 75
        static void newVariable4()
        {
            int i = 100;
            while(i>74)
            {
                Console.WriteLine(i);
                i = i - 5;
            }
        }
        //loop 1 to 10 till it hits a number divisible by 4
        static void newVariable5(bool myBool)
        {

            
            while(myBool)
            {
                int i = 0;
                while (i < 10)
                {
                    i++;
                    if (i % 4 == 0)
                    {
                        myBool = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i);
                        
                    }
                }
            }

            

        }
        //tells what my name is and how many letters are in it.
        static void newVariable6(string myName)
        {
         
            int numberOfLetters= myName.Length;
            


            Console.WriteLine("My name, " + myName + ", has " + numberOfLetters + " letters in it.");
        }
        //tells number of products in product list
        static void newVariable7(int number)
        {
            Console.WriteLine("My product list has " + number + " products in it.");
        }
        //loops product list and tells the length
        static void newVariable8(List<string> list)
        {
            for(int i=0; i<list.Count();i++)
            {
                Console.WriteLine(list[i] + " has " + list[i].Length + " in it.");
            }
        }
        //prints name to console
        static void Greeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        // doubles a number
        static void DoubleIt(int number)
        {
            Console.WriteLine(number + " doubled is " + number * 2);
        }
        // multiplys two numbers
        static void Multiply(int num1,int num2)
        {
            Console.WriteLine(num1 + " times " + num2 + " is " + num1 * num2);
        }
        //loops two numbers and prints them no matter if first or end number is bigger
        //i didnt know wheather you wanted it to loop the sentance multiple times or not
        //so i just did it once but to do it for every number you would just throw
        //the Console.WriteLine inside the for loop
        static void LoopThis(int startNum, int endNum)
        {
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum);
            if (startNum < endNum)
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    Console.WriteLine(i);

                }
            }
            else
            {
                for (int i = startNum; i >= endNum; i--)
                {
                    Console.WriteLine(i);
                }
            }



        }
        // loops any loop with any increment except loops containing infinity as a peremeter or 0 as an increment
        //didnt know wheather the 0 counted as the first loop so i did in this by adding 1 
        //if 0 doesnt count as the first loop id just take the set of parenthesis out along with the one
        static void SuperLoop(int startNum, int endNum, int increment)
        {
            int loopCount = increment;
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + " incrementing " + increment + " each time.");
            if(startNum<endNum)
            {
                
                for(int i=startNum; i<=endNum;i+=increment)
                {
                    Console.WriteLine(i);
            
                }
                Console.WriteLine("That loop was craaaaaaazy, we looped " + (((endNum - startNum)/increment)+1) + " times.");
            }
            else
            {
                for (int i = startNum; i >= endNum; i -= increment)
                {
                    Console.WriteLine(i);

                }
                Console.WriteLine("That loop was craaaaaaazy, we looped " + (((startNum-endNum)/increment)+1) + " times.");

            }
            
        }
        //greets a person with a name as peramiter
        static string NewGreeting(string name)
        {
            return "Hello " + name;
        }
        //triples a number
        static int TripleIt(int number)
        {
            return number * 3;
        }
        //multiplys two numbers
        static int RealMultiply(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}
