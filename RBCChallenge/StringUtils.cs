using System;

namespace XUnitTestProject1
{
    public class StringUtils
    {
        /// <summary>
        /// Check if a string is palindrome. 
        /// The case is ignored. 
        /// Null value, empty string or whitespace treated as false.
        /// </summary>
        /// <param name="s">String bo be checked</param>
        /// <returns>True if the string is palindrome, false otherwise</returns>
        public bool IsMirrorSequence(String s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;

            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if(char.ToLower(s[i]) != char.ToLower(s[j]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
