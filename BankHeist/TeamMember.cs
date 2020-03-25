using System;
using System.Collections.Generic;
using System.Text;

namespace BankHeist
{
    class TeamMember
    {
        public string Name { get; set; }
        private int _skillLevel;
        private double _courageFactor;

        public int SkillLevel
        {
            get => _skillLevel;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _skillLevel = value;
                }
                else
                {
                    _skillLevel = 50;
                    Console.WriteLine("Can't blame you for trying. You're not that slick, though.");
                }
            }
        }

        public double CourageFactor
        {
            get => _courageFactor;
            set
            {
                if (value >= 0.0 &&  value <= 2.0)
                {
                    _courageFactor = value;
                }
                else
                {
                    _courageFactor = 1.0;
                    Console.WriteLine("Why are the brave ones also so dumb?");
                }
            }
        }

        public TeamMember(string name)
        {
            Name = name;
        }
    }
}
