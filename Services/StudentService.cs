using System;
using PracticeOctober.Models;

namespace PracticeOctober
{
	internal class StudentService : BaseEntity
	{
		private Studnet[] GetAll()
		{
			Studnet stu1 = new()
			{
				name = "Semed",
				surname = "Huseynov",
				email = "Semed@gmail.com",
                id = 1,
                birthday = new(1996, 04, 20)
                
			};

            Studnet stu2 = new()
            {
                name = "Tunzale",
                surname = "Memmedov",
                email = "Tunzale@gmail.com",
                id = 2,
                birthday = new(1998, 08, 08)
            };

            Studnet stu3 = new()
            {
                name = "Ilham",
                surname = "Abasli",
                email = "ilham@gmail.com",
                id = 3,
                birthday = new(2003, 12, 05)
            };

          

            return new Studnet[] {stu1, stu2, stu3};
        }

        public Studnet[] ShowAllStudents(DateTime startDate, DateTime endDate)
        {
            Studnet[] studnets = GetAll();
            var result = studnets.Where(x => x.birthday > startDate && x.birthday < endDate).ToArray();
            return result;
        }

        public int GetStundetAgeById(int id)
        {
            Studnet[] studnets = GetAll();

            Studnet studnet = studnets.FirstOrDefault(m => m.id == id);

            int result = DateTime.Now.Year - studnet.birthday.Year;

            return result;
        }
	}
}

