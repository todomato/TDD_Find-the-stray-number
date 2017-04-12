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
            var ary = str.ToCharArray();
            var newAry = ary.Reverse();
            return new string(newAry.ToArray());

        }
    }
}
