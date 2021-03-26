using System;
using UnitTestAssignment2;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void PositiveTestCase_For_ConvertUpperOrLower()
        {
            // Arrange
            string a = "This Is the tEST Cases for @1";
            // Act
            string result = a.ConvertUpperOrLower();
            // Assert
            Assert.Equal("tHIS iS THE Test cASES FOR @1", result);
        }
        [Fact]
        public void NegativeTestCase_For_ConvertUpperOrLower()
        {
            // Arrange
            string a = "This Is the tEST Cases for @1";
            // Act
            string result = a.ConvertUpperOrLower();
            // Assert
            Assert.NotEqual("tHIS iS THE Test cASES for @1", result);
        }
       
        [Fact]
        public void PositiveTestCase_For_ConvertTitleCase()
        {
            // Arrange
            string a = "This Is the test Cases for @1";
            // Act
            string result = a.ConvertTitleCase();
            // Assert
            Assert.Equal("This Is The Test Cases For @1", result);
        }
        [Fact]
        public void NegativeTestCase_For_ConvertTitleCase()
        {
            // Arrange
            string a = "This Is the tEST Cases for @1";
            // Act
            string result = a.ConvertTitleCase();
            // Assert
            Assert.NotEqual("This Is the TEST Cases for @1", result);
        }
        [Fact]
        public void PositiveTestCase_For_IsLower()
        {
            // Arrange
            string a = "this is the test cases";
            // Act
            bool result = a.IsLower();
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void NegativeTestCase_For_IsLower()
        {
            // Arrange
            string a = "This Is the tEST Cases for @1";
            // Act
            bool result = a.IsLower();
            // Assert
            Assert.False(result);
        }
        [Fact]
        public void PositiveTestCase_For_IsUpper()
        {
            // Arrange
            string a = "THIS IS THE TEST CASES";
            // Act
            bool result = a.IsUpper();
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void NegativeTestCase_For_IsUpper()
        {
            // Arrange
            string a = "THIS IS THE TEST CASEs";
            // Act
            bool result = a.IsUpper();
            // Assert
            Assert.False(result);
        }
        [Fact]
        public void PpsitiveTestCase_For_ConvertCapitalize()
        {
            // Arrange
            string a = "this Is the tEST Cases for @1";
            // Act
            string result = a.ConvertCapitalize();
            // Assert
            Assert.Equal("This Is the tEST Cases for @1", result);
        }
        [Fact]
        public void NegativeTestCase_For_ConvertCapitalize()
        {
            // Arrange
            string a = "this Is the tEST Cases for @1";
            // Act
            string result = a.ConvertCapitalize();
            // Assert
            Assert.NotEqual("this Is the tEST Cases for @1", result);
        }
        [Fact]
        public void PositiveTestCase_For_WordCount()
        {
            // Arrange
            string a = "This Is the tEST Cases for @1";
            // Act
            int result = a.WordCount();
            // Assert
            Assert.Equal(7, result);
        }
        [Fact]
        public void NegativeTestCase_For_WordCount()
        {
            // Arrange
            string a = "This Is the tEST Cases for @1";
            // Act
            int result = a.WordCount();
            // Assert
            Assert.NotEqual(6, result);
        }
        [Fact]
        public void PositiveTestCase_For_RemoveLastCharacter()
        {
            // Arrange
            string a = "This Is the tEST Cases for @1";
            // Act
            string result = a.RemoveLastCharacter();
            // Assert
            Assert.Equal("This Is the tEST Cases for @", result);
        }
        [Fact]
        public void NegativeTestCase_For_RemoveLastCharacter()
        {
            // Arrange
            string a = "This Is the tEST Cases for @1";
            // Act
            string result = a.RemoveLastCharacter();
            // Assert
            Assert.NotEqual("This Is the tEST Cases for @1", result);
        }
        [Fact]
        public void PositiveTestCase_For_ValidNumeric()
        {
            // Arrange
            string a = "123456";
            // Act
            bool result = a.ValidNumeric();
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void NegativeTestCase_For_ValidNumeric()
        {
            // Arrange
            string a = "This Is the tEST Cases for @1";
            // Act
            bool result = a.ValidNumeric();
            // Assert
            Assert.False(result);
        }
        [Fact]
        public void PositiveTestCase_For_StringToNumber()
        {
            // Arrange
            string a = "123";
            // Act
            int? result = a.StringToNumber();
            // Assert
            Assert.Equal(123, result);
        }
        [Fact]
        public void NegativeTestCase_For_StringToNumber()
        {
            // Arrange
            string a = "123a";
            // Act
            int? result = a.StringToNumber();
            // Assert
            Assert.Null(result);
        }
    }
}
