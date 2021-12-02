using System;
using System.Collections.Generic;
using System.Text;

namespace RandomDnDGenerator
{
    class Character
    {
        public int strength;

        public int dexterity;

        public int constitution;

        public int wisdom;

        public int intellegence;

        public int charisma;

        Race race;

        int[] scores = new int[6];

        public Character()
        {
            StatRolls();
        }

        void StatRolls()
        {
            for (int i = 0; i < scores.Length; i++)
            {
                List<int> rolls = new List<int>();
                Random random = new Random();
                rolls.Add(random.Next(1, 7));
                for (int j = 1; j < 4; j++)
                {
                    int roll = random.Next(1, 7);
                    for (int k = 0; k < rolls.Count; k++)
                    {
                        if (roll >= rolls[k])
                        {
                            rolls.Insert(k, roll);
                            break;
                        }
                        else if (k == rolls.Count - 1)
                        {
                            rolls.Add(roll);
                        }
                    }

                }
                rolls.RemoveAt(3);
                for (int j = 0; j < 3; j++)
                {
                    scores[i] += rolls[j];
                }
            }
        }

        void RacePicker()
        {

        }
    }    
}
