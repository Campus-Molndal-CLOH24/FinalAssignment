using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.UppgifterTDD.Uppgift1
{
    public class Calculator
    {
        #region ADDITION METHODS

        
        public double AddFromInput(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a + b;  // Summera om båda inmatningarna är giltiga tal
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        
        public double AddFromInputWithValidation(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a + b;  // Summera om båda inmatningarna är giltiga tal
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        
        public double AddNegativePositive(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a + b;  // Summerar även om inputA är negativt och inputB är positivt
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        #endregion

        #region DIVISION METHODS

       
        public double DivideFromInput(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                if (b == 0)
                {
                    throw new ArgumentException("Kan inte dela med noll.");
                }
                return a / b;  // Utför division om båda inmatningarna är giltiga tal
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        #endregion

        #region MULTIPLICATION METHODS

        
        public double MultiplyFromInput(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a * b;  // Utför multiplikation om båda inmatningarna är giltiga tal
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        public double MultiplyNegativePositive(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a * b;  // Utför multiplikation även om inputA är negativt och inputB är positivt
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        #endregion

        #region SUBTRACTION METHODS


        public double SubstractFromInput(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a - b;  // Utför subtraktion om båda inmatningarna är giltiga tal
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        #endregion
    }
}


































