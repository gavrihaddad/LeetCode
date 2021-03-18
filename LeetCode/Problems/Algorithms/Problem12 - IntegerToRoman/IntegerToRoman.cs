using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Algorithms.Problem12___IntegerToRoman
{

    /// <summary>
    /// Solves problem 12.
    /// Accepted by LeetCode.
    /// </summary>
    class IntegerToRoman
    {
        /// Runtime: 84 ms, faster than 94.23% of C# online submissions (LeetCode submission message).
        #region Solution 1: Brute force.

        static string intToRoman1(int num)
        {
            string roman = "";

            roman = string.Concat(ConvertSingles(num % 10), roman);
            num /= 10;
            roman = string.Concat(ConvertTens(num % 10), roman);
            num /= 10;
            roman = string.Concat(ConvertHundreds(num % 10), roman);
            num /= 10;
            roman = string.Concat(ConvertThousends(num % 10), roman);

            return roman;
        }

        static string ConvertSingles(int num)
        {
            switch (num)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                default:
                    return "";
                    break;
            }
        }

        static string ConvertTens(int num)
        {
            switch (num)
            {
                case 1:
                    return "X";
                case 2:
                    return "XX";
                case 3:
                    return "XXX";
                case 4:
                    return "XL";
                case 5:
                    return "L";
                case 6:
                    return "LX";
                case 7:
                    return "LXX";
                case 8:
                    return "LXXX";
                case 9:
                    return "XC";
                default:
                    return "";
                    break;
            }
        }

        static string ConvertHundreds(int num)
        {
            switch (num)
            {
                case 1:
                    return "C";
                case 2:
                    return "CC";
                case 3:
                    return "CCC";
                case 4:
                    return "CD";
                case 5:
                    return "D";
                case 6:
                    return "DC";
                case 7:
                    return "DCC";
                case 8:
                    return "DCCC";
                case 9:
                    return "CM";
                default:
                    return "";
                    break;
            }
        }

        static string ConvertThousends(int num)
        {
            switch (num)
            {
                case 1:
                    return "M";
                case 2:
                    return "MM";
                case 3:
                    return "MMM";
                default:
                    return "";
                    break;
            }
        }

        #endregion

        /// Runtime: 80 ms, faster than 97.38% of C# online submissions (LeetCode submission message).
        #region Solution 2: A little smarter brute force.

        static string intToRoma2(int num)
        {
            string roman = "";

            roman = string.Concat(ConvertDigit(num % 10, "I", "V", "X"), roman);
            num /= 10;
            roman = string.Concat(ConvertDigit(num % 10, "X", "L", "C"), roman);
            num /= 10;
            roman = string.Concat(ConvertDigit(num % 10, "C", "D", "M"), roman);
            num /= 10;
            roman = string.Concat(ConvertDigit(num % 10, "M", "", ""), roman);

            return roman;
        }

        static string ConvertDigit(int num, string a, string b, string c)
        {
            switch (num)
            {
                case 1:
                    return a;
                case 2:
                    return a + a;
                case 3:
                    return a + a + a;
                case 4:
                    return a + b;
                case 5:
                    return b;
                case 6:
                    return b + a;
                case 7:
                    return b + a + a;
                case 8:
                    return b + a + a + a;
                case 9:
                    return a + c;
                default:
                    return "";
                    break;
            }
        }

        #endregion
    }
}
