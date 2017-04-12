using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Calculator
    {

        public int Stray(int[] array)
        {
            return array.GroupBy(x => x).Where(x => x.Count() == 1).First().Key;
        }
    }
}
