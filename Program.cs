using System;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var day01 = new Day01.SolutionDayOne(@"E:\Prog\AdventOfCode2019\AdventOfCode2019\Day01\Input.txt");
            var day02 = new Day02.SolutionDayTwo(@"E:\Prog\AdventOfCode2019\AdventOfCode2019\Day02\Input.txt");

            day01.ShowSolutionPartOne();
            day01.ShowSolutionPartTwo();

            day02.ShowSolutionPartOne();
            day02.ShowSolutionPartTwo();
        }
    }
}
