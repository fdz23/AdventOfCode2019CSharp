using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019.Day02
{
    class SolutionDayTwo : Solution
    {
        private int _expectedSolutionPart2 = 19690720;
        private int _noun = 0;
        private int _verb = 0;
        public SolutionDayTwo(string path)
        {
            Input = InputParser.GetInputComma(path);
        }

        public override void ShowSolutionPartOne()
        {
            Console.WriteLine("Day 02 Part 01 :");
            Console.WriteLine(new IntCode(Input, 12, 2).Run());
        }

        public override void ShowSolutionPartTwo()
        {
            Console.WriteLine("Day 02 Part 02 :");
            Console.WriteLine(FindExpectedSolution());
        }

        private int FindExpectedSolution()
        {
            for (_noun = 0; _noun < 100; _noun++)
            {
                for (_verb = 0; _verb < 100; _verb++)
                {
                    if (new IntCode(Input, _noun, _verb).Run() == _expectedSolutionPart2)
                    {
                        return 100 * _noun + _verb;
                    }
                }
            }

            throw new Exception("Couldn't find the expected solution within the noun and verb range");
        }
    }
}
