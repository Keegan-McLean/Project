using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Handles adding and removing from the database
    /// </summary>
    internal class Write
    {
        
        /// <summary>
        /// Connection builder
        /// </summary>
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
        {
            Server = "127.0.0.1",
            UserID = "root",
            Password = "password",
            Database = "porject"
        };

        /// <summary>
        /// Writes to employee
        /// </summary>
        /// <param name="empnum"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="tname"></param>
        public void WriteToEmployees(int empnum, string fname, string lname, int tnum)
        {

            //int empnum = incrementEmpID();

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "INSERT INTO employees (employeeNum, Fname, Lname, TeamNum) VALUES (" + empnum+", '"+fname+"', '"+lname+"', "+tnum+");";

            MySqlCommand command = new MySqlCommand(sql, connection);
            
            command.ExecuteNonQuery();
            connection.Close();

        }
        /// <summary>
        /// writes to managers
        /// </summary>
        /// <param name="mannum"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="tname"></param>
        public void WriteToManagers(int mannum, string fname, string lname, int tnum)
        {
            //int mannum = incrementManID();
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "INSERT INTO managers (ManagerNum, fname, lname, teamNum) VALUES (" + mannum + ", '" + fname + "', '" + lname + "', " + tnum + ");";

            MySqlCommand command = new MySqlCommand(sql, connection);

            command.ExecuteNonQuery();
            connection.Close();

        }
        /// <summary>
        /// writes to projects
        /// </summary>
        /// <param name="pronum"></param>
        /// <param name="pname"></param>
        /// <param name="pdesc"></param>
        public void WriteToProjects(int pronum, string pname, string pdesc)
        {
            //int pronum = incrementProID();

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connected");
            string sql = "INSERT INTO projects (ProjectNum, ProjectName, ProjectDesc) VALUES (" + pronum + ", '" + pname + "', '" + pdesc + "');";

            MySqlCommand command = new MySqlCommand(sql, connection);

            command.ExecuteNonQuery();
            connection.Close();

        }

        /// <summary>
        /// writes to departments
        /// </summary>
        /// <param name="DeptNum"></param>
        /// <param name="DeptName"></param>
        /// <param name="DeptDesc"></param>
        public void WriteToDept(int DeptNum, string DeptName, string DeptDesc)
        {

            //int Deptnum = incrementDeptID();

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "INSERT INTO departments (DeptNum, DeptName, DeptDesc) VALUES (" + DeptNum+", '"+DeptName+"', '"+DeptDesc+"');";

            MySqlCommand command = new MySqlCommand(sql, connection);

            command.ExecuteNonQuery();
            connection.Close();

        }


        /// <summary>
        /// writes to teams
        /// </summary>
        /// <param name="teamNum"></param>
        /// <param name="deptNum"></param>
        /// <param name="teamName"></param>
        public void WriteToTeams(int teamNum, int deptNum, string teamName)
        {

            //int teamNum = incrementTeamID();

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            string sql = "INSERT INTO teams (TeamNum, DeptNum, TeamName) VALUES (" + teamNum + ", " + deptNum + ", '" + teamName + "');";

            MySqlCommand command = new MySqlCommand(sql, connection);

            command.ExecuteNonQuery();
            connection.Close();

        }


        /// <summary>
        /// writes to projects
        /// </summary>
        /// <param name="TeamNum"></param>
        /// <param name="ProjectNum"></param>
        public void WriteToTeamProjects(int TeamNum, int ProjectNum)
        {


            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "INSERT INTO teamprojects (TeamNum, ProjectNum) VALUES (" + TeamNum + ", " + ProjectNum + ");";

            MySqlCommand command = new MySqlCommand(sql, connection);

            command.ExecuteNonQuery();
            connection.Close();

        }
        public void removeFromEmployee(int id)
        {
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "DELETE from employees where employeeNum = " + id + ";";
            MySqlCommand command = new MySqlCommand( sql, connection);
            command.ExecuteNonQuery();
        }
        public void removeFromManager(int id)
        {
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "DELETE from managers where ManagerNum = " + id + ";";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
        public void removeFromDept(int id)
        {
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "DELETE from departments where DeptNum = " + id + ";";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
        public void removeFromProjects(int id)
        {
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "DELETE from projects where ProjectNum = " + id + ";";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
        public void removeFromTeams(int id)
        {
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "DELETE from teams where TeamNum = " + id + ";";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
