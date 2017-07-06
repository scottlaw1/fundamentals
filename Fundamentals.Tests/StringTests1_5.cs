using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Fundamentals.Tests
{
    public class StringTests1_5
    {
        public string CompressString(string stringToCompress)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            if (String.IsNullOrEmpty(stringToCompress))
                throw new InvalidDataException("null or empty string can't be compressed");

            int originalStringLength = stringToCompress.Length;

            for (int i = 0; i < originalStringLength; i++)
            {
                if (!dictionary.ContainsKey(stringToCompress[i]))
                    dictionary.Add(stringToCompress[i], 1);
                else
                {
                    dictionary[stringToCompress[i]]++;
                }
            }

            StringBuilder compressedStringBuilder = new StringBuilder();

            foreach(KeyValuePair<char,int> kvp in dictionary)
            {
                compressedStringBuilder.Append(kvp.Key);
                compressedStringBuilder.Append(kvp.Value);
            }

            if (compressedStringBuilder.ToString().Length < originalStringLength)
                return compressedStringBuilder.ToString();
            return stringToCompress;
        }

        [Fact]
        public void GivenNullInputCompressStringThrowsInvalidDataException()
        {
            Assert.Throws<InvalidDataException>(() => CompressString(null));
        }

        [Fact]
        public void GivenSingleCharacterStringCompressStringReturnsOriginalString()
        {
            string originalString = "a";

            string compressedString = CompressString(originalString);
            Assert.Equal(originalString, compressedString);
        }

        [Fact]
        public void GivenStringWithRepeatedCharactersCompressStringReturnsCompressedString()
        {
            string originalString = "aaaaaaaaaaaaaaeeeeeeeeeiiioou";

            string compressedString = CompressString(originalString);
            Assert.NotEqual(originalString, compressedString);
        }
    }
}
