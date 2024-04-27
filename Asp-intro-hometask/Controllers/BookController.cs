using System;
using Asp_intro_hometask.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro_hometask.Controllers
{
	public class BookController : Controller
	{
		public IActionResult Book()
		{
			var books = GetAllBooks();

			return View(books);
		}

		private List<Book> GetAllBooks()
		{
			return new List<Book>
			{
				new Book
				{
					Id=1,
					Name = "Yeddi gozel"
				},

				new Book
				{
					Id=2,
					Name = "Xosrov sirin"
				},


				new Book
				{
					Id=3,
					Name = "Ovod"
				},


                new Book
                {
                    Id=4,
                    Name = "Anna Karenina"
                }
            };

        }
	}
}

