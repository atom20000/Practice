using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace Pr04_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
            list["Estados Unidos"] = "United States of America";
            list["Canada"] = "Canada";
            list["Espana"] = "Spain";
            Console.WriteLine(list["espana"]);
            Console.WriteLine(list["CANADA"]);
            Console.Read();
        }
    }
}
