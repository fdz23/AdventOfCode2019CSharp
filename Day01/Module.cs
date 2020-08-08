using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019.Day01
{
    class Module
    {
        private ModuleFuel _moduleFuel;
        public int TotalFuelRequirement { get; set; }

        public Module(ModuleFuel moduleFuel)
        {
            _moduleFuel = moduleFuel;
        }

        public int CalculateTotalFuelRequirement()
        {
            int sum = 0;

            while (_moduleFuel.Fuel > 0)
            {
                sum += _moduleFuel.Fuel;

                _moduleFuel.CalculateFuelFromFuel();
            }

            return sum;
        }
    }
}
