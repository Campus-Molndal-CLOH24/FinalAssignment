using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalAssignment.UppgifterTDD.Uppgift2;  
namespace FinalAssignmentTest.Tests.Uppgift2
{
    [TestClass]
    public class StringProcessorTest
    {
        #region Reverse Tests
        [TestMethod]
        public void Reverse_ValidString_ReturnsReversedString()
        {
                        var processor = new StringProcessor();
            var input = "StringTest";
            var expected = "tseTgnirtS";
                        var actual = processor.Reverse(input);
                        Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Reverse_EmptyString_ReturnsEmptyString()
        {
                        var processor = new StringProcessor();
            var input = "";
            var expected = "";
                        var actual = processor.Reverse(input);
                        Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Reverse_NullString_ReturnsEmptyString()
        {
                        var processor = new StringProcessor();
                        var actual = processor.Reverse(null);
                        Assert.AreEqual(string.Empty, actual);
        }
        #endregion
        #region ToLower and ToUpper Word Tests
        [TestMethod]
        public void ToLowerWord_ValidString_ReturnsLowercaseString()
        {
                        var processor = new StringProcessor();
            var input = "StringTest";
            var expected = "stringtest";
                        var actual = processor.ToLowerWord(input);
                        Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToUpperWord_ValidString_ReturnsUppercaseString()
        {
                        var processor = new StringProcessor();
            var input = "StringTest";
            var expected = "STRINGTEST";
                        var actual = processor.ToUpperWord(input);
                        Assert.AreEqual(expected, actual);
        }
        #endregion
        #region Null Input Tests
        [TestMethod]
        public void ToLowerWordNull_NullString_ReturnsEmptyString()
        {
                        var processor = new StringProcessor();
                        var result = processor.ToLowerWordNull(null);
                        Assert.AreEqual(string.Empty, result);
        }
        [TestMethod]
        public void ToUpperWordNull_NullString_ReturnsEmptyString()
        {
                        var processor = new StringProcessor();
                        var result = processor.ToUpperWordNull(null);
                        Assert.AreEqual(string.Empty, result);
        }
        [TestMethod]
        public void ToLowerCaseNull_NullString_ReturnsEmptyString()
        {
                        var processor = new StringProcessor();
                        var result = processor.ToLowerCaseNull(null);
                        Assert.AreEqual(string.Empty, result);
        }
        [TestMethod]
        public void ToUpperCaseNull_NullString_ReturnsEmptyString()
        {
                        var processor = new StringProcessor();
                        var result = processor.ToUpperCaseNull(null);
                        Assert.AreEqual(string.Empty, result);
        }
        #endregion
        #region Capitalization Tests
        [TestMethod]
        public void ToUpperCase_ValidString_ReturnsCorrectCapitalizedString()
        {
                        var processor = new StringProcessor();
            var input = "hello";
            var expected = "Hello";
                        var actual = processor.ToUpperCaseNull(input);
                        Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToLowerCase_ValidString_ReturnsCorrectLowercaseString()
        {
                        var processor = new StringProcessor();
            var input = "Hello";
            var expected = "hello";
                        var actual = processor.ToLowerCaseNull(input);
                        Assert.AreEqual(expected, actual);
        }
        #endregion
        #region Special Character Tests
        [TestMethod]
        public void RemoveSwedishCharacters_ReturnsStringWithoutSwedishLetters()
        {
                        var processor = new StringProcessor();
            var input = "Hejåäö";
            var expected = "Hejaao";  
                        var actual = processor.OnlyEnglsihLetters(input);
                        Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
