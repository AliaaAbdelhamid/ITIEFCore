using Demo.Data;
using Demo.DbContexts;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Many To Many Relationship
			//CompanyDbContext dbContext = new CompanyDbContext();

			//dbContext.Students.Add(new Student()
			//{
			//	SName = "Aliaa"
			//});


			//dbContext.Courses.AddRange(
			//	new Course() { CName = "OOP" },
			//	new Course() { CName = "C#" },
			//	new Course() { CName = "EF Core" });

			//dbContext.SaveChanges();


			//var Course02 = dbContext.Courses.FirstOrDefault(C => C.CourseId == 2);
			//var Course03 = dbContext.Courses.FirstOrDefault(C => C.CourseId == 3);
			//var Student = dbContext.Students.FirstOrDefault(S => S.StudentId == 1);

			//if (Course02 is not null  && Student is not null)
			//{
			//	Student.StdCourses.Add(new StudentCourse()
			//	{
			//		Student = Student,
			//		Course = Course02,
			//		Grade = 100
			//	});
			//}

			//if (Course03 is not null && Student is not null)
			//{
			//	Student.StdCourses.Add(new StudentCourse()
			//	{
			//		Student = Student,
			//		Course = Course03,
			//		Grade = 60
			//	});
			//}
			//dbContext.SaveChanges(); 
			#endregion

			#region Data Seeding 

			#region Manual Data Seeding 

			//CompanyDbContext dbContext = new CompanyDbContext();
			//var Project01 = new Project() { PName = "P01" };
			//var Project02 = new Project() { PName = "P02" };
			//var Project03 = new Project() { PName = "P03" };

			//dbContext.Set<Project>().AddRange(Project01, Project02, Project03);
			//dbContext.SaveChanges();

			#endregion

			#region Dynamic Data Seeding 

			//using CompanyDbContext dbContext = new CompanyDbContext();

			//bool DataSeeded = CompanyDbContextSeed.DataSeeding(dbContext);
			//if (DataSeeded)
			//	Console.WriteLine("Data Seeded Successfully");
			//else
			//	Console.WriteLine("No Data Has Been Seeded");

			#endregion

			#endregion

		}
	}
}
