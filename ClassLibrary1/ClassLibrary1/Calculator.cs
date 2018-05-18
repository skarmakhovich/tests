using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNS
{
    public class Calculator
    {
       
       

        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Minus(double num1, double num2)
        {
            return num1 - num2;
        }

        public double max(double num1, double num2)
        {
            if (num1 > num2) return num1;
            
            return num2;
        }

        public double min(double num1, double num2)
        {
            if (num1 < num2) return num1;

            return num2;
        }

        public static String triangleType(int a, int b, int c)
        {
            String type;

            if(a <= 0 || b <= 0 || c <= 0)
            {
             type = "Triangle not valid";
            }
            else if (a == b && b == c)
            {
                type = "Equilateral";
            }
            else if (b == c || a == b || c == a)
            {
                type = "Isosceles";
            }
            else {
                type = "Scalene";
            }
            return type;
        }

        public int methodWithoutFullCoverage(int i)
        {
            if (i > 0) return 1;
            else return -1;
        }
    }
   
}
