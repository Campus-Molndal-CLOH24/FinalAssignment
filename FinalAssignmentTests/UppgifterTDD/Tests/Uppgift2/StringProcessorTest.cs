﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalAssignment.UppgifterTDD.Uppgift2;  // Referens till klassen med metoden som ska testas

namespace FinalAssignmentTest.Tests.Uppgift2
{
    [TestClass]
    public class StringProcessorTest
    {
        #region Reverse Tests
        [TestMethod]
        public void Reverse_ValidString_ReturnsReversedString()
        {
            // Arrange
            var processor = new StringProcessor();
            var input = "StringTest";
            var expected = "tseTgnirtS";

            // Act
            var actual = processor.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            var processor = new StringProcessor();
            var input = "";
            var expected = "";

            // Act
            var actual = processor.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_NullString_ReturnsEmptyString()
        {
            // Arrange
            var processor = new StringProcessor();

            // Act
            var actual = processor.Reverse(null);

            // Assert
            Assert.AreEqual(string.Empty, actual);
        }
        #endregion

        #region ToLower and ToUpper Word Tests
        [TestMethod]
        public void ToLowerWord_ValidString_ReturnsLowercaseString()
        {
            // Arrange
            var processor = new StringProcessor();
            var input = "StringTest";
            var expected = "stringtest";

            // Act
            var actual = processor.ToLowerWord(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToUpperWord_ValidString_ReturnsUppercaseString()
        {
            // Arrange
            var processor = new StringProcessor();
            var input = "StringTest";
            var expected = "STRINGTEST";

            // Act
            var actual = processor.ToUpperWord(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Null Input Tests
        [TestMethod]
        public void ToLowerWordNull_NullString_ReturnsEmptyString()
        {
            // Arrange
            var processor = new StringProcessor();

            // Act
            var result = processor.ToLowerWordNull(null);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToUpperWordNull_NullString_ReturnsEmptyString()
        {
            // Arrange
            var processor = new StringProcessor();

            // Act
            var result = processor.ToUpperWordNull(null);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToLowerCaseNull_NullString_ReturnsEmptyString()
        {
            // Arrange
            var processor = new StringProcessor();

            // Act
            var result = processor.ToLowerCaseNull(null);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToUpperCaseNull_NullString_ReturnsEmptyString()
        {
            // Arrange
            var processor = new StringProcessor();

            // Act
            var result = processor.ToUpperCaseNull(null);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
        #endregion

        #region Capitalization Tests
        [TestMethod]
        public void ToUpperCase_ValidString_ReturnsCorrectCapitalizedString()
        {
            // Arrange
            var processor = new StringProcessor();
            var input = "hello";
            var expected = "Hello";

            // Act
            var actual = processor.ToUpperCaseNull(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToLowerCase_ValidString_ReturnsCorrectLowercaseString()
        {
            // Arrange
            var processor = new StringProcessor();
            var input = "Hello";
            var expected = "hello";

            // Act
            var actual = processor.ToLowerCaseNull(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Special Character Tests
        [TestMethod]
        public void RemoveSwedishCharacters_ReturnsStringWithoutSwedishLetters()
        {
            // Arrange
            var processor = new StringProcessor();
            var input = "Hejåäö";
            var expected = "Hejaao";  // Resultatet där svenska tecken är ersatta

            // Act
            var actual = processor.OnlyEnglsihLetters(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
