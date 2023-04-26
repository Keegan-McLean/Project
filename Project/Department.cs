using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Department
    {
        public int DeptNum { get; set; }
        public string DeptName { get; set; }
        public string DeptDesc { get; set; }

        public Department(int deptNum, string deptName, string deptDesc)
        {
            DeptNum = deptNum;
            DeptName = deptName;
            DeptDesc = deptDesc;
        }
    }
}
