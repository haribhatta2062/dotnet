// interface in csharp
namespace LearnInterfaceApp
{
      interface LearnInterface
{
    public void Read();
}
    public class InterfaceApp : LearnInterface
    {
        public void Read()
        {
            Console.WriteLine("this is the example of Interface in c#");
        }
        public static void Main()
        {
            InterfaceApp interfaceApp = new InterfaceApp();
            interfaceApp.Read();
            
        }
}
 }