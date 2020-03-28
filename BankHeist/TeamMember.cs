using System;
using System.Collections.Generic;
using System.Text;

namespace BankHeist
{
    class TeamMember
    {
        private int _skillLevel;
        private decimal _courageFactor;
        public string Name { get; set; }
        public int SkillLevel {
            get => _skillLevel;
            set
            {
                if (value > 0)
                {
                    _skillLevel = value;
                }  
            }
        }
        public decimal CourageFactor {
            get => _courageFactor;
            set
            {
                if (value >= 0.0m && value <= 2.0m)
                {
                    _courageFactor = value;
                }
                else
                {
                    _courageFactor = 3.0m;
                }
            }
        }

        public TeamMember(string name, int skillLevel, decimal courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }
    }
}