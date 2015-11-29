using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Extract_Emails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            string pattern = @"[\w]{1,}(\.|)[\w]{1,}@[\w]{1,}(\.|)[\w]{1,}(\.|)[\w]{1,}";
            Regex regex = new Regex(pattern);
            Match emails = regex.Match(txt);
            MatchCollection results = regex.Matches(txt);
            foreach (var email in results)
            {
                Console.WriteLine( email);
            }
        }
    }
}
