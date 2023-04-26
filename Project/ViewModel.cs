using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ViewModel : INotifyPropertyChanged
    {
        public List<Employee> Employees { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Department> Departments { get; set; }
        public List<Project> Projects { get; set; }
        public List<Team> Teams { get; set; }
        public List<TeamProject> TeamProjects { get; set; }

        public ViewModel() 
        {
            Employees = new List<Employee>()
            {
                new Employee(1, "a", "b", 2),
                new Employee(2, "c", "d", 2),
                new Employee(3, "e", "f", 2)

            };
            Managers = new List<Manager>();
            Departments = new List<Department>();
            Projects = new List<Project>();
            Teams = new List<Team>();
            TeamProjects = new List<TeamProject>();

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
