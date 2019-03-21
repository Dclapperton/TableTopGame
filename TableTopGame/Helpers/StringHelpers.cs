using System.Linq;

namespace TableTopGame.Helpers
{
    public static class StringHelpers
    {
        public static string UpperCaseFirstLetter(this string value)
        {
            char firstLetter = char.ToUpper(value.ToCharArray().First());
            string otherLetters = value.Substring(1).ToLower();

            return $"{firstLetter}{otherLetters}";
        }
    }
}
