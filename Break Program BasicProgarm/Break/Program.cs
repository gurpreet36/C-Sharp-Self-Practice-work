using System;

namespace Break
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x;
            while(true)
            {
                Console.WriteLine("enter the value of x : ");
                x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("value of x ="+x);
                if((x % 5)==0)
                {
                    break;
                }
            }
            Console.WriteLine("Bye....");
        }
    }
}
