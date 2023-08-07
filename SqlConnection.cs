using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp07112023
{
    public class DBConnection
    {
        public Employee SqlDBConnection()
        {
            Employee emp = new Employee();
            //Create the connection object
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeConn"].ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
               
                //Pass the connection to the command object, so the command object knows on which connection to execute the command
                SqlCommand cmd = new SqlCommand("Select * from Employee", con);

                //Open the connection. Otherwise you get a runtime error, an open connection is required to esecute the command.
                con.Open();

                //Execute the command
                using (SqlDataReader sqlReader = cmd.ExecuteReader())
                {
                    if (sqlReader.Read())
                    {
                        emp.Id = Convert.ToInt32(sqlReader["Id"]);
                        emp.Name = sqlReader["Name"].ToString();
                        emp.Age = Convert.ToInt32(sqlReader["Age"]);
                        emp.Qualification = sqlReader["Qualification"].ToString();
                        emp.Location = sqlReader["Location"].ToString();
                    }
                    
                }
            }
            // Close the connection.

            return emp;

        }
    }
}
