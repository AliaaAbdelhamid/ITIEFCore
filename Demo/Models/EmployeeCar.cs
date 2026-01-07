using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
	internal class EmployeeCar
	{
		public int EmployeeId { get; set; }
		public Employee Employee { get; set; } = null!;

		public int CarId { get; set; }
		public Car Car { get; set; } = null!;
	}
}
