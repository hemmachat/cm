using System;

namespace CmLibrary
{
    public class TriangleLibrary
    {
        /// <summary>
        /// Calculate area of a triangle by using three sides lengths
        /// </summary>
        /// <param name="first">First side length</param>
        /// <param name="second">Second side length</param>
        /// <param name="third">Third side length</param>
        /// <returns>Triangle area</returns>
        public static int CalculateArea(int first, int second, int third)
        {
            if (first <= 0 || second <= 0 || third <= 0)
            {
                throw new InvalidTriangleException();
            }

            if (!IsValidTriangle(first, second, third)) 
            {
                throw new InvalidTriangleException();
            }

            return (first + second + third) / 2;
        }

        /// <summary>
        /// Theory to validate a triangle:
        /// 1. a + b > c
        /// 2. a + c > b
        /// 3. b + c > a
        /// </summary>
        /// <param name="first">First side</param>
        /// <param name="second">Second side</param>
        /// <param name="third">Third side</param>
        /// <returns></returns>
        private static bool IsValidTriangle(int first, int second, int third)
        {
            if (first + second > third && 
            first + third > second &&
            second + third > first)
            {
                return true;
            }

            return false;
        }
    }
}