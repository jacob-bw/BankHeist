using System;
using System.Collections.Generic;
using System.Linq;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TeamMember> iceSquad = new List<TeamMember>();

            Console.WriteLine("Plan Your Heist! Please enter a bank difficulty level.");

            var bankValue = Convert.ToInt32(Console.ReadLine());

            string addAnother;
            do
            {
                Console.WriteLine("Please enter a name for your team member.");
                var teamMemberName = Console.ReadLine();

                Console.WriteLine("Please enter your team members skill level: (Any number greater than zero)");
                var teamMemberSkillLevel = Convert.ToInt32(Console.ReadLine());

                while (teamMemberSkillLevel <= 0)
                {
                    Console.WriteLine("Sorry, you entered a number equal or less than zero, try again.");
                    teamMemberSkillLevel = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine(
                    "Please enter your team members courage factor: (a decimal value between 0.0 and 2.0)");
                var teamMemberCourageFactor = Convert.ToDecimal(Console.ReadLine());

                while (teamMemberCourageFactor < 0.0m || teamMemberCourageFactor > 2.0m)
                {
                    Console.WriteLine("Sorry, you entered a decimal value outside of the acceptable range, try again.");
                    teamMemberCourageFactor = Convert.ToDecimal(Console.ReadLine());
                }

                iceSquad.Add(new TeamMember(teamMemberName, teamMemberSkillLevel, teamMemberCourageFactor));
                Console.WriteLine("Would you like to add another team member? (y/n)");
                addAnother = Console.ReadLine();
            } while (addAnother == "y");

            Console.Clear();
            Console.WriteLine($"You have {iceSquad.Count} team members.");

            foreach (var member in iceSquad)
            {
                Console.WriteLine($"Your team member, {member.Name}, has a skill level of {member.SkillLevel} and a courage factor of {member.CourageFactor}");
                Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("How many times would you like to run this scenario?");
            var scenarioLimit = Convert.ToInt32(Console.ReadLine());

            var successfulHeists = 0;

            for (var i = 0; i < scenarioLimit; i++)
            {
                Random rnd = new Random();
                var bankLuck = rnd.Next(-10, 10);
                var finalBankValue = bankLuck + bankValue;

                var total = iceSquad.Sum(member => member.SkillLevel);

                Console.WriteLine($"Your team's combined skill level is {total}. The bank's difficulty level is {finalBankValue}.");

                if (total >= finalBankValue)
                {
                    Console.WriteLine("You've successfully infiltrated the bank.");
                    successfulHeists += 1;
                }
                else
                {
                    Console.WriteLine("Your team's skill level was not high enough this time. Try again.");
                }
            }

            Console.WriteLine($"You successfully completed {successfulHeists} heists and failed {scenarioLimit - successfulHeists}.");
            Console.ReadLine();
        }
    }
}