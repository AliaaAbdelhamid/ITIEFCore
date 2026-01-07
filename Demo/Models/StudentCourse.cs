using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
	internal class StudentCourse
	{
		public int Grade { get; set; }

		[InverseProperty(nameof(Student.StdCourses))]
		public Student Student { get; set; } = null!;

		[ForeignKey(nameof(Student))]
		public int StudentId { get; set; }


		[InverseProperty	(nameof(Course.CrStudents))]
		public Course Course { get; set; } = null!;
	
		[ForeignKey(nameof(Course))]
		public int CourseId { get; set; }
	}
}
