
//Q1. Create a class Student having member rollno, name, maths, sci, eng,total
//Create 5 object and store in sorted list class and display detail name wise ascending order


using System;
using System.Collections.Generic;

namespace consol1
{
    class student
    {
        static int autoroll = 100;
        int rollno;
        string name;
        int marks;
        public student(string name, int marks)
        {
            this.rollno = ++autoroll;
            this.name = name;
            this.marks = marks;
        }
        public String NAME
        {
            get { return name; }
        }
        public override string ToString()
        {
            return string.Format("Id:{0} name:{1} marks:{2}", rollno, name, marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("akash", 99);
            student s2 = new student("ganesh", 95);
            student s3 = new student("anand", 99);
            student s4 = new student("vaibhav", 95);

            SortedList<string, student> ob = new SortedList<string, student>();

            ob.Add(s1.NAME, s1);
            ob.Add(s2.NAME, s2);
            ob.Add(s3.NAME, s3);
            ob.Add(s4.NAME, s4);

            foreach (KeyValuePair<string,student> s in ob)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();

        }
    }
}
