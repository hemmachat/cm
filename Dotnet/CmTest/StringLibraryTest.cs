using System;
using Xunit;
using CmLibrary;

namespace CmTest
{
    public class StringLibraryTest
    {
        [Fact]
        public void Null_Value()
        {
            Assert.True(StringLibrary.IsNullOrEmpty(null));
        }

        [Fact]
        public void A_Value()
        {
            Assert.False(StringLibrary.IsNullOrEmpty("a"));
        }

        [Fact]
        public void AA_Value()
        {
            Assert.False(StringLibrary.IsNullOrEmpty("aa"));
        }

        [Fact]
        public void Null_String_Value()
        {
            Assert.False(StringLibrary.IsNullOrEmpty("null"));
        }

        [Fact]
        public void Empty_String_Value()
        {
            Assert.True(StringLibrary.IsNullOrEmpty(""));
        }

        [Fact]
        public void Space_String_Value()
        {
            Assert.False(StringLibrary.IsNullOrEmpty(" "));
        }

        [Fact]
        public void Space_String_Space()
        {
            Assert.False(StringLibrary.IsNullOrEmpty(" a "));
        }

        [Fact]
        public void Space_Strings_Space()
        {
            Assert.False(StringLibrary.IsNullOrEmpty(" aa "));
        }

        [Fact]
        public void String_Empty()
        {
            Assert.True(StringLibrary.IsNullOrEmpty(string.Empty));
        }

    }
}
