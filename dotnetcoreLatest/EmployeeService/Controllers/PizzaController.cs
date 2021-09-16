using System;
using System.Collections.Generic;
using EmployeeService.models;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeService.Controllers

{
     [Route("[controller]")]
    public class PizzaController:ControllerBase
    {
        

        [HttpGet]
         public string msg()
        {
            return "Pizza";
        }

        [HttpGet("water")]
       
        public string pizzaboy()
        {return "waterboy";}

        [HttpGet("properties")]
        public Employee data()
        {
            Employee employee=new Employee();
            employee.emp_id=101;
            employee.emp_name="Gurpreetn Singh";
            return employee;
        }
         [HttpGet("listdata")]
         public List<Employee> list_data()
         {
             EmployeeList lobj=new EmployeeList();
             return lobj.employeeData();


         }


    }
}