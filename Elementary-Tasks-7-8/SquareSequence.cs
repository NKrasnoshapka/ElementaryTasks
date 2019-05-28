using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Tasks_7_8
{
    class SquareSequence:Sequence
    {
        private SquareSequence(int leftBorder, int rightBorder) : base(leftBorder, rightBorder){}

        public static SquareSequence SquareInitialize( int rightBorder)
        {
            if (Validator.ValidSquare(rightBorder))
            {
                return new SquareSequence(1, rightBorder);
            }
            else
            {
                throw new ArgumentException("Try again");
            }
        }

        public override IEnumerable<int> GetSequence()
        {
            int natural_namber = 1;
            while (Math.Pow(natural_namber, 2) < RightBorder)
            {
                yield return natural_namber;
                natural_namber++;
            }
        }
    }
}
