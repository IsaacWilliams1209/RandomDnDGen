using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RandomDnDGenerator
{
    class Dragonborn : Race
    {
        public Dragonborn()
        {
            subRace = "None";
            ApplyAbilityScores(0, 5);

            walkSpeed = 30;

            languages.Add("Draconic");
            languages.Add("Common");

            string[] ancestoryOptions = new string[10] { "Black", "Blue", "Brass", "Bronze", "Copper", "Gold", "Green", "Red", "Silver", "White" };

            RaceBonuses = "Draconic Ancestory: " + ancestoryOptions[random.Next(1, 11)] + "\n";

            StreamReader reader = new StreamReader("DragonBorn.txt");

            while (!reader.EndOfStream)
            {
                RaceBonuses += reader.ReadLine() + "\n";
            }
        }
    }
}
