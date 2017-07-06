using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Fundamentals.Tests
{
    public class StringTests1_1
    {
        /// <summary>
        /// Tests uniqueness of string of characters, alphanumeric, symbol, and/or whitespace
        /// </summary>
        /// <param name="testString"></param>
        /// <returns></returns>
        public bool AllCharsUnique(string testString)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            if (String.IsNullOrEmpty(testString))
                throw new InvalidDataException("testString has no characters");

            for (int i = 0; i < testString.Length; i++)
            {
                if (!dictionary.ContainsKey(testString[i]))
                    dictionary.Add(testString[i], 1);
                else
                    return false;
            }
            return true;
        }

        [Fact]
        public void GivenNullInputAllCharsUniqueThrowsInvalidDataException()
        {
            Assert.Throws<InvalidDataException>(() => AllCharsUnique(null));
        }

        [Fact]
        public void GivenUniqueStringAllCharsUniqueReturnsTrue()
        {
            string uniqueString = "asdfjkl;";

            bool result = AllCharsUnique(uniqueString);

            Assert.True(result);
        }

        [Fact]
        public void GivenNonUniqueStringAllCharsUniqueReturnsFalse()
        {
            string nonUniqueString = "asdfjkl;a";

            bool result = AllCharsUnique(nonUniqueString);

            Assert.False(result);
        }

        [Fact]
        public void GivenStringWithMultipleWhiteSpaceAllCharsUniqueReturnsFalse()
        {
            //The following string was chosen because whitespace is the only duplicated
            //character in it.
            string nonUniqueString = "A quick red fox";

            bool result = AllCharsUnique(nonUniqueString);

            Assert.False(result);
        }
    }
}
