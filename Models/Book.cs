using System;
namespace PracticeOctober.Models
{
	internal class Book : BaseEntity
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public int PageCount { get; set; }
	}
}

