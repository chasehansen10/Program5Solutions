using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10;i<=30;i+=2)
            {
                Console.WriteLine(i);
            }
            for(int i=100; i>=75; i-=5)
            {
                Console.WriteLine(i);
            }
            numberFinder(2);
            
            Console.ReadKey();
        }
        static void numberFinder(int number)
        {
            
            List<int> numberList = new List<int>{5,2,5,5,4,8,7,9,3,3,25,8,2,4,5,2,58,5,2,5,5,2,2,2};
            for(int i=0;i<numberList.Count();i++)
            {
                if(number==numberList[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
        
    }
}
