using CmLibrary;
using Xunit;

namespace CmTest
{
    public class TriangleLibraryTest
    {
        [Fact]
        public void Valid()
        {
            Assert.Equal(6, TriangleLibrary.CalculateArea(3, 4, 5));
        }

        [Fact]
        public void InValidTriangle()
        {
            Assert.Throws<InvalidTriangleException>(() => TriangleLibrary.CalculateArea(10, 4, 5));
        }  

        [Fact]
        public void InValidFirstZero()
        {
            Assert.Throws<InvalidTriangleException>(() => TriangleLibrary.CalculateArea(0, 4, 5));
        }    

        [Fact]
        public void InValidSecondZero()
        {
            Assert.Throws<InvalidTriangleException>(() => TriangleLibrary.CalculateArea(1, 0, 5));
        }              

        [Fact]
        public void InValidThirdZero()
        {
            Assert.Throws<InvalidTriangleException>(() => TriangleLibrary.CalculateArea(9, 4, 0));
        }  

        [Fact]
        public void InValidFirstNegative()
        {
            Assert.Throws<InvalidTriangleException>(() => TriangleLibrary.CalculateArea(-1, 4, 5));
        }  

        [Fact]
        public void InValidSecondNegative()
        {
            Assert.Throws<InvalidTriangleException>(() => TriangleLibrary.CalculateArea(5, -4, 5));
        } 

        [Fact]
        public void InValidThirdNegative()
        {
            Assert.Throws<InvalidTriangleException>(() => TriangleLibrary.CalculateArea(1, 4, -5));
        } 
    }
}