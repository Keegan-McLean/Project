using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Manager
    {
        public int ManagerNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TeamNum { get; set; }

        public Manager(int managerNum, string firstName, string lastName, int teamNum)
        {
            ManagerNum = managerNum;
            FirstName = firstName;
            LastName = lastName;
            TeamNum = teamNum;
        }
    }
}
