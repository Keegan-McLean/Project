using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class TeamProject
    {
        public int TeamNum { get; set; }
        public int ProjectNum { get; set; }

        public TeamProject(int teamNum, int projectNum)
        {
            TeamNum = teamNum;
            ProjectNum = projectNum;
        }
    }
}
