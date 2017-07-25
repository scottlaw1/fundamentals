using System.Text;
using Xunit;

namespace Fundamentals.Tests
{
    public class PalindromeTests
    {
        /// <summary>
        /// I was asked to implement a function that tested a string to see if it
        /// was a palindrome as part of an interview with Facebook.  I was given a
        /// choice regarding how strings consisting solely whitespace should be treated.
        /// The function also needed to ignore special (non alphanumeric) characters in 
        /// its determination.
        /// </summary>
        /// <param name="testString"></param>
        /// <returns></returns>
        public bool IsPalindrome(string testString)
        {
            StringBuilder reversedString = new StringBuilder();
            StringBuilder cleanTestString = new StringBuilder();

            if (string.IsNullOrWhiteSpace(testString))
                return false;

            for (int i = testString.Length - 1; i >= 0; i--)
            {
                if (char.IsLetterOrDigit(testString[i]))
                {
                    reversedString.Append(testString[i]);
                    cleanTestString.Insert(0, testString[i]);
                }
            }
            
            return cleanTestString.ToString().ToLower() == reversedString.ToString().ToLower();
        }

        [Fact]
        public void IsPalindromeReturnsFalseForEmptyString()
        {
            Assert.False(IsPalindrome(string.Empty));
        }

        [Fact]
        public void IsPalindromeReturnsFalseForWhitespaceString()
        {
            Assert.False(IsPalindrome("           "));
        }

        [Fact]
        public void IsPalindromeReturnsTrueForSingleCharacterString()
        {
            Assert.True(IsPalindrome("a"));
        }

        [Fact]
        public void IsPalindromeReturnsFalseForNonPalindrome()
        {
            Assert.False(IsPalindrome("ab"));
        }

        [Fact]
        public void IsPalindromeReturnsTrueForPalindrome()
        {
            Assert.True(IsPalindrome("aaaaaaaaa"));
        }

        [Theory,
            InlineData("raceCar"),
            InlineData("RAcecar"),
            InlineData("Racecar"),
            InlineData("RacecaR")]
        public void IsPalindromeIsCaseInsensitive(string testString)
        {
            Assert.True(IsPalindrome(testString));
        }

        [Theory,
            InlineData("race*Car"),
            InlineData("race,Car"),
            InlineData("race;Car"),
            InlineData("race#Car"),
            InlineData("race@Car")]
        public void IsPalindromeIgnoresSpecialCharacters(string testString)
        {
            Assert.True(IsPalindrome(testString));
        }
    }
}
