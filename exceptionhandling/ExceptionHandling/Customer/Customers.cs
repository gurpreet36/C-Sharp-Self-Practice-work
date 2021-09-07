using System;
namespace ExceptionHandling.Customer
{
    public class Customers
    {
        int rarea;
        public Customers()
        {
            rarea=0;
        }
        //exception class in c# is exception handling which can handled all the exceptions
        // airthemetic exeception is a base class of dividebyzero exception that is why base class exception can handle derived class  exception.
        public void data(int side,int Tarea)
        {
            /* try
            {int x=10,y=0,z;
            z=x/y;//at this point throw divideby0 exception// at this point throw will internally called when throw will be called then it will find suitable catch
            Console.WriteLine(z);
            }
            /* catch(ArithmeticException)
            {
                Console.WriteLine("yes your exception is handled  and flow of program is maintained");
            } */
            /* catch(DivideByZeroException)
            {
                Console.WriteLine("yes your exception is handled  and flow of program is maintained");
            } */
           /*  catch(Exception)
            {
                Console.WriteLine("yes your exception is handled  and flow of program is maintained");
            }  */

            try
            {
            int area=side*side;
            rarea=Tarea/area;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Area can be negative "+e);
            }
            finally
            {
                Console.WriteLine(" Remaining Area "+rarea+"sq.meter");
            }
        }
    }
}