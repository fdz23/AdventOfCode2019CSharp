using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019.Day02
{
    class SolutionDayTwo : Solution
    {
        public SolutionDayTwo(string path)
        {
            Input = InputParser.GetInputComma(path);
        }

        public override void ShowSolutionPartOne()
        {
            Console.WriteLine("Day 02 Part 01 :");
            Console.WriteLine(new IntCode(Input).Run());
        }

        public override void ShowSolutionPartTwo()
        {
            //
        }
    }
}
