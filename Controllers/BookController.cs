using System;
using PracticeOctober.Models;
using PracticeOctober.Services;

namespace PracticeOctober.Controllers
{


	public class BookController
	{
		private BookService _bookService;

		public BookController()
		{
			_bookService = new BookService();

			//BookService _bookService = new();
		}

		public void GetAllByAuthor()
		{
			string authorName = "Nizami";

			Book[] result = _bookService.GetAllByAuthor(authorName);

			foreach(var item in result)
			{
				Console.WriteLine($"{item.Name} - {item.Author}");
			}
		}

		public void GetById()
		{
			int id = 2;

			var result = _bookService.GetById(id);

			Console.WriteLine(result.Name + "-" + result.Author + "-" + result.PageCount);
        }

		public void Search()
		{
			var result = _bookService.SearchByName("t");

			foreach(var item in result)
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}

