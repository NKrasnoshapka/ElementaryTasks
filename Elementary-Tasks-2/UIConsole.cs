﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Tasks_2
{
    class UIConsole
    {
        public static void BuildUI()
        {
            const int RIGHT_ARGS = 1;
            string[] args = Environment.GetCommandLineArgs();
            bool Finish = true;

            switch (args.Length)
            {
                case RIGHT_ARGS:
                    {
                        do
                        {
                            Finish = false;

                            float heightFirstEnvelope;
                            float widthFirstEnvelope;
                            float heightSecondEnvelope;
                            float widthSecondEnvelope;

                            Console.WriteLine("Input height of first envelope:");
                            bool success1 = float.TryParse(Console.ReadLine(), out heightFirstEnvelope);
                            Console.WriteLine("Input width of first envelope:");    
                            bool success2 = float.TryParse(Console.ReadLine(), out widthFirstEnvelope);

                            Console.WriteLine("Input height of second envelope:");
                            bool success3 = float.TryParse(Console.ReadLine(), out heightSecondEnvelope);
                            Console.WriteLine("Input width of second envelope:");
                            bool success4 = float.TryParse(Console.ReadLine(), out widthSecondEnvelope);

                            if ((success1 == true) && (success2 == true) && (success3 == true) && (success4 == true))
                            {
                                Envelope firstEnvelope = Envelope.EnvelopeInitialize(heightFirstEnvelope, widthFirstEnvelope);
                                Envelope secondEnvelope = Envelope.EnvelopeInitialize(heightSecondEnvelope, widthSecondEnvelope);
                                ComparisonResults(firstEnvelope, secondEnvelope);
                            }
                            else
                                throw new FormatException("Please enter sides by numbers");

                             Finish = Repeat();
                        }
                        while (Finish);

                        break;
                    }
                default:
                    {
                        Instruction();
                        break;
                    }
            }

        }

        private static void ComparisonResults(Envelope firstEnvelope, Envelope secondEnvelope)
        {
            if (firstEnvelope.CompareTo(secondEnvelope) == 1)
            {
                Console.WriteLine("Second envelope can be in first!");
            }
            else if (secondEnvelope.CompareTo(firstEnvelope) == 1)
            {
                Console.WriteLine("First envelope can be in second!");
            }
            else
            {
                Console.WriteLine("Envelopes cannot be nested");
            }
        }


        private static void Instruction()
        {
            Console.WriteLine("...");
        }

        private static bool Repeat()
        {
            Console.WriteLine("To repeat type y/Y or yes/YES:");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" | answer == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
