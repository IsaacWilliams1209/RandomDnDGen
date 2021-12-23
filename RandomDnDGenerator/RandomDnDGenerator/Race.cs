using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Text;
using LumenWorks.Framework.IO.Csv;

namespace RandomDnDGenerator
{
    class Race : Character
    {
        public static int noOfRaces = 1;

        protected string race;

        protected string subRace;

        protected int walkSpeed;

        protected List<string> languages;

        protected string RaceBonuses;

        
        public Race()
        {
            
        }

        protected virtual void ApplyAbilityScores(int main, int secondary)
        {
            scores[main] += 2;
            scores[secondary] += 1;
        }
    }      
}
