using System;

namespace CmLibrary
{
    public class StringLibrary
    {
        /// <summary>
        /// Check if the string is null or empty string
        /// This method is not an extension method of the existing String.IsNullOrEmpty() method because there is alredy a method that does the same thing.
        /// Extension method is mean to create something new for the existing class. For our case, we do not create new functionality.
        /// So, static method is more suitable.
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns>True if the string is null or empty</returns>
        public static bool IsNullOrEmpty(string value)
        {
            if (value == null || value.Length == 0) 
            {
                return true;
            }
            
            return false;
        }
    }
}
