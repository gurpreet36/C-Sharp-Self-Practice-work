//Difference b/w Finalize Nad Dispose
using System;
using GarbageCollection.GarbageCollectionp;

namespace GarbageCollection
{
    class Program
    {
        public static void Main()
        { //We are defining the scope of an object using block.Achieves Explicit garbage collection
            using (IT iT=new IT())
            {
                iT.DatabaseConnect();//now the function is called ,got the value still resources are running so why not cleanup the resources after that 
                                     //this is where  the garbage collection comes into picture
            }//At this Point dispose function will be Called explicitely
            

            Console.WriteLine("End of the Program");                      

        }
    }
}
