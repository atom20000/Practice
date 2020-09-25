using System;
using System.Text.RegularExpressions;
namespace Pr03_1_1
{
    class Program
    {
        static (bool, string) IsPhone(string s)
        {
            if (Regex.IsMatch(s, @"(^\+7)(\(?9\d{2}\)?)\d{3}\-?\d{2}\-?\d{2}$"))
            {
                return (true, s);
            }
            else if (Regex.IsMatch(s, @"(^8)(\(?9\d{2}\)?)\d{3}\-?\d{2}\-?\d{2}$"))
            {
                return (true, s);
            }
            else
            {
                return (false, s);
            }
        }
        static (bool,string) IsZip(string s)
        {
            if (Regex.IsMatch(s, @" ^\d{5}(\-\d{4}$)"))
            {
                return (true, s);
            }
            else return (false, s);
        }
        static string ReformatPhone(string s)
        {
            Match m;
            if (Regex.IsMatch(s, @"(^\+7)(\(?9\d{2}\)?)\d{3}\-?\d{2}\-?\d{2}$"))
            {
                m = Regex.Match(s, @"(^\+7)\(?(9\d{2})\)?(\d{3})\-?(\d{2})\-?(\d{2})$");
                return String.Format("{0}({1}){2}-{3}-{4}", m.Groups[1], m.Groups[2], m.Groups[3], m.Groups[4], m.Groups[5]);
            }
            else if (Regex.IsMatch(s, @"(^8)(\(?9\d{2}\)?)\d{3}\-?\d{2}\-?\d{2}$"))
            {
               m = Regex.Match(s, @"(^8)\(?(9\d{2})\)?(\d{3})\-?(\d{2})\-?(\d{2})$");
               return String.Format("{0}({1}){2}-{3}-{4}", m.Groups[1], m.Groups[2], m.Groups[3], m.Groups[4], m.Groups[5]);
            }
            return "";
        }
        static void Main(string[] args)
        {
            string[] l = { "89256798853", "+7(925)679-88-53", "Парава" };
            foreach (string s in l)
            {
                var g = IsPhone(s);
                if (g.Item1)
                {
                    //Console.WriteLine($"{g.Item2} это телефон");
                    Console.WriteLine($"{ReformatPhone(g.Item2)} это телефон");
                }
                else
                {
                    g = IsZip(s);
                    if (g.Item1)
                    {
                        Console.WriteLine($"{g.Item2} это почтовый индекс");
                    }
                    else Console.WriteLine($"{g.Item2} хз что такое ");
                }
            }
        }
    }
}
