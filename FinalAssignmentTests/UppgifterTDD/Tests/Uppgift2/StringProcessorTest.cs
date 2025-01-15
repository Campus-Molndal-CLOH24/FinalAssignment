using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.UppgifterTDD.Uppgift2
{
    public class StringProcessor
    {
        #region STRING PROCESSING METHODS

        // Reverse a string
        public string Reverse(string input)
        {
            if (input == null)
                return string.Empty;  // Returnerar tom sträng om input är null

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Convert string to lowercase
        public string ToLowerWord(string input)
        {
            return input == null ? string.Empty : input.ToLower();  // Returnerar hela ordet i små bokstäver
        }

        // Convert string to uppercase
        public string ToUpperWord(string input)
        {
            return input == null ? string.Empty : input.ToUpper();  // Returnerar hela ordet i stora bokstäver
        }

        // Convert first letter to lowercase
        public string ToLowerCase(string input)
        {
            return input == null ? string.Empty : input.ToLower();  // Returnerar hela strängen i små bokstäver
        }

        // Remove Swedish characters from string
        public string OnlyEnglsihLetters(string input)
        {
            if (input == null)
                return string.Empty;  // Returnerar tom sträng om input är null
            return input.Replace("å", "a").Replace("ä", "a").Replace("ö", "o")
                        .Replace("Å", "A").Replace("Ä", "A").Replace("Ö", "O");
        }

        // Placeholder for ToUpperCase (throws exception)
        public void ToUpperCase(object value)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region NULL HANDLING METHODS

        // Handle null for lowercase conversion
        public string ToLowerWordNull(string input)
        {
            if (input == null)
                return string.Empty;  // Returnerar tom sträng istället för att kasta undantag
            return input.ToLower();
        }

        // Handle null for uppercase conversion
        public string ToUpperWordNull(string input)
        {
            if (input == null)
                return string.Empty;  // Returnerar tom sträng istället för att kasta undantag
            return input.ToUpper();
        }

        // Handle null and empty input for first letter lowercase conversion
        public string ToLowerCaseNull(string input)
        {
            if (input == null || input.Length == 0)
                return string.Empty;  // Returnerar tom sträng om input är null eller tom
            return char.ToLower(input[0]) + (input.Length > 1 ? input.Substring(1) : string.Empty);
        }

        // Handle null and empty input for first letter uppercase conversion
        public string ToUpperCaseNull(string input)
        {
            if (input == null || input.Length == 0)
                return string.Empty;  // Returnerar tom sträng om input är null eller tom
            return char.ToUpper(input[0]) + (input.Length > 1 ? input.Substring(1) : string.Empty);
        }

        #endregion
    }
}
