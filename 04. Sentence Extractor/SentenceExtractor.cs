using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Sentence_Extractor
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            string patternLeft = @"[\w\sA-Z]+\b ";
            string patternRight = @" \b[^.!?]*[.?!]";
            Regex regex = new Regex(patternLeft + keyword + patternRight);
            MatchCollection match = regex.Matches(text);
            foreach (var sentences in match)
            {
                Console.WriteLine(sentences);
            }

        }
    }
}
