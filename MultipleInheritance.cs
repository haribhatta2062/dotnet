namespace Multiple
{
    interface MultipleInheritance1
    {
        public void ReadName();
    }
    interface MultipleInheritance2
    {
        public void ReadAge();
        static void Main()
        {
            MultipleInheritance multipleInheritance = new MultipleInheritance();
            multipleInheritance.ReadName();
            multipleInheritance.ReadAge();
        }
    }
    class MultipleInheritance : MultipleInheritance1, MultipleInheritance2
    {
        public void ReadName()
        {
            Console.WriteLine("My name is harry bhatta");
        }
        public void ReadAge()
        {
            Console.WriteLine("my age is 21");
        }
    }
}