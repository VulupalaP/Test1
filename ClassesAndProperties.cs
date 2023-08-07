using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp07112023
{
    public class ClassesAndProperties
    {
        public ClassesAndProperties()
        {
            //Id = 1;
            //Name = "John";
            //Age = 20;
            //Location = "VA";
            //Qualification = "IT";

            Console.WriteLine("Constructor is called");
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine("Id is " + Id + "Name is " + Name);
        }


    }
}
