using System;

namespace Voting
{
    class VotingSystem
    {
        static void Main(string[] args)
        {
            int totalCountries = 27;
            int population = 65;
            int memberStates = 55;

            Console.WriteLine("Results should add up to 27 as that is the amount of countries participating");
            Console.WriteLine("Enter amount of votes for yes");
            int _yes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter amount of votes for no");
            int _no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter amount of votes for yes");
            int abstain = Convert.ToInt32(Console.ReadLine());


            int yes_pc = (int)(0.5f + (100f * _yes) / totalCountries);

            int no_pc = (int)(0.5f + (100f * _no) / totalCountries);

            int abstain_pc = (int)(0.5 + (100f * abstain) / totalCountries);


            if(yes_pc >= population)
            {
                Console.WriteLine($"Final Result Approved as above minmum required, the result was {yes_pc}% of the votes to yes and {no_pc}% for no and {abstain_pc}% for votes on neither");
            }
            else
            {
                Console.WriteLine($"Final Results Rejected as below minimum required, the result was {no_pc}% of the votes to yes and {yes_pc}% for no and {abstain_pc}% for votes on neither");
            }


        }
    }
}
