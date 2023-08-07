using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp07112023
{
    public class Program 
    {
        static void Main(string[] args)
        {

            //Polymorphism

            Polymorphism pl = new Polymorphism();
            pl.Sum(1, 2);
            pl.Sum(1, 2.2);
            pl.Sum(1, 2, 3);

            Console.ReadLine();
            
            
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "John";
            emp.ValidateEmployeeDetails(emp.Id, emp.Name);
            PTE pte = new PTE();
            FTE fte = new FTE();

            int empSalary = emp.CalculateSalary();
            int pteSalary = pte.CalculateSalary();
            int fteSalary = fte.CalculateSalary();

            Console.WriteLine(empSalary +" " +pteSalary +" " +fteSalary);
            Console.ReadLine();




            //DBConnection dBConnection = new DBConnection();
            //emp = dBConnection.SqlDBConnection();
            //Console.WriteLine("Id is" + emp.Id);
            //Console.WriteLine("Name is" + emp.Name);
            //Console.WriteLine("Age is" + emp.Age);
            //Console.WriteLine("Qualification is" + emp.Qualification);
            //Console.WriteLine("Location is" + emp.Location);

            //Console.ReadLine();

            //ClassesAndProperties cap = new ClassesAndProperties();
            //cap.Id = 1;
            //cap.Name = "John";
            //cap.Age = 20;
            //cap.Location = "VA";
            //cap.Qualification = "IT";
            //cap.PrintDetails();

            Console.WriteLine("Please enter the number1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultSum = AddNumbers(num1, num2);
            Console.WriteLine("Sum of the numbers is : " + resultSum);
            PrintEvenNumbers(100);
            PrintOddNumbers(100);
            Console.ReadLine();

            //print even numbers


        }

        public static int AddNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        public static void PrintEvenNumbers(int evenNum)
        {
            for(int i = 0; i <= evenNum; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintOddNumbers(int oddNum)
        {
            for (int i = 0; i <= oddNum; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    public class PTE : Employee
    {
        public int HourlyRate { get; set; }

        public override int CalculateSalary()
        {
            return 160 * 50;
        }
    }

    public class FTE : Employee
    {
        public int AnnualIncome { get; set; }

        public override int CalculateSalary()
        {
            return 1000000;
        }
    }


}
