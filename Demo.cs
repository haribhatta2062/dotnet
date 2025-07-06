
// example of inheritnace 
// using system;
namespace Demo
{
    public class BaseClass
    {
        public int age;
        public string fullName;
    }
    class ChildClass1 : BaseClass
    {
       public void ShowData()
        {
            Console.WriteLine($"my name is {fullName} and my age is{age}");
        }
    }
}