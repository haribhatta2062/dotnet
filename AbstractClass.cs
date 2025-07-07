// using System;
namespace LearnAbstractClass
{
    public abstract class LearnAbstract
    {
        // static void Main()
        // {
        //     AbstractChild child1 = new AbstractChild();
        //     child1.Read();
        //     child1.WithBody();
        // }
        public abstract void Read();
        public  void WithBody()
        {
            Console.WriteLine("this is the another method in abstract class with body");
        }
    }
    public class AbstractChild : LearnAbstract
    {
        public override void Read()
        {
            Console.WriteLine("this the is the abstract class at child class");
        }
     }
    }
