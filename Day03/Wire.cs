using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;

namespace AdventOfCode2019.Day03
{
    class Wire
    {
        public List<Point> Path { get; set; }
        private Point _current;

        public Wire()
        {
            Path = new List<Point>();
            _current = Point.Empty;
            Path.Add(_current);
        }

        public void Move(string command)
        {
            var direction = command[0];
            var steps =
                Convert.ToInt32(
                command.Substring(1));

            switch (direction)
            {
                case 'U':
                    GoUp(steps);
                    break;
                case 'D':
                    GoDown(steps);
                    break;
                case 'L':
                    GoLeft(steps);
                    break;
                case 'R':
                    GoRight(steps);
                    break;
            }
        }

        private void GoRight(int steps)
        {
            AddDistance(true, true, steps);
        }

        private void GoLeft(int steps)
        {
            AddDistance(true, false, steps);
        }

        private void GoDown(int steps)
        {
            AddDistance(false, false, steps);
        }

        private void GoUp(int steps)
        {
            AddDistance(false, true, steps);
        }

        private void AddDistance(bool isX, bool isPositive, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (isX)
                {
                    if (isPositive)
                    {
                        _current.X += 1;
                    }
                    else
                    {
                        _current.X -= 1;
                    }
                }
                else
                {
                    if (isPositive)
                    {
                        _current.Y += 1;
                    }
                    else
                    {
                        _current.Y -= 1;
                    }
                }

                Path.Add(_current);
            }
        }
    }
}
