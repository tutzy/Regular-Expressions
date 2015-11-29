using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _01.Series_of_Letters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
        }
    }
}



