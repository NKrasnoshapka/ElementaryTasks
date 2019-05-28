using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Tasks_7_8
{
    class Validator
    {
        public static bool ValidFibonacci(int leftBorder, int rightBorder)
        {
            if (leftBorder>0 && rightBorder>0)
            {
                if (leftBorder< rightBorder)
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException("Left number must be smaller than right");
                }
            }
            else
            {
                throw new ArgumentException("Nambers must be natural");
            }
        }

        public static bool ValidSquare(int rightBorder)
        {
            if (rightBorder > 1)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Namber must be natural and more than one");
            }
        }
    }
}
