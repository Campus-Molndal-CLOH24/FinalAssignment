﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.UppgifterTDD.Uppgift1
{
    public class Calculator
    //ADD 
    {
        public double AddFromInput(string inputA, string inputB)
        {
            double a = double.Parse(inputA);//har valt att använda double för att kunna hantera decimaltal
            double b = double.Parse(inputB);

            return a + b;//returnerar summan av a och b
        }
        // har valt tryparse för att kunna hantera felaktiga inmatningar som inte är siffror
        public double AddFromInputWithValidation(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a + b;  // Summera om båda inmatningarna är giltiga tal
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");  // Kasta undantag vid felaktig inmatning tex abc 
            }
        }
        // DIVIDE
       
        public double DivideFromInput(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                if (b == 0)
                {
                    throw new ArgumentException("Kan inte dela med noll.");  // Kasta undantag om b == 0
                }
                return a / b;  // Utför division om båda inmatningarna är giltiga tal
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");  // Kasta undantag för t.ex. "abc"
            }
        }
        // MULTIPLY
        public double MultiplyFromInput(string inputA, string inputB)
        {
            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                return a * b;  // Utför multiplikation om båda inmatningarna är giltiga tal
            }
            else
            {
                throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");  // Kasta undantag för t.ex. "abc"
            }
    }
}

}
















