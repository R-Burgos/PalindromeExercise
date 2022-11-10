using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("civic", true)]
        [InlineData("refer", true)]
        [InlineData("kayak", true)]
        [InlineData("rotor", true)]
        [InlineData("monkey", false)]
        [InlineData("nose", false)]
        [InlineData("shrek", false)]
        [InlineData("onion", false)]
        [InlineData("donkey", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            WordSmith wordsmith = new WordSmith();

            //Act
            var actual = wordsmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
