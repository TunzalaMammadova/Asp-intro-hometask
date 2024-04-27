using System;
using Asp_intro_hometask.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro_hometask.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            var product = GetAllProducts();

            return View(product);
        }

        private List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id=1,
                    Name = "Iphone15",
                    Price = 2750,
                    Count=17,
                    Description = "Phone"
                },

                new Product
                {
                    Id=2,
                    Name = "Lenovo",
                    Price = 2000,
                    Count=14,
                    Description = "Notebook"
                },


                new Product
                {
                    Id=3,
                    Name = "Galaxy S ultra",
                    Price = 2860,
                    Count=6,
                    Description = "Samsung"
                },


                new Product
                {
                    Id=4,
                    Name = "Macbook",
                    Price = 3550,
                    Count=17,
                    Description = "Notebook"
                }
            };

        }
    }
}




