using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorNS
{
    public class Exercise3
    {
        public string deleteSymb(string a1, string b1)
        {
            bool flag;

            for (int i = 0; i < b1.Length; i++)
            {
                do
                {
                    flag = a1.Contains(b1[i].ToString());
                    if (flag == true)
                    {
                        int numberOfSymb;
                        numberOfSymb = a1.IndexOf(b1[i]);
                        a1 = a1.Remove(numberOfSymb, 1);
                    }
                } while (flag == true);
            }
            return a1;
        }
    }
}
