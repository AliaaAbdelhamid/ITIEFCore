using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
	internal class EmployeeProject
	{
		[Key]
		[ForeignKey(nameof(Employee))]
		public int EmployeeId { get; set; }

		[InverseProperty(nameof(Employee.EmployeeProject))]
		public Employee Employee { get; set; } = null!;

		public int ProjectId { get; set; }

		[InverseProperty(nameof(Project.ProjectEmployees))]
		public Project Project { get; set; } = null!;

	}
}
