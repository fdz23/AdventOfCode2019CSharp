using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2019.Day01
{
    class SolutionDayOne : Solution
    {
        public SolutionDayOne(string path)
        {
            Input = InputParser.GetInputNewLine(path);
        }

        public override void ShowSolutionPartOne()
        {
            Console.WriteLine("Day 01 Solution 01 :");
            Console.WriteLine(CalculateSumOfFuel());
        }

        public override void ShowSolutionPartTwo()
        {
            Console.WriteLine("Day 01 Solution 02 :");
            Console.WriteLine(CalculateSumOfFuelOfFuel());
        }

        public int CalculateSumOfFuel()
        {
            var fuels = new List<ModuleFuel>();

            Input
                .ForEach(
                x => fuels.Add(
                    new ModuleFuel(
                        Convert.ToInt32(x))));

            return fuels
                .Sum(x => x.Fuel);
        }

        public int CalculateSumOfFuelOfFuel()
        {
            var modules = new List<Module>();

            Input
                .ForEach(x => 
                modules.Add(
                    new Module(
                        new ModuleFuel(
                            Convert.ToInt32(x)))));

            return modules
                .Sum(x => x.CalculateTotalFuelRequirement());
        }
    }
}
