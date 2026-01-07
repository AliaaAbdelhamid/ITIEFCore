using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
	internal class Student
	{
		public int StudentId { get; set; }
		public string? SName { get; set; }

		[InverseProperty(nameof(StudentCourse.Student))]
		public ICollection<StudentCourse> StdCourses { get; set; } = new HashSet<StudentCourse>();
	}
}
