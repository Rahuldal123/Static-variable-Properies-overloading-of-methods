using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Employee
    { 
        // static variable ehich is constant for all methods
        private int id;
        private static int count = 0;
        private string name;
        private double bs, hra, da, pf, pt,netpaid;

        public Employee( string name, double bs,double pt)
        {
            count++;
            id = count;
            this.name = name;
            this.bs=bs;
            this.pt= pt;    

        }
        public static int displaycount()
        {
            return count;
        }
        public void calculatesal()
        {
            hra = 0.4 * bs;
            da = 0.2 * bs;
            pf = 0.12 * bs;
            netpaid = bs + hra + da - pf - pt;
        }
        public string displaysalary()
        {
            return $"empid={id} emp name={name} et paid salary is {netpaid}";
        }
    }
}
