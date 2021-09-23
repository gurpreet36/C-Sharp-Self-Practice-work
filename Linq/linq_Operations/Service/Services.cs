using System;
using System.Linq;
using System.Collections.Generic;
using linq_Operations.Domains;

namespace linq_Operations.Service
{
    public class Services
    {
       public static List<Student> getAllStudent()
       {
           
        List<Student> listStudents = new List<Student>();

        Student student1 = new Student
        {
            ID = 101,
            Name = "Gurpreet Singh",
            Gender = "Male",
            Age=23
        };
        listStudents.Add(student1);

        Student student2 = new Student
        {
            ID = 103,
            Name = "Ram",
            Gender = "Male",
            Age=17
        };
        listStudents.Add(student2);

        Student student3 = new Student
        {
            ID = 104,
            Name = "John",
            Gender = "Male",
            Age=19
        };
        listStudents.Add(student3);

        Student student4 = new Student
        {
            ID = 105,
            Name = "Johny",
            Gender = "Female",
            Age=24
        };
        listStudents.Add(student4);
        return listStudents;
       } 
    }
}