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
            var first = array[0];

            if (array.Where(c => c == first).Count() != 1)
            {
                return array.Where(c => c != first).Single();
            }

            return first;
        }
    }
}
