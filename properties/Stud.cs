﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    public class Stud
    {
        private int id;
        private int rollno;
        private string name;
        private decimal per;

        public int Id { get;set; }
        public int Rollno { get;set; }

        public string Name { get; set; }

        public decimal Per { get; set; }

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
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
        //public double Per
        //{
        //    get { return per; }
        //    set { per = value; }
        //}
        public override string ToString()
        {
            return $"Stud Id->{id}\n Stud rollno->{rollno}\n Stud name->{name}\n Stud per->{per}";
        }
    }
}
