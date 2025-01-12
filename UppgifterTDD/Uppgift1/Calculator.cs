using System;

namespace FinalAssignment.UppgifterTDD.Uppgift1
{
    public class Calculator
    {
        // ADD
        public double AddFromInput(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a + b;
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        // DIVIDE
        public double DivideFromInput(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                if (b == 0)
                {
                    throw new ArgumentException("Kan inte dela med noll.");
                }
                return a / b;
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        // MULTIPLY
        public double MultiplyFromInput(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a * b;
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        // SUBTRACT
        public double SubstractFromInput(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a - b;
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }
    }
}

