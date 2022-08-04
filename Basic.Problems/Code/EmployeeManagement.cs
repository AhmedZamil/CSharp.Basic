using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Problems.Code
{
    public class EmployeeManagement
    {
        public Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            return employees.GroupBy(employee => employee.Company)
                            .Select(group => new { Company = group.Key, Ages = group.Select(employee => employee.Age) })
                            .OrderBy(obj => obj.Company)
                            .ToDictionary(obj => obj.Company, obj => (int)Math.Round(obj.Ages.Average())); ;
        }

        public Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            return employees.GroupBy(employee => employee.Company)
                            .OrderBy(group => group.Key)
                            .ToDictionary(group => group.Key, group => group.Count());
        }

        public Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            return employees.GroupBy(employee => employee.Company)
                .OrderBy(group => group.Key)
                .ToDictionary(group => group.Key, group => group.Where(emp => emp.Age == group.Max(employee => employee.Age)).First());

        }

    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Company { get; set; }
        public int Age { get; set; }

    }
}
