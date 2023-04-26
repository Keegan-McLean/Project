using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Team
    {
        public int TeamNum { get; set; }
        public int DeptNum { get; set; }
        public string TeamName { get; set; }

        public Team(int teamNum, int deptNum, string teamName)
        {
            TeamNum = teamNum;
            DeptNum = deptNum;
            TeamName = teamName;
        }
    }
}
