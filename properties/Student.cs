﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Student
    {

        //Properties


        //private int rollno;
        //private string name;
        //private double percentage;

        //public int Rollno
        //{
        //    get { return rollno; }
        //    set { rollno = value; }
        //}
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //public double Percentage
        //{
        //    get { return percentage; }
        //    set { percentage = value; }

        //}
        //public override string ToString()
        //{
        //    return $"{rollno} {name} {percentage}";
        //}


        // Autogenerated properties using To string method



        public int Rollno { get; set; }
        public string Name { get; set; }
        public double  percentege { get; set; }
        public char Grade { get; set; }

        public override string ToString()
        {
            return $"Roll no={Rollno} name ={Name}Percentage= {percentege}grade= {Grade}";
        }


    }
}
