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
        //function with 2 parameters numOfGroups and classSize
        static void PickGroups(int numberOfGroups,int classSize)
        {
            //creat a random number generator
            Random rng = new Random();
            //make 2 lists that keeps track of how many people are in the group and a list of groups
            List<string> numberOfPeopleInGroup = new List<string>();
            List<string> listOfGroups = new List<string>();
            //create a group counter
            int groupCounter = 0;
            //loop the classSize and add that many people to the numberOfPeopleInGroup list
            for(int i=0;i<classSize;i++)
            {
                numberOfPeopleInGroup.Add(""+i);
              
               
            }
            //my classmates
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
            //loops the numberOfGroups specified and add that many groups to the listOfGroups
            
            for(int i=0;i<numberOfGroups;i++)
            {
                listOfGroups.Add("Group " + (i + 1) + " :");
            }

            while(numberOfPeopleInGroup.Count()>0)
            {
                //generates a random number with a external bound of the amount of indexes in the numberPeopleInGroup list
                int randomPerson = rng.Next(0, numberOfPeopleInGroup.Count());
                //increment listOfGroup by the random person you generated so it will print the person in the group
                listOfGroups[groupCounter] += numberOfPeopleInGroup[randomPerson] + ", ";
                //remove that random person from numberOfPeopleInGroup
                numberOfPeopleInGroup.RemoveAt(randomPerson);
                //increment groupCounter by 1 and modulo it so that it will keep your groups even
                groupCounter = (groupCounter + 1) % numberOfGroups;

            }
            // loop listOfGroups to print out your groups
            foreach(string nextGroup in listOfGroups)
            {
                Console.WriteLine(nextGroup.Substring(0, nextGroup.Length-2));
            }

        }
    }
}
