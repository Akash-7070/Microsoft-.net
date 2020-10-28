
/*
 * Q2. Create a class person having virtual method
 public virtual string  dojob(){ “doing job”}
create three child class programmer,dancer and singer.
In programmer class override virtual method
public override string  dojob(){ “doing coding”}
programmer class also has method public void testing{  “I am testing code also” }
In  singer class override virtual method
public override string  dojob(){ “singing”}
in dancer class no method available.
Create array of person class and call dojob() method.
Also call testing method of programmer class in a loop
 * 
*/

using System;


namespace Person
{
    class Person
    {
        public virtual string dojob()
        {
            return "Person Doing job";
        }
    }
    class Programmer :Person
    {
        public override string dojob()
        {
            return "doing coding”";
        }

        public void testing()
        {
            Console.WriteLine("I am also doing coding");
        }
    }
    class Singer : Person
    {
        public override string dojob()
        {
            return "Singing";
        }
    }
     class Dancer : Person
    {
        
    }

    class program
    {
        static void Main(string[] args)
        {
            Person[] arr = new Person[3];
            arr[0] = new Programmer();
            arr[1] = new Singer();
            arr[2] = new Dancer();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].dojob());
                if (arr[i] is Programmer)
                {
                    Programmer p = (Programmer)arr[i];
                    p.testing();
                   // ((Programmer)arr[i]).testing();
                 }

            }
            Console.ReadLine();
        }    
    }
       
    
}
