using System;

namespace FinalAssignment.UppgifterTDD.Uppgift1
{
    public class Calculator
    {
        #region ADDITION METHODS

        /// <summary>
        /// Summerar två inmatade värden som strängar efter konvertering till tal.
        /// </summary>
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

        /// <summary>
        /// Validerad addition av två inmatade värden.
        /// </summary>
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

        /// <summary>
        /// Summerar även negativa och positiva tal.
        /// </summary>
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

        /// <summary>
        /// Dividerar två inmatade värden som strängar.
        /// </summary>
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

        /// <summary>
        /// Multiplicerar två inmatade värden som strängar.
        /// </summary>
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

        /// <summary>
        /// Multiplicerar även negativa och positiva tal.
        /// </summary>
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

        /// <summary>
        /// Subtraherar två inmatade värden som strängar.
        /// </summary>
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

        /// <summary>
        /// Subtraherar även negativa och positiva tal.
        /// </summary>
        public double SubstractNegativePositive(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a - b;  // Utför subtraktion även om inputA är negativt och inputB är positivt
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");
            }
        }

        #endregion
    }
}
































