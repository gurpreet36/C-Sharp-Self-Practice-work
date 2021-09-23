using System;
using System.Linq;
using System.Collections.Generic;
using linq_Operations.Domains;
using linq_Operations.Service;

namespace linq_Operations
{
    public class Program
    {
        public static void Main()
        {
            //________________________________(Filter Operator)________________________________________
            // __________________________________________________________________using lamda method
            IEnumerable<Student> students;
            students=Services.getAllStudent();
            var result=students.Where(student => student.Age>18);
            var result1=students.Where(student => student.Age>1);
            var length= result.Count();
            Console.WriteLine(length+" Record Found");
            //___________________________________________________________________ using Expressions
            IEnumerable<Student> studentss = from services in Services.getAllStudent()
                                                           where services.Gender == "Male"
                                                           select services;
            var length1=studentss.Count();
            Console.WriteLine(length1+ " Record Found");
            //______________________________(Aggregate functions)________________________________________________________
            /* var b=Services.getAllStudent();
            int[] age={};
            List<int> im=new List<int>();
            foreach(var i in b)
            {
                im.Add(i.Age);
            } */
            //using lamda Function
           var minAge = result1.Min( s=>s.Age);  
            Console.WriteLine("Min age :-"+minAge);
            //________________________________________________________
            var maxAge = result1.Max( s=>s.Age);  
            Console.WriteLine("Max age :-"+maxAge);
            //______________________________________________________
            var avgAge = result1.Average( s=>s.Age);  
            Console.WriteLine("Avg age :-"+avgAge);
            //_________________________________________________________
            var Countdata = result1.Count();  
            Console.WriteLine("Total data :-"+Countdata);
//__________________________(Projection Operation)____________________________________________________________
            //using expression
              var res = from e in result1
                      select e.Name;
  
        foreach(var val in res)
        {
            Console.WriteLine("Employee Name: {0}", val);
        }
//_______________________________________(Concatination)___________________________________________________________________
        //usinhg lamda method
         var concatT = result1.Aggregate((s1, s2) => s1.Name + ", " + s2.Gender);  
            Console.WriteLine("Aggregate : " + concatT); 
        }
    }
}