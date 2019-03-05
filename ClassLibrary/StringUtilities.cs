using System;
using System.Linq;

namespace ClassLibrary
{
    public static class StringUtilities
    {
        public static int CountOccurences(char charToFind, string stringToCheck)
        {
            if (stringToCheck == null)
                return -1;

            char lowerChar = charToFind.ToString().ToLower()[0];
            return stringToCheck.ToLower().Count(x => x == lowerChar);
        }
    }
}
