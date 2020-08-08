using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019.Day01
{
    class ModuleFuel
    {
        public int Mass { get; set; }
        public int Fuel { get; set; }

        public ModuleFuel(int mass)
        {
            Mass = mass;
            CalculateFuel();
        }

        public void CalculateFuel()
        {
            Fuel = Mass / 3 - 2;
        }

        public void CalculateFuelFromFuel()
        {
            Fuel = Fuel / 3 - 2;
        }
    }
}
