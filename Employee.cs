using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp07112023
{
     public class Employee
     {
        public Employee()
        {

        }

        //Added comment
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Qualification { get; set; }
        public string Location { get; set; }

        private bool ValidateId(int Id)
        {
            bool result = false;
            if(Id > 0)
            {
                result = true;
            }
            return result;
        }

        private bool ValidateEmployeeName(string name)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(name) && name.Length <= 50)
            {
                result = true;
            }
            return result;
        }

        public bool ValidateEmployeeDetails(int id, string name)
        {
            //logic
            bool result = false;
            if(ValidateId(id) && ValidateEmployeeName(name))
            {
                result = true;
            }
            return result;
        }

        public virtual int CalculateSalary()
        {
            return 5000;
        }
    }
}
