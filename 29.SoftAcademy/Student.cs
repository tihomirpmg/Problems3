using System;
using System.Collections.Generic;
using System.Text;

namespace _29.SoftAcademy
{
    class Student 
    {
        private int n;
        private string name;
        private List<string> courses;

        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<string> Courses
        {
            get { return courses; }
            set { courses = value; }
        }
        public Student(int n, string name, List<string> courses)
        {
            this.n = n;
            this.name = name;
            this.courses = courses;
        }
        public override string ToString()
        {
            return "Student number: " + n + ", student name: " + name + ", student course" + courses;
        }
    }
}
