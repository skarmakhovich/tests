using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorNS
{
    public class Exercise3
    {
        public string deleteSymb(string p1, string p2)
        {
            int length1=p1.Length;
            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < p2.Length; j++)
                {
                    if (p1[i].CompareTo(p2[j]) == 0)
                    {
                        p1.Remove(i, 1);
                        j = 0;
                        length1 = length1 - 1;
                    }

                }
            }
            return p1;
        }
    }
}
