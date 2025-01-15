using System;
namespace FinalAssignment.UppgifterTDD.Uppgift2
{
    public class StringProcessor
    {
        #region STRING PROCESSING METHODS
                public string Reverse(string? input)
        {
            if (input == null)
                return string.Empty;  
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
                public string ToLowerWord(string? input)
        {
            return input == null ? string.Empty : input.ToLower();          }
                public string ToUpperWord(string? input)
        {
            return input == null ? string.Empty : input.ToUpper();          }
                public string ToLowerCase(string? input)
        {
            return input == null ? string.Empty : input.ToLower();          }
                public string OnlyEnglsihLetters(string? input)
        {
            if (input == null)
                return string.Empty;              return input.Replace("å", "a").Replace("ä", "a").Replace("ö", "o")
                        .Replace("Å", "A").Replace("Ä", "A").Replace("Ö", "O");
        }
                public void ToUpperCase(object value)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region NULL HANDLING METHODS
                public string ToLowerWordNull(string? input)
        {
            if (input == null)
                return string.Empty;              return input.ToLower();
        }
                public string ToUpperWordNull(string? input)
        {
            if (input == null)
                return string.Empty;              return input.ToUpper();
        }
                public string ToLowerCaseNull(string? input)
        {
            if (input == null || input.Length == 0)
                return string.Empty;              return char.ToLower(input[0]) + (input.Length > 1 ? input.Substring(1) : string.Empty);
        }
                public string ToUpperCaseNull(string? input)
        {
            if (input == null || input.Length == 0)
                return string.Empty;              return char.ToUpper(input[0]) + (input.Length > 1 ? input.Substring(1) : string.Empty);
        }
        #endregion
    }
}
