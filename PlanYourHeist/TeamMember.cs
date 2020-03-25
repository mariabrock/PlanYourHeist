using System;
using System.Collections.Generic;
using System.Text;

namespace PlanYourHeist
{
    class TeamMember
    {
        private int _skillLevel;
        private decimal _courageFactor;
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        public TeamMember(string name, int skillLevel, decimal courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }
    }
}
