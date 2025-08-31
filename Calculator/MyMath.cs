using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MyMath
    {
        static internal int calc_addition(int a, int b)
        {
            return a + b;

        }

        static internal int calc_subtraktion(in int a, in int b)
        { 
            return a - b; 
        }
        
        static internal int calc_multiplikation(in int a, in int b)
        { return a * b; }

        static internal int calc_division(in int a, in int b)

        { return a * b;}


    }
}
