using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
	public class EmployeeCar
	{
		public int EmployeeId { get; set; }
		public virtual Employee Employee { get; set; } = null!;

		public int CarId { get; set; }
		public virtual Car Car { get; set; } = null!;
	}
}
