using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalAssignment.UppgifterTDD.Uppgift2;  // Referens till klassen med metoden som ska testas

namespace FinalAssignmentTest.Tests.Uppgift2
{
    [TestClass]
    public class StringProcessorTest
    {
        [TestMethod]
        public void Reverse_ValidString_ReturnsReversedString()
        {
            // Arrange
            var processor = new StringProcessor();  // Skapar en instans av klassen vi testar
            var input = "StringTest";               // Sträng att testa
            var expected = "tseTgnirtS";             // Förväntat resultat (omvänd sträng)

            // Act
            var actual = processor.Reverse(input);  // Kör metoden med input

            // Assert
            Assert.AreEqual(expected, actual);//"Testet misslyckas eftersom Reverse-metoden inte fungerar som förväntat.");
        }
        // ToLower 
        

        [TestMethod]
        public void ToLowerWord_ValidString_ReturnsLowercaseString()
        {
            // Arrange
            var processor = new StringProcessor();  // Skapar en instans av klassen vi testar
            var input = "StringTest";               // Sträng att testa
            var expected = "stringtest";             // Förväntat resultat (omvänd sträng)

            // Act
            var actual = processor.ToLowerWord(input);  // Kör metoden med input

            // Assert
            Assert.AreEqual(expected, actual);//"Testet misslyckas eftersom ToLower-metoden inte fungerar som förväntat.");
        
    }       //ToUpper
         [TestMethod]
    public void ToUpperWord_ValidString_ReturnsUppercaseString()
    {
        // Arrange
        var processor = new StringProcessor();  // Skapar en instans av klassen vi testar
        var input = "StringTest";               // Sträng att testa
        var expected = "STRINGTEST";             // Förväntat resultat (omvänd sträng)

        // Act
        var actual = processor.ToUpperWord(input);  // Kör metoden med input

        // Assert
        Assert.AreEqual(expected, actual);//"Testet misslyckas eftersom ToUpper-metoden inte fungerar som förväntat.");
    }
        //RemoveSwedishCharacters

        [TestMethod]
        public void RemoveSwedishCharacters()
        {
            // Arrange
            var processor = new StringProcessor();  // Skapar en instans av klassen vi testar
            var input = "Hejåäö";  // Sträng att testa

            // Act
            var actual = processor.OnlyEnglsihLetters(input);  // Nästa steg implementera så att testet går igenom, steg 3 refaktorisera 

            // Assert
            Assert.IsFalse(actual.Contains("å"), "Strängen innehåller otillåtna tecken 'å'");//går inte att använda StringAssert.DoesNotContain
            Assert.IsFalse(actual.Contains("ä"), "Strängen innehåller otillåtna tecken 'ä'");
            Assert.IsFalse(actual.Contains("ö"), "Strängen innehåller otillåtna tecken 'ö'");
        }

    }
}


