using System;
using PracticeOctober.Models;

namespace PracticeOctober.Controllers
{
	public class StudentController
	{
        public void GetFilteredStudents()
        {
            DateTime startDate = new(1995, 01, 22);
            DateTime endDate = new(2000, 01, 01);
            StudentService studentService = new StudentService();
            Studnet[] studnets = studentService.ShowAllStudents(startDate, endDate);
            foreach (var studnet in studnets)
            {
                var result = $"{studnet.name} - {studnet.birthday.ToString("yyyy, mm, dd")}";
                Console.WriteLine(result);
            }
        }


        public void StudentAge()
        {
            StudentService service = new();
            Console.WriteLine(service.GetStundetAgeById(2));
        }
    }
}

