using System;
using System.Collections.Generic;
using System.Text;

namespace RandomDnDGenerator
{
    class Dwarf : Race
    {
        const int noOfSubRaces = 2;
        public Dwarf()
        {
            int subRaceIndex = random.Next(0, noOfSubRaces);

            string[] subRaceOptions = new string[noOfSubRaces] { "Hill", "Mountain" };

            subRace = subRaceOptions[subRaceIndex];

            switch (subRaceIndex)
            {
                case 0:
                    ApplyAbilityScores(2, 1);
                    break;
                case 1:
                    ApplyAbilityScores(2, 0);
                    break;
            }

            walkSpeed = 25; 

            languages.Add("Common");
            languages.Add("Dwarven");
        }
    }
}
