namespace LearnBaseclass
{
    public class LearnBase
    {
        public LearnBase()
        {
            Console.WriteLine("this is the constructor with no parameter");
        }
        public LearnBase(string name)
        {
            Console.WriteLine("my name is " + name);
        }
    }
    public class chilldClass : LearnBase {
        public chilldClass() :base() {
            Console.WriteLine("constructor called");
        }
    
    
        static void Main()
        {
            chilldClass chilldClass = new chilldClass();

         }
    }  
    }
