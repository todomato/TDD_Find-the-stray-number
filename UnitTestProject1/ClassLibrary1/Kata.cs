using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Kata
    {
        public static string SpinWords(string str)
        {
            var words = str.Split(' ');
            var reversedWords = words.Select(w => w.Length >= 5 ? string.Concat(w.Reverse()) : w);
            return string.Join(" ", reversedWords);
        }
    }
}
