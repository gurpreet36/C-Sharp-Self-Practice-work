using System;
using PClass.Partial;

namespace PClass
{
    class Program
    {
        public static void Main()
        {
            Area area=new Area(25); 
            Console.WriteLine("Area of Square ="+area.squareArea());
            
        }
    }
}
