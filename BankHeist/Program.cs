using System;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");
            Console.ReadLine();

            Console.WriteLine("Who are you recruiting to join your heist?");
            var teamMember = new TeamMember(Console.ReadLine());


            Console.WriteLine("How skilled is this person at committing heists? (please enter a number larger than zero)");
            teamMember.SkillLevel = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How Brave is this person? (please enter a decimal between 0.0 and 2.0)");
            teamMember.CourageFactor = Convert.ToDouble(Console.ReadLine());

            Console.Write($"{teamMember.Name} is part of your crew now! They have a skill rating of {teamMember.SkillLevel} and have a courage score of {teamMember.CourageFactor}");
            Console.ReadLine();
        }
    }
}
