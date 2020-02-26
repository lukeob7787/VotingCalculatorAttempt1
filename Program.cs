using System;

namespace Voting
{
    class VotingSystem
    {
        static void Main(string[] args)
        {
            int totalCountries = 27;
            int _yes = 23;
            int _no = 3;
            int abstain = 1;
            int population = 65;
            int memberStates = 55;

            int yes_pc = (int)(0.5f + (100f * _yes) / totalCountries);

            int no_pc = (int)(0.5f + (100f * _no) / totalCountries);

            int abstain_pc = (int)(0.5 + (100f * abstain) / totalCountries);


            if(yes_pc >= population)
            {
                Console.WriteLine($"Final Result Approved as above minmum required, the result was {yes_pc}% of the votes to yes and {no_pc}% for no");
            }
            else
            {
                Console.WriteLine($"Final Results Rejected as below minimum required, the result was {no_pc}% of the votes to yes and {yes_pc}% for no");
            }


        }
    }
}
