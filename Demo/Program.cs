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
			using CompanyDbContext dbContext = new CompanyDbContext();

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

			#region Loading Related Data

			#region Example 01
			//var Emp01 = dbContext.Employees.FirstOrDefault(E => E.EmpId == 20);

			//if (Emp01 is not null)
			//{
			//	Console.WriteLine($"Employee Name = {Emp01.EmpName}"); // Nadia
			//	Console.WriteLine($"Employee Department Id = {Emp01.DepartmentId}"); // 20
			//	Console.WriteLine($"Employee Department Name = {Emp01.EmployeeDepartment?.DeptName}"); // NULL

			//	var EmpDepartment = dbContext.Departments.FirstOrDefault(D => D.DeptId == Emp01.DepartmentId);
			//	Console.WriteLine($"Employee Department Name = {EmpDepartment?.DeptName}"); // HR

			//}
			#endregion

			#region Example 02

			//var Emp01 = dbContext.Employees.Select(E => new
			//{
			//	E.EmpId,
			//	E.EmpName,
			//	E.DepartmentId,
			//	E.EmployeeDepartment.DeptName
			//})
			//							   .FirstOrDefault(E => E.EmpId == 20);
			//// EF Core automatically generates the necessary JOIN in
			//// SQL when you project a navigation property inside .Select()

			//if (Emp01 is not null)
			//{
			//	Console.WriteLine($"Employee Name = {Emp01.EmpName}"); // Nadia
			//	Console.WriteLine($"Employee Department Id = {Emp01.DepartmentId}"); // 50
			//	Console.WriteLine($"Employee Department Name = {Emp01.DeptName}"); // HR
			//}

			#endregion

			#region Eager Loading 

			#region Example 01
			//var Emp01 = dbContext.Employees.Include(E => E.EmployeeDepartment)
			//							   .FirstOrDefault(E => E.EmpId == 20);

			//if (Emp01 is not null)
			//{
			//	Console.WriteLine($"Employee Name = {Emp01.EmpName}"); // Sama
			//	Console.WriteLine($"Employee Department Id = {Emp01.DepartmentId}"); // 20
			//	Console.WriteLine($"Employee Department Name = {Emp01.EmployeeDepartment?.DeptName}"); // HR
			//	Console.WriteLine($"Employee Department Name = {Emp01.EmployeeDepartment?.DateOfCreation}"); // 10/30/2025 12:00:00 AM
			//}
			#endregion

			#region Example 02

			//var Student = dbContext.Students.Include(S => S.StdCourses)
			//	                            .ThenInclude(SC => SC.Course)
			//								.FirstOrDefault(S => S.StudentId == 1);


			//if(Student  is not null)
			//{
			//	Console.WriteLine($"Student Id : {Student.StudentId}"); //1 
			//	Console.WriteLine($"Student Name : {Student.SName}"); // Aliaa
			//	Console.WriteLine("Student Courses : ");
			//	foreach(var course in Student.StdCourses)
			//	{
			//		Console.WriteLine("Course Details :");
			//		Console.WriteLine($"Course Id: {course.CourseId}");
			//		Console.WriteLine($"Course Name : {course.Course?.CName}");
			//		Console.WriteLine($"Course Grade : {course.Grade}");
			//		Console.WriteLine("=====================");
			//	}	
			//}


			#endregion

			#endregion

			#region Explicit Loading 

			#region Example 01
			//var Employee = dbContext.Employees.FirstOrDefault(E => E.EmpId == 20);
			//if(Employee is not null)
			//{
			//	Console.WriteLine($"Employee Name :{Employee.EmpName}"); // Sama 
			//	Console.WriteLine($"Department Id : {Employee.DepartmentId}"); //20

			//	dbContext.Entry(Employee).Reference(E => E.EmployeeDepartment).Load();
			//	Console.WriteLine($"Department Name : {Employee.EmployeeDepartment?.DeptName}"); // HR
			//} 
			#endregion

			#region Example 02


			//var Department = dbContext.Departments.FirstOrDefault(E => E.DeptId == 20);
			//if(Department is not null)
			//{
			//	Console.WriteLine($"Department Id : {Department.DeptId}"); // 20
			//	Console.WriteLine($"Department Name : {Department.DeptName}"); // HR

			//	dbContext.Entry(Department).Collection(D => D.Employees)
			//		                             .Query().Where(E=>E.Age > 27).Load();
			//	foreach (var employee in Department.Employees)
			//	{
			//		Console.WriteLine($"{employee.EmpName}");
			//	}
			//}

			#endregion

			#endregion

			#region Lazy Loading 
			//var Emp01 = dbContext.Employees.FirstOrDefault(e => e.EmpId == 20);


			//if (Emp01 is not null)
			//{
			//	Console.WriteLine($"Employee Name = {Emp01.EmpName}"); // Sama
			//	Console.WriteLine($"Employee Department Id = {Emp01.DepartmentId}"); // 20
			//	Console.WriteLine($"Employee Department Name = {Emp01.EmployeeDepartment?.DeptName}"); // HR
			//}
			#endregion

			#endregion

			#region Local and Find()

			#region Example 01
			//var Emp01 = dbContext.Employees.FirstOrDefault(X => X.EmpId == 10); // Send Request To Database

			//if (Emp01 is not null)
			//{
			//	Console.WriteLine($"Employee Name = {Emp01.EmpName}"); // Sama
			//	Console.WriteLine($"Employee Name = {Emp01.Email}");   // Sama@gmail.com
			//	Console.WriteLine($"Employee Department Id = {Emp01.DepartmentId}"); // 20
			//}


			//var Employee01 = dbContext.Employees.Local.FirstOrDefault(X => X.EmpId == 10); // Get Data From local Without Hitting Database

			#endregion

			#region Example 02 

			//var Employee01 = dbContext.Employees.FirstOrDefault(X => X.EmpId == 10); // Send Request To Database
			//var Employee02 = dbContext.Employees.FirstOrDefault(X => X.EmpId == 20); // Send Request To Database
			//var Employee03 = dbContext.Employees.FirstOrDefault(X => X.EmpId == 30); // Send Request To Database
			//var Employee04 = dbContext.Employees.FirstOrDefault(X => X.EmpId == 40); // Send Request To Database



			//dbContext.Employees.Load(); // Load All Employees Into Local Cache

			//Employee01 = dbContext.Employees.Local.FirstOrDefault(X => X.EmpId == 10); // Get Data From local Without Hitting Database
			//Employee02 = dbContext.Employees.Local.FirstOrDefault(X => X.EmpId == 20); // Get Data From local Without Hitting Database
			//Employee03 = dbContext.Employees.Local.FirstOrDefault(X => X.EmpId == 30); // Get Data From local Without Hitting Database
			//Employee04 = dbContext.Employees.Local.FirstOrDefault(X => X.EmpId == 40); // Get Data From local Without Hitting Database

			#endregion

			#region Example 03

			//var employee01 = dbContext.Employees.FirstOrDefault(X => X.EmpName == "Nadia");
			//// Send Request To Database and load employee with EmpName = "Nadia" into memory 



			//var employee02 = dbContext.Employees.Find(20); // Search In Local Cache First , If Not Found Send Request To Database
			//											   // Retrieve employee with EmpId = 20 from local cache 

			//var employee03 = dbContext.Employees.Find(30); // Search In Local Cache First , If Not Found Send Request To Database
			//											   // Retrieve employee with EmpId = 30 from database and load into memory

			#endregion

			#endregion
		}
	}
}
