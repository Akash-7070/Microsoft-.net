/*Q5. Create class Animal having virtual method speak returning string” I don’t know how to speak”.
Create a child class dog having overridden speak method returning string “Bhow BHow”.
Create a child class cat having overridden speak method returning string “mewo mewo”
Create a child class donkey does not have any method.
Create class showpoly having method call who’s job is to call speak method using reference of Animal. 
 * Create object of all child class and then call showpoly’s class call method and pass child class object
*/


using System;

namespace Speak
{
    public class Animal
    {
        public virtual string speak()
        { 
           return "I don’t know how to speak";
        }
    }

    public class dog : Animal
    {
         public override string speak()
        { 
           return "Bhow Bhow";
        }
    }

    public class cat : Animal
    {
        public override string speak()
        {
            return "Meow Meow";
        }
    }

     public class donkey : Animal
    {
        
    }

    public class showPoly
    {
        public void call(Animal a)
    {
       Console.WriteLine( a.speak());
    }
    }
    class program
    {
        static void Main(string[] args)
        {
            showPoly s=new showPoly();
            dog d=new dog();
            s.call(d);
            cat c=new cat();
            s.call(c);

            donkey d1=new donkey();
            s.call(d1);


            Animal a= new Animal();

            Console.ReadLine();
        }
    }
}
