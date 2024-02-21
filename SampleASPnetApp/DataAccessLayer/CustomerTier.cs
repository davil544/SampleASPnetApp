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
    public class CustomerTier
    {
        private string connectionString;

        public CustomerTier()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
            //ConfigurationManager used to pull from Web.config
        }

        /// <summary>
        /// This is a method that will return all customers from the CustomerInformation table.
        /// </summary>
        /// <returns>Returns a list of Customer Type.</returns>
        public List<Customer> getAllCustomers()
        {
            List<Customer> customerList = null;     Customer customer;      string query;
            SqlConnection conn;    SqlCommand cmd;  SqlDataReader reader;   //declaring variables

            query = "SELECT * FROM CustomerInformation;";
            //End SQL command with semicolons, helps prevent against injection attacks.
            //Never concatinate with queries either.

            conn = new SqlConnection(connectionString);
            //Creating new instance of connection, won't work without connectionString configured.

            cmd = new SqlCommand(query, conn);
            //In order to use, attributes must be created as objects.

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                //Reader will contain rows of data, test for it.
                if (reader.HasRows)
                {
                    customerList = new List<Customer>();

                    //read first row of data from list
                    while (reader.Read())
                    {
                        customer = new Customer();
                        customer.custID = (int)reader["CustomerID"];
                        customer.fName = reader["FirstName"].ToString();
                        customer.mName = reader["MiddleName"].ToString();
                        customer.lName = reader["LastName"].ToString();
                        customer.address = reader["Address"].ToString();
                        customer.address2 = reader["Address2"].ToString();
                        customer.city = reader["City"].ToString();
                        customer.state = reader["State"].ToString();
                        customer.zip = (int)reader["Zip"];

                        customerList.Add(customer);
                        //Model neatly wraps up data into an object.

                    }
                }
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally  //Used for cleanup, closing connection, memory management, garbage collection, etc.
            {
                conn.Close();
            }
            //Try / Catch / Finally Exeption handling,  use when code may fail upon executing (ex: If the server is offline the code will fail.)
            //This tells the code what to do if an error occurs  
            return customerList;
        }
        /// <summary>
        /// (Hello Class)
        /// This method inserts one customer into the CustomerInformation table.
        /// </summary>
        /// <param name="theCustomer">The customer info as a Customer type.
        /// (See comments in the class)</param>
        /// <returns>Returns true on success.</returns>
        public bool insertCustomer(Customer theCustomer)
        {
            SqlConnection conn;     SqlCommand cmd;     string query;
            bool success = false;   int rows;   //used to store returned value(s)              

            //Do not concatenate values directly from form, leaves vulnerable to SQL Injection.  Scrub it first.
            query = "INSERT into CustomerInformation (FirstName, MiddleName, LastName, Address, Address2, City, State, Zip) " +
                    "VALUES(@fName, @mName, @lName, @add1, @add2, @city, @state, @zip);";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);
            //cmd object scrubs the input in following lines

            cmd.Parameters.Add("@fName", SqlDbType.VarChar, 50).Value = theCustomer.fName;
            cmd.Parameters.Add("@mName", SqlDbType.VarChar, 50).Value = theCustomer.mName;
            cmd.Parameters.Add("@lName", SqlDbType.VarChar, 50).Value = theCustomer.lName;
            cmd.Parameters.Add("@add1", SqlDbType.VarChar, 50).Value = theCustomer.address;
            cmd.Parameters.Add("@add2", SqlDbType.VarChar, 50).Value = theCustomer.address2;
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = theCustomer.city;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 50).Value = theCustomer.state;
            cmd.Parameters.Add("@zip", SqlDbType.Int).Value = theCustomer.zip;

            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery(); //returns a number of rows affected.
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