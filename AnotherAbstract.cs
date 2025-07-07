// using System;
namespace Anothers
{
    public  abstract class ReadData
    {
        abstract public void Read();
    }
    public class DisplayData : ReadData
    {
        public int Radius;
        public void ReadRadius(int r)
        {
            Radius = r;
        }
        public override  void Read()
        {
            Console.WriteLine("the area of the circle is " + 3 * Radius * Radius);
        }
        static void Main()
        {
            DisplayData d1 = new DisplayData();
            d1.ReadRadius(3);
            d1.Read();
        }
    }
         

    }
