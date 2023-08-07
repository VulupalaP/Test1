using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp07112023
{
    public class Polymorphism
    {

        public void Sum(int i, int j)
        {
            int result = i + j;
            Console.WriteLine("The result is " + result);
        }

        public void Sum(int i, int j, int k)
        {
            int result = i + j;
            Console.WriteLine("The result is " + result);
        }

        public void Sum(int i, double j)
        {
            double result = Convert.ToDouble(i) + j;
            Console.WriteLine("The result is " + result);
        }
       
    }
}
