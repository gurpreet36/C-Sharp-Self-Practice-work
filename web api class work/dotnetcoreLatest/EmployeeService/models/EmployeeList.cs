using System;
using EmployeeService.models;
using System.Collections.Generic;

namespace EmployeeService.models
{
    public class EmployeeList
    {
        public List<Employee> employeeData()
        {
            List<Employee> obj=new List<Employee>();
            obj.Add(new Employee{emp_id=102,
            emp_name="Max"});
            obj.Add(new Employee{emp_id=103,
            emp_name="Ben"});
            obj.Add(new Employee{emp_id=104,
            emp_name="Maxy"});
            obj.Add(new Employee{emp_id=105,
            emp_name="beny"});
            return obj; 
        }
    }
}