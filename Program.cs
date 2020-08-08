using System;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var day01 = new Day01.SolutionDayOne(GetPathDay("01"));
            var day02 = new Day02.SolutionDayTwo(GetPathDay("02"));
            var day03 = new Day03.SolutionDayThree(GetPathDay("03"));

            day01.ShowSolutionPartOne();
            day01.ShowSolutionPartTwo();

            day02.ShowSolutionPartOne();
            day02.ShowSolutionPartTwo();

            day03.ShowSolutionPartOne();
            //day03.ShowSolutionPartTwo();
        }

        private static string GetPathDay(string day)
        {
            return @"E:\Prog\AdventOfCode2019\AdventOfCode2019\Day" + day + @"\Input.txt";
        }
    }
}
