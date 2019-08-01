using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string Name;
        public string Major;
        public double Gpa;

        public Student(string name, string major, double gpa)
        {
            Name = name;
            Major = major;
            Gpa = gpa;
        }

        public bool Honour()
        {
            if (Gpa >= 3.5)
            {
                return true;
            } else
                return false;
        }
    }
}
