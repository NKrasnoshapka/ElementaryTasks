using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Tasks_7_8
{
    class UIConsole
    {
        private const int SQUARE = 1;
        private const int FIBONACCI = 2;

        public static void BuildUI(string[] args)
        {
            switch (args.Length)
            {
                case SQUARE:
                {
                        int border = int.Parse(args[0]);

                        SquareSequence squareSequence
                            = SquareSequence.SquareInitialize(border);

                        Console.WriteLine("Square sequence");

                        foreach (int number in squareSequence.GetSequence())
                        {
                            Console.WriteLine(number);
                        }
                        break;
                }

                case FIBONACCI:
                {
                        int leftBorder = int.Parse(args[0]);
                        int rightBorder = int.Parse(args[1]);

                        FibonacciSequence fibonacciSequence 
                            = FibonacciSequence.FibonacciInitialize(leftBorder, rightBorder);

                        Console.WriteLine("Fibonacci sequence");

                        foreach (int number in fibonacciSequence.GetSequence())
                        {
                            Console.WriteLine(number);
                        }
                        break;
                }

                default:
                    {
                        Instruction();
                        break;
                    }

            }
        }

        private static void Instruction()
        {
            Console.WriteLine("Please 1 border for Square or 2 for Fibonacci");
        }



    }
}
