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
            var stringArray = str.Split(' ');
            var newStrings = new List<string>();

            for (int i = 0; i < stringArray.Count(); i++)
            {
                var ary = stringArray[i].ToCharArray();
                if (ary.Count() >= 5)
                {
                    var newAry = ary.Reverse();
                    newStrings.Add(new string(newAry.ToArray()));
                }
                else
                {
                    newStrings.Add(stringArray[i]);
                }
            }

            var result = string.Join(" ", newStrings);

            return result;

        }
    }
}
