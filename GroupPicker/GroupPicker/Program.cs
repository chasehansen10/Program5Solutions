using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            PickGroups(4, 20);
            Console.ReadKey();
        }
        static void PickGroups(int numberOfGroups,int classSize)
        {
            Random rng = new Random();
            List<string> numberOfPeopleInGroup = new List<string>();
            List<string> listOfGroups = new List<string>();
            int groupCounter = 0;
            for(int i=0;i<classSize;i++)
            {
                numberOfPeopleInGroup.Add(""+i);
              
               
            }
            numberOfPeopleInGroup[0] = "Chase";
            numberOfPeopleInGroup[1] = "Josh";
            numberOfPeopleInGroup[2] = "Nick";
            numberOfPeopleInGroup[3] = "Justin";
            numberOfPeopleInGroup[4] = "Jackson";
            numberOfPeopleInGroup[5] = "Chris";
            numberOfPeopleInGroup[6] = "Edgar";
            numberOfPeopleInGroup[7] = "Bayrum";
            numberOfPeopleInGroup[8] = "Dave";
            numberOfPeopleInGroup[9] = "Aiko";
            numberOfPeopleInGroup[10] = "Brandon";
            numberOfPeopleInGroup[11] = "Kaipo";
            numberOfPeopleInGroup[12] = "Lauren";
            numberOfPeopleInGroup[13] = "Zach";
            numberOfPeopleInGroup[14] = "Dustin";
            numberOfPeopleInGroup[15] = "Andrea";
            numberOfPeopleInGroup[16] = "Jackie";
            numberOfPeopleInGroup[17] = "Reid";
            numberOfPeopleInGroup[18] = "Eric";
            numberOfPeopleInGroup[19] = "Jake";
            
            for(int i=0;i<numberOfGroups;i++)
            {
                listOfGroups.Add("Group " + (i + 1) + " :");
            }
            while(numberOfPeopleInGroup.Count()>0)
            {
                int randomPerson = rng.Next(0, numberOfPeopleInGroup.Count());
                listOfGroups[groupCounter] += numberOfPeopleInGroup[randomPerson] + ", ";
                numberOfPeopleInGroup.RemoveAt(randomPerson);
                groupCounter = (groupCounter + 1) % numberOfGroups;

            }
            foreach(string nextGroup in listOfGroups)
            {
                Console.WriteLine(nextGroup.Substring(0, nextGroup.Length-2));
            }

        }
    }
}
