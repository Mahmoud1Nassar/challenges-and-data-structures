using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Challenges.Reverse_Words
{
    public static class ReverseWord
    {
        public static string ReverseWords(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
