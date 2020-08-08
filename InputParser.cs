using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2019
{
    class InputParser
    {
        public static List<string> GetInputNewLine(string path)
        {
            var lines = File.ReadAllText(path).Split("\n");

            return lines.ToList();
        }

        public static List<string> GetInputComma(string path)
        {
            var lines = File.ReadAllText(path).Split(",");

            return lines.ToList();
        }
    }
}
