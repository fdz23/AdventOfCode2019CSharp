using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019.Day02
{
    class IntCode
    {
        private int[] _sequence;
        private int _iterator = 0;
        private int _result = 0;

        public IntCode(List<string> input, int noun, int verb)
        {
            _sequence = new int[input.Count];

            for (int i = 0; i < _sequence.Length; i++)
            {
                _sequence[i] = Convert.ToInt32(input[i]);
            }

            _sequence[1] = noun;
            _sequence[2] = verb;
        }

        public int Run()
        {
            while (_result == 0)
            {
                switch (_sequence[_iterator])
                {
                    case 1:
                        Operation1();
                        break;
                    case 2:
                        Operation2();
                        break;
                    case 99:
                        Operation99();
                        break;
                    default:
                        throw new Exception("Error!!!");
                }
            }

            return _result;
        }

        private void Operation1()
        {
            _sequence[_sequence[_iterator + 3]] = _sequence[_sequence[_iterator + 1]] + _sequence[_sequence[_iterator + 2]];
            _iterator += 4;
        }

        private void Operation2()
        {
            _sequence[_sequence[_iterator + 3]] = _sequence[_sequence[_iterator + 1]] * _sequence[_sequence[_iterator + 2]];
            _iterator += 4;
        }

        private void Operation99()
        {
            _result = _sequence[0];
        }
    }
}
