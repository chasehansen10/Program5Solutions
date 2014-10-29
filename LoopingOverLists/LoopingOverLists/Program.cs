using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingOverLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopOverAList();
            LoopOverWordsInAString("Lets have some fun");
            Console.ReadKey();
        }

        static void LoopOverAList()
        {
            //create a list of sports
            List<string> sportsList = new List<string>() { "football", "baseball", "soccer", "tennis", "hockey" };
            // add sport
            sportsList.Add("waterpolo");
            //loop over the sports list and display all elements that contain ball
            for(int i=0; i<sportsList.Count(); i++)
            {
               //get current sport out of sportsList
                string currentSport = sportsList[i];
               //check to see if its a sport with the word ball in it
                if(currentSport.Contains("ball"))
                {
                    //its true
                    Console.WriteLine(currentSport);
                }
            }
           
        }
        static void LoopOverWordsInAString(string inputString)
        {
            List<string> wordList = inputString.Split(' ').ToList();
            for (int i = 0; i < wordList.Count(); i++)
            {
                Console.WriteLine(wordList[i]);
            }
        }


    }
}
