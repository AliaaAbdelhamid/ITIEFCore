using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
	internal class Course
	{
		public int CourseId { get; set; }
		public string? CName { get; set; }

		[InverseProperty(nameof(StudentCourse.Course))]
		public ICollection<StudentCourse> CrStudents { get; set; } = new HashSet<StudentCourse>();
	}

}
