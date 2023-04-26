using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Employee
    {
        public int EmployeeNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TeamNum { get; set; }

        public Employee(int employeeNum, string firstName, string lastName, int teamNum)
        {
            EmployeeNum = employeeNum;
            FirstName = firstName;
            LastName = lastName;
            TeamNum = teamNum;
        }
    }

}
