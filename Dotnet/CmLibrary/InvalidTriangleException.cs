using System;

namespace CmLibrary
{
    public class InvalidTriangleException : Exception
    {
        /// <summary>
        /// A custom triangle exception if the triangle is not valid
        /// </summary>
        /// <returns>The exception</returns>
        public InvalidTriangleException() : base("Sides cannot form a valid triangle.")
        {
        }
    }
}