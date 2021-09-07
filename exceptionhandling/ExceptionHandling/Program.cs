using System;
using ExceptionHandling.Customer;

namespace ExceptionHandling
{
    class Program
    {
       public static void Main()
        {
         var customers=new Customers();
         customers.data(2,100);
        }
    }
}
