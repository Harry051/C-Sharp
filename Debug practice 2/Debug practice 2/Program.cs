using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace Debug_practice_2
{
    internal class Program
    {
     //THIS PROGRAM WILL LET YOU INVITE GUESTS WITH THE SHORTEST NAME TO YOUR PARTY
        static void Main(string[] args)
        {
            var partyFriends = new List<string> { "Jason", "Rebecca", "Echo", "Dave", "Rajiv", "Tom", "Blake" };

            var result = GetAllPartyFriends(partyFriends, 3);
            Console.WriteLine("Your guests are:");
            
            foreach(string name in result)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }

        public static List<string> GetAllPartyFriends(List<string> list, int numOfFriends)
        {
            //Making these exceptions Protects our (theoretical) database from being messed up
            if (numOfFriends > list.Count || numOfFriends <= 0)
            {
                throw new ArgumentOutOfRangeException("numOfFriends, numOfFriends is either less than 1 or bigger than list size");
            }

            if (list == null)
            {
                throw new ArgumentNullException("List, List cannot be empty");
            }



            // Do this so OG list is not fucked with, this fresh copy can be tweaked without messing up data
            var bufferList = new List<string>(list);

            var partyFriends = new List<string>();

            while (partyFriends.Count < numOfFriends)
            {
                var currentFriend = GetPartyFriend(bufferList);
                partyFriends.Add(currentFriend);
                bufferList.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
