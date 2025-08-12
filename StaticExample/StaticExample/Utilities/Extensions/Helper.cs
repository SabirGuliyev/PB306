namespace StaticExample.Utilities.Extensions
{
    internal static class Helper
    {
        public static string Capitalize(this string word)
        {

            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }
        public static int Power(this int num, int pow = 2)
        {
            int result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }

    }
}
