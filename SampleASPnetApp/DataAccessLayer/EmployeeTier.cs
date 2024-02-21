using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using SampleASPnetApp.DataModels;

namespace SampleASPnetApp.DataAccessLayer
{
    public class EmployeeTier
    {
        private string connectionString;

        public EmployeeTier()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
        }

        public List<Employee> getAllEmployees()
        {
            List<Employee> employeeList = null;     Employee employee;      string query;
            SqlConnection conn;     SqlCommand cmd;    SqlDataReader reader;

            query = "SELECT * FROM EmployeeInformation;";

            conn = new SqlConnection(connectionString);

            cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    employeeList = new List<Employee>();

                    while (reader.Read())
                    {
                        employee = new Employee();
                        employee.empID = (int)reader["EmployeeID"];
                        employee.fName = reader["FirstName"].ToString();
                        employee.lName = reader["LastName"].ToString();
                        employee.address = reader["Address"].ToString();
                        employee.address2 = reader["Address2"].ToString();
                        employee.city = reader["City"].ToString();
                        employee.state = reader["State"].ToString();
                        employee.zip = (int)reader["Zip"];

                        employeeList.Add(employee);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return employeeList;
        }

        public bool insertEmployee(Employee theEmployee)
        {
            SqlConnection conn;     SqlCommand cmd;     string query;
            bool success = false;   int rows;

            query = "INSERT into CustomerInformation (FirstName, LastName, Address, Address2, City, State, Zip) " +
                    "VALUES(@fName, @lName, @add1, @add2, @city, @state, @zip);";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@fName", SqlDbType.VarChar, 50).Value = theEmployee.fName;
            cmd.Parameters.Add("@lName", SqlDbType.VarChar, 50).Value = theEmployee.lName;
            cmd.Parameters.Add("@add1", SqlDbType.VarChar, 50).Value = theEmployee.address;
            cmd.Parameters.Add("@add2", SqlDbType.VarChar, 50).Value = theEmployee.address2;
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = theEmployee.city;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 50).Value = theEmployee.state;
            cmd.Parameters.Add("@zip", SqlDbType.Int).Value = theEmployee.zip;

            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    success = true;
                }
                
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }
    }
}