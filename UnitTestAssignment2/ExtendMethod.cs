using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace UnitTestAssignment2
{
    public static class ExtendMethod
    {
        public static int WordCount(this string a)
        {
            int b = 0, myWord = 1;
            while (b <= a.Length - 1)
            {
                if (a[b] == ' ' || a[b] == '\n' || a[b] == '\t')
                {
                    myWord++;
                }
                b++;
            }
            return myWord;
        }
        public static string ConvertUpperOrLower(this string a)
        {
            var result = new StringBuilder();
            for(int i = 0; i < a.Length; i++)
            {
                if (char.IsUpper(a[i]))
                    result.Append(char.ToLower(a[i]));
                else
                    result.Append(char.ToUpper(a[i]));
            }
            return result.ToString();
        }
        public static bool IsLower(this string a)
        {
            if(a.Any(char.IsUpper) || a.Any(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsUpper(this string a)
        {
            if (a.Any(char.IsLower) || a.Any(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string ConvertCapitalize(this string a)
        {
            return char.ToUpper(a[0]) + a.Substring(1);
        }
        public static string ConvertTitleCase(this string a)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(a);
        }
        public static string RemoveLastCharacter(this string a)
        {
            return a.Remove(a.Length - 1, 1);
        }
        public static bool ValidNumeric(this string a)
        {
            int number1 = 0;
            return int.TryParse(a, out number1);
        }
        public static int? StringToNumber(this string a)
        {
            if (a.ValidNumeric())
            {
                return int.Parse(a);
            }
            else
                return null;
        }
    }
}
