using System;
using System.Collections;
 
namespace hashtablepractice
{
    class Program
    {
        static void Main()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1,"Karan");
            hashtable.Add(2,"Das");
            hashtable.Add(3,"Rahul");
            hashtable.Add(4,"Gurpreet");
 
 
            bool search(int a)
            {
                if(hashtable.Contains(a))
                    return true;
                else
                    return false;
            }
 
            Console.WriteLine(search(2));
 
        }
    }
}