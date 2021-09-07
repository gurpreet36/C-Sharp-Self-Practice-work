using System;
namespace GarbageCollection.GarbageCollectionp
{
    public class IT:IDisposable
    {
        public void DatabaseConnect() // To connect to database We need soo many resources

        {
            Console.WriteLine("Let me write a code to connect with database");

        }

        public void Dispose()
        {
             Console.WriteLine("Destructor is working!!!");
            
        }

        /* ~ IT()   //Finalize() act as a Destructor .
        {
            Console.WriteLine("Destructor is working!!!");
        } */
    }
}