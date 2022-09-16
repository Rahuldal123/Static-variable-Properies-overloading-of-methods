using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace properties
{

    // Method overloading 
    internal class calulation
    {
        public int addition(int a,int b)
        {
            return a + b;
        }
        public int addition(int a,int b,int c)
        {
            return a + b + c;

        }
        public double additon(double a,int b)
        {
            return a + b;

        }
        public double addition(double a,double b)
        {
            return a + b;
        }
    }
}
