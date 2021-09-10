using PalindromeExercise;
using System;
using Xunit;



namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("nothing", false)]
        [InlineData(" ", true)]
        [InlineData("", true)]

        public void IsAPalindrome(string input, bool expected)
        {
            //Arrange
            WordSmith pal = new WordSmith();


            //Act
            bool actual = pal.IsAPalindrome(input);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
