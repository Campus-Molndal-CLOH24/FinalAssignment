﻿using FinalAssignment.UppgifterTDD.Uppgift2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.UppgifterTDD.Uppgift2
{
    public class StringProcessor
    {
        

        public string Reverse(string input)

            //kontrollera nullvärde
        {
           if (input == null)
                return string.Empty;
            
              
            //vänder strängen returnerar resultat 
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
   
        public string ToLowerWord(string input)
    {
            return input == null ? string.Empty : input.ToLower();//
        }

        //ToUpper
        public string ToUpperWord(string input)
        {
            return input == null ? string.Empty : input.ToUpper(); //returnerar strängen i stora bokstäver
        
    
}        public string ToLowerCase(string input)
    {
        return input == null ? string.Empty : input.ToLower(); //returnerar strängen i små bokstäver
        }

        // RemoveSwedishCharacters
        public string OnlyEnglsihLetters(string input)
        {
            return input.Replace("å", "a").Replace("ä", "a").Replace("ö", "o").Replace("Å", "A").Replace("Ä", "A").Replace("Ö", "O");
        }

    }
}































