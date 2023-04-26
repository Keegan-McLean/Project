using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;


namespace Project
{
   
    /// <summary>
    /// 
    /// Handles All Reading
    /// 
    /// </summary>
    internal class Read : INotifyPropertyChanged
    {
        public List<Employee> Employees { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Department> Departments { get; set; }
        public List<Project> Projects { get; set; }
        public List<Team> Teams { get; set; }
        public List<TeamProject> TeamProjects { get; set; }

        public Read()
        {
            Employees = new List<Employee>() 
            {

            };
        }

        //ViewModel vm = new ViewModel();
        /// <summary>
        /// builder
        /// </summary>
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
        {
            Server = "127.0.0.1",
            UserID = "root",
            Password = "password",
            Database = "porject"
        };

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// grabs all employees
        /// 
        /// </summary>
        public void GrabAllEmployees()
        {
 

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "select * FROM employees";

            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                int employeeNum = reader.GetInt32(0);
                string Fname = reader.GetString(1);
                string Lname = reader.GetString(2);
                int TeamNum = reader.GetInt32(3);
                Employee em = new Employee(employeeNum, Fname, Lname, TeamNum);
                Employees.Add(em);
                //Console.WriteLine(employeeNum +" "+ Fname+" " + Lname +" "+ TeamNum);
            }
            Console.WriteLine("test");
            connection.Close();

        }
        /// <summary>
        /// grabs all managers
        /// </summary>
        public void GrabAllManagers()
        {


            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connected");
            string sql = "select * FROM managers";

            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                
                int managerNum = reader.GetInt32(0);
                string Fname = reader.GetString(1);
                string Lname = reader.GetString(2);
                int TeamNum = reader.GetInt32(3);
                Manager manager = new Manager(managerNum, Fname, Lname, TeamNum);
                Managers.Add(manager);
                
                Console.WriteLine(managerNum + Fname + Lname + TeamNum +"\n");
            }
            connection.Close();

        }

        /// <summary>
        /// grabs all projects
        /// </summary>
        public void GrabAllProjects()
        {

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connected");
            string sql = "select * FROM projects";

            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int projectNum = reader.GetInt32(0);
                string ProjectName = reader.GetString(1);
                string ProjectDesc = reader.GetString(2);
                
                Project project = new Project(projectNum, ProjectName, ProjectDesc);
                Projects.Add(project);
            }
            connection.Close();

        }
        /// <summary>
        ///  grabs all departments
        /// </summary>
        public void GrabAllDepartments()
        {


            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connected");
            string sql = "select * FROM departments";

            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int DeptNum = reader.GetInt32(0);
                string Deptname = reader.GetString(1);
                string DeptDesc = reader.GetString(2);
                Department dept = new Department(DeptNum, Deptname, DeptDesc);
                Departments.Add(dept);
            }
            connection.Close();

        }
        /// <summary>
        /// grabs all teams
        /// </summary>
        public void GrabAllTeams()
        {
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connected");
            string sql = "select * FROM teams";

            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int TeamNum = reader.GetInt32(0);
                int deptNum = reader.GetInt32(1);
                string teamName = reader.GetString(2);

                Team team = new Team(TeamNum, deptNum, teamName);
                Teams.Add(team);
            }
            connection.Close();

        }
        /// <summary>
        /// Grabs the bridging table
        /// </summary>
        public void GrabAllTeamProjectsBridge()
        {


            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connected");
            string sql = "select * FROM teamprojects";

            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int TeamNum = reader.GetInt32(0);
                int ProjectNum = reader.GetInt32(1);
                
                TeamProject tp = new TeamProject(TeamNum, ProjectNum);
                TeamProjects.Add(tp);
            }
            connection.Close();

        }
    }
}
