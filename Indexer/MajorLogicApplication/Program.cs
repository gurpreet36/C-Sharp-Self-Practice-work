//______________________31/08/2021(Major topics)_______________________

// ______________________________________program for indexer
using System;

namespace MajorLogicApplication
{
    public class Employee
    {
       private object[] data=new object[2];//variable name is data and done indexing with 2 subscript. eg:- data[o]=101;data[1]="Gurpreet";
       
       //indexer is refered by this keyword
       
       public object this[int i] //this refered to employee object
       {
           get
           {
              return data[i]; 
           }
           set
           {
               data[i]=value;
           }
       }
    } 
    class Program
    {
        public static void Main()
        {
           Employee employee=new Employee();
           employee[0]=101; //set // data[0]=employee[0]; data[1]=employee[1];
           employee[1]="Gurpreet Singh"; //set

           Console.WriteLine(employee[0]+" "+employee[1]); //get
           
        }
    }
}
