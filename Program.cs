using System;
using System.Collections.Generic;
using System.Linq;


namespace recount
{
    class Program
    {
        static void Main(string[] args)
        {

            // list of candidates
            List<string> candidates = new List<string>();

            // dictionary of votes
            Dictionary<string, int> votes = new Dictionary<string, int>();

            string input = "";

            // tell when to go and stop
            while (input != "***")
            {
                input = Console.ReadLine();
                candidates.Add(input);
            }
            // do not add this to the database
            candidates.Remove("***");
            // start at 0 votes and populate from there
            foreach (string candidate in candidates)
            {
                if (votes.ContainsKey(candidate))
                    votes[candidate] = votes[candidate] + 1;

                else
                    votes.Add(candidate, 1);

            }

            /* show what is in dictionary
            foreach (KeyValuePair<string, int> vote in votes)
            {
                Console.WriteLine(vote.Key +" "+ vote.Value);
            }
            */

            //find highest # of votes
            int voteMax = votes.Values.Max();

            //declare variables
            int countWinners = 0;
            string winner = "";

            // hold # in variables
            foreach (KeyValuePair<string, int> vote in votes)
            {

                if (vote.Value == voteMax)
                {
                    countWinners += 1;
                    winner = vote.Key;
                }

                else
                    continue;

            }


            //if countWinners more than 1 then tie
            if (countWinners == 1)
            {

                Console.WriteLine(winner);
            }
            // utilize the term runoff
            else if (countWinners > 1)
                Console.WriteLine("Runoff!");

        }
    }
}
