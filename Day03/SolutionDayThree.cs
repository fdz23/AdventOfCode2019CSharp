using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AdventOfCode2019.Day03
{
    class SolutionDayThree : Solution
    {
        private List<string> _inputWire1;
        private List<string> _inputWire2;
        public SolutionDayThree(string path)
        {
            Input = InputParser.GetInputNewLine(path);
            _inputWire1 = Input[0].Split(",").ToList();
            _inputWire2 = Input[1].Split(",").ToList();
        }
        public override void ShowSolutionPartOne()
        {
            Console.WriteLine("Solution Day 03 Part 01 :");
            Console.WriteLine(GetSolutionPart1());
        }

        public override void ShowSolutionPartTwo()
        {
            throw new NotImplementedException();
        }

        private int GetSolutionPart1()
        {
            var wire1 = new Wire();
            var wire2 = new Wire();

            MoveWires(wire1, wire2);

            var intersection = wire1.Path
                .Intersect(wire2.Path)
                .Where(p => p != Point.Empty);

            return intersection.Min(p => Math.Abs(p.X) + Math.Abs(p.Y));
        }

        private void MoveWires(Wire wire1, Wire wire2)
        {
            _inputWire1
                .ForEach(x => wire1.Move(x));
            _inputWire2
                .ForEach(x => wire2.Move(x));
        }
    }
}