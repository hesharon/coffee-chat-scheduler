using System;
using System.Collections.Generic;

namespace coffee_chat
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>{"Taher","Sharon","Simon","Jesse","Anson","Kenton","Emil","Sachit","Fred","Sean"};

            PairPeople(people);
        }

        public static void PairPeople(List<string> People)
        {
            if (People.Count % 2 != 0)
            {
                People.Add("Dummy");
            }

            int numWeeks = People.Count - 1;
            int halfSize = People.Count / 2;

            List<string> pairs = new List<string>();

            pairs.AddRange(People); // Don't need to reverse array to keep ordering
            pairs.RemoveAt(0);

            int pairsSize = pairs.Count;

            for (int day = 0; day < numWeeks; day++)
            {
                Console.WriteLine("Week {0}", (day + 1));

                int teamIdx = day % pairsSize;

                Console.WriteLine("{0}, {1}", pairs[teamIdx], People[0]);

                for (int idx = 1; idx < halfSize; idx++)
                {               
                    int firstPerson = (day + idx) % pairsSize;
                    int secondPerson = (day  + pairsSize - idx) % pairsSize;
                    Console.WriteLine("{0}, {1}", pairs[firstPerson], pairs[secondPerson]);
                }
            }
        }
    }
}


