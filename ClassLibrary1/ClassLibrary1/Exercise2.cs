using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorNS
{
    public class Exercise2
    {
        public string asteriscs(int number)
        {
            string array = "";
            if (number < 0)
            {
                array = "incorrect number";
                return array;
            }
            for (int i = 0; i < number; i++)
            {
                array = array + "*";
            }
            return array;
        }
    }
}