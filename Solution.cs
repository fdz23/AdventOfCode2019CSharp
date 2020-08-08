using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    abstract class Solution
    {
        public List<string> Input { get; set; }

        public abstract void ShowSolutionPartOne();

        public abstract void ShowSolutionPartTwo();
    }
}
