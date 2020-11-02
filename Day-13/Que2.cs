/*
 * Q2. Create a class student having member id, name,  marks. Write method public 
 * void give_gracemarks(int mks) when you call method with marks>5 it should throw  user define exception.
It should print name id and marks.
 */

using System;

namespace Que2
{

    class MyException : ApplicationException
    {
        public readonly int rollno;
        public readonly string name;
        public readonly int mark;
        string msg;

        public MyException(int rn, string nm, int mark, string msg)
        {
            this.rollno = rn;
            this.mark = mark;
            this.name = nm;
            this.msg = msg;
        }
        public string MSG
        {
            get { return msg; }
        }

    }

    public class student
    {
        int rollno;

        string name;
        int marks;

        static int AutoRollno;

        public student(string name, int mks)
        {
            rollno = ++AutoRollno;
            Name = name;
            Marks = mks;
        }
        public int ROLLNO
        {
            get { return rollno; }
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
        }
        public int Marks
        {
            get { return marks; }

            set { marks = value; }
        }

        public void graceMarks(int m)
        {
            if (m > 5)
            {
                throw new MyException(ROLLNO,Name,Marks,"Grace marks should not be greater than 5");
            }

            else
            {
                Marks+=m;
            }

        }

        public override string ToString()
        {
            return string.Format("RollNo= {0}  Name= {1}  Marks= {2}", ROLLNO, Name, Marks);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("Akash", 85);
            student s2 = new student("Vaibhav", 92);
            student s3 = new student("Anand", 90);
            student s4 = new student("Ganesh", 93);

            try
            {
                s1.graceMarks(5);
                s2.graceMarks(4);
                s3.graceMarks(8);  // it will throw exception
                s4.graceMarks(5);   
            }

            catch(MyException e)
            {
                Console.Write("Rollno= {0}, Name= {1}, Marks= {2}",e.rollno,e.name,e.mark);
                Console.WriteLine(" ("+e.MSG+")");
            }

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
        
            Console.ReadLine();
        }
    }
}
