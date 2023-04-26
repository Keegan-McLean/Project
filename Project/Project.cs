using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Project
    {
        public int ProjectNum { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }

        public Project(int projectNum, string projectName, string projectDesc)
        {
            ProjectNum = projectNum;
            ProjectName = projectName;
            ProjectDesc = projectDesc;
        }
    }
}
