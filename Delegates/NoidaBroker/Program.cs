using System;
using NoidaBroker.Noida;
delegate int customer(); 
delegate string customer1();
namespace NoidaBroker
{
    class Program
    {
        static void Main()
        {
            var obj=new Broker();
            
            var obj1=new customer(obj.flat1);
            Console.WriteLine(obj1.Invoke());
            obj1+=obj.flat3;
            Console.WriteLine(obj1.Invoke());
            var obj2=new customer1(obj.flat2);
            Console.WriteLine(obj2.Invoke());

        }

    }
}
