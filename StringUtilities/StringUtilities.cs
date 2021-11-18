using System;
using System.Text.RegularExpressions;

namespace StringUtilities
{
    public static class StringUtilities
    {
        public static bool IsUniqueCharacterSet(this string s)
        {
            // remove all space chars from string
            var cleanString = Regex.Replace(s, @"[\s+]", "").ToLower();

            // make a hash table/set
            

            foreach( char c in cleanString)
            {

            }

            return false;
        }
    }
}
