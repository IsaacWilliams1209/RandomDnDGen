using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Text;
using LumenWorks.Framework.IO.Csv;

namespace RandomDnDGenerator
{
    class Race
    {
        public string race;

        public int primeStatBoost;

        public string subRace;

        public int secondaryStatBoost;

        public int walkSpeed;
        public Race()
        {
            DataTable csvTable = new DataTable();
            CsvReader csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead("races.csv")), true);
            csvTable.Load(csvReader);


        }
    }
    
}
