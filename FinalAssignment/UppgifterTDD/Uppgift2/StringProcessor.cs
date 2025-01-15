
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
        {
            if (input == null)
                return string.Empty;  // Returnerar tom sträng om input är null

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string ToLowerWord(string input)
        {
            return input == null ? string.Empty : input.ToLower();  // Returnerar hela ordet i små bokstäver
        }

        public string ToUpperWord(string input)
        {
            return input == null ? string.Empty : input.ToUpper();  // Returnerar hela ordet i stora bokstäver
        }

        public string ToLowerCase(string input)
        {
            return input == null ? string.Empty : input.ToLower();  // Returnerar hela strängen i små bokstäver
        }

        // RemoveSwedishCharacters
        public string OnlyEnglsihLetters(string input)
        {
            if (input == null)
                return string.Empty;  // Returnerar tom sträng om input är null
            return input.Replace("å", "a").Replace("ä", "a").Replace("ö", "o")
                        .Replace("Å", "A").Replace("Ä", "A").Replace("Ö", "O");
        }

        public void ToUpperCase(object value)
        {
            throw new NotImplementedException();
        }

        // Null-metoder för `null`-tester
        public string ToLowerWordNull(string input)
        {
            if (input == null)
                return string.Empty;  // Returnerar tom sträng istället för att kasta undantag
            return input.ToLower();
        }

        public string ToUpperWordNull(string input)
        {
            if (input == null)
                return string.Empty;  // Returnerar tom sträng istället för att kasta undantag
            return input.ToUpper();
        }

        public string ToLowerCaseNull(string input)
        {
            if (input == null || input.Length == 0)
                return string.Empty;  // Returnerar tom sträng om input är null eller tom
            return char.ToLower(input[0]) + (input.Length > 1 ? input.Substring(1) : string.Empty);
        }

        public string ToUpperCaseNull(string input)
        {
            if (input == null || input.Length == 0)
                return string.Empty;  // Returnerar tom sträng om input är null eller tom
            return char.ToUpper(input[0]) + (input.Length > 1 ? input.Substring(1) : string.Empty);
        }
    }
}

















