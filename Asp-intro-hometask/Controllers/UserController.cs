using System;
using Asp_intro_hometask.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro_hometask.Controllers
{
    public class UserController : Controller
    {
        public IActionResult User()
        {
            var user = GetAllUsers();

            return View(user);
        }

        private List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id=1,
                    Fullname = "Semed Huseynov",
                    Address = "Ehmedli",
                    Email="semed@code.edu.az",
                    Age = 27
                },

                new User
                {
                    Id=2,
                    Fullname = "Tunzale Memmedova",
                    Address = "Nasimi",
                    Email="tuni@code.edu.az",
                    Age = 26
                },


                new User
                {
                    Id=3,
                    Fullname = "Aqshin Veliyev",
                    Address = "Ehmedli",
                    Email="aqshin@code.edu.az",
                    Age = 26
                },


                new User
                {
                    Id=4,
                    Fullname = "Ilham Abasli",
                    Address = "Lokbatan",
                    Email="ilham@code.edu.az",
                    Age = 20
                }
            };

        }
    }
}



