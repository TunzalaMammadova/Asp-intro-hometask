using System;
using Asp_intro_hometask.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro_hometask.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            var employees = GetAllEmployees();

            return View(employees);
        }

        private List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id=1,
                    Name = "Semed",
                    Surname = "Huseynov",
                    Salary=2000,
                    Age = 27
                },

                new Employee
                {
                    Id=2,
                    Name = "Tunzale",
                    Surname = "Memmedova",
                    Salary=1400,
                    Age = 26
                },


                new Employee
                {
                    Id=3,
                    Name = "Arzu",
                    Surname = "Kerimli",
                    Salary=1500,
                    Age = 26
                },


                new Employee
                {
                    Id=4,
                    Name = "Ilham",
                    Surname = "Abasli",
                    Salary=2000,
                    Age = 20
                }
            };

        }
    }
}


