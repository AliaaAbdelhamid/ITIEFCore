using Demo.DbContexts;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo.Data
{
	internal static class CompanyDbContextSeed
	{
		public static bool DataSeeding(CompanyDbContext dbContext)
		{

			try
			{
				if (dbContext.Employees.Any()) return false;

				var EmployeeData = File.ReadAllText("Files\\employees.json");
				if (string.IsNullOrWhiteSpace(EmployeeData)) return false;

				var Employees = JsonSerializer.Deserialize<List<Employee>>(EmployeeData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
				if (Employees is null || Employees.Count == 0) return false;

				dbContext.Employees.AddRange(Employees);
				return dbContext.SaveChanges() > 0;

			}
			catch
			{
				return false;
			}
		}
	}
}
