using System;
using Xunit;
using CmLibrary;

namespace CmTest
{
    public class IntegerLibraryTest
    {
        [Fact]
        public void PositiveDivisorsSixty()
        {
            Assert.Equal(new int[] {1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60}, IntegerLibrary.PositiveDivisors(60));
        }

        [Fact]
        public void PositiveDivisorsFortyTwo()
        {
            Assert.Equal(new int[] {1, 2, 3, 6, 7, 14, 21, 42}, IntegerLibrary.PositiveDivisors(42));
        }   

        [Fact]
        public void PositiveDivisorsZero()
        {
            Assert.Equal(new int[] { 0 }, IntegerLibrary.PositiveDivisors(0));
        }  

        [Fact]
        public void PositiveDivisorsOne()
        {
            Assert.Equal(new int[] { 1 }, IntegerLibrary.PositiveDivisors(1));
        }  

        [Fact]
        public void PositiveDivisorsOneTwo()
        {
            Assert.Equal(new int[] { 1, 2 }, IntegerLibrary.PositiveDivisors(2));
        }  

        [Fact]
        public void PositiveDivisorsThree()
        {
            Assert.Equal(new int[] { 1, 3 }, IntegerLibrary.PositiveDivisors(3));
        }

        [Fact]
        public void PositiveDivisorsMinInt()
        {
            Assert.Equal(new int[] { 0 }, IntegerLibrary.PositiveDivisors(Int32.MinValue));
        }  

        [Fact]
        public void PositiveDivisorsMaxInt()
        {
            Assert.Equal(new int[] { 1, Int32.MaxValue }, IntegerLibrary.PositiveDivisors(Int32.MaxValue));
        }

        [Fact]
        public void MostCommonNumbersFirst()
        {
            Assert.Equal(new int[] {1, 2, 3, 4, 5, 6, 7}, IntegerLibrary.MostCommonNumbers(new int[] {1, 2, 3, 4, 5, 6, 7}));
        }

        [Fact]
        public void MostCommonNumbersSecond()
        {
            Assert.Equal(new int[] {1}, IntegerLibrary.MostCommonNumbers(new int[] {1, 2, 3, 4, 5, 1, 6, 7}));
        } 

        [Fact]
        public void MostCommonNumbersThird()
        {
            Assert.Equal(new int[] {5, 4}, IntegerLibrary.MostCommonNumbers(new int[] {5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4}));
        } 

        [Fact]
        public void MostCommonNumbersEmpty()
        {
            Assert.Equal(new int[] {}, IntegerLibrary.MostCommonNumbers(new int[] {}));
        } 

        [Fact]
        public void MostCommonNumbersMaxInteger()
        {
            Assert.Equal(new int[] { Int32.MaxValue }, IntegerLibrary.MostCommonNumbers(new int[] { Int32.MaxValue, 1, Int32.MaxValue }));
        } 

        [Fact]
        public void MostCommonNumbersMaxIntegerOne()
        {
            Assert.Equal(new int[] { 1, Int32.MaxValue }, IntegerLibrary.MostCommonNumbers(new int[] { 1, Int32.MaxValue, 1, Int32.MaxValue }));
        } 

    }
}
