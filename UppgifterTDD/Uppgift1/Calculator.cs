using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.UppgifterTDD.Uppgift1
{
    public class Calculator
    {
        public double AddFromInput(string inputA, string inputB)
        {
            double a = double.Parse(inputA);//har valt att använda double för att kunna hantera decimaltal
            double b = double.Parse(inputB);

            return a + b;//returnerar summan av a och b
        }
        // har valt truyparse för att kunna hantera felaktiga inmatningar som inte är siffror
        public double AddFromInputWithValidation(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a + b;  // Summera om båda inmatningarna är giltiga tal
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");  // Kasta undantag vid felaktig inmatning
            }
        }
    }
}

