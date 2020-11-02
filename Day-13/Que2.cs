/*
 * Q2. Create a class student having member id, name,  marks. Write method public 
 * void give_gracemarks(int mks) when you call method with marks>5 it should throw  user define exception.
It should print name id and marks.
 */

using System;
using System.IO;

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
                throw new MyException(ROLLNO, Name, Marks, "Grace marks should not be greater than 5");
            }

            else
            {
                Marks += m;
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
            student[] arr = new student[4];
            arr[0] = new student("Akash", 85);
            arr[1]  = new student("Vaibhav", 92);
            arr[2] = new student("Anand", 90);
            arr[3] = new student("Ganesh", 93);

            try
            {
                arr[0].graceMarks(5);
                arr[1].graceMarks(4);
                arr[2].graceMarks(8);  // it will throw exception
                arr[3].graceMarks(5);
            }

            catch (MyException e)
            {
                Console.WriteLine(e.MSG);
            }

            try
            {
                FileStream fi = new FileStream("student.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fi);

                for (int i = 0; i < arr.Length; i++)
                {
                    string s = arr[i].ToString();
                    sw.Write(s+"\n");
                    sw.Flush();
                }    
                Console.WriteLine("Done with File");
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
