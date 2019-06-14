using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            Console.WriteLine("Enter employee name here");
            string name = Console.ReadLine(); //declares the string name that the user enters

            Console.WriteLine("Enter your gross salary");
            double salary = double.Parse(Console.ReadLine()); //declares the double salary as what the user enters.

            Console.WriteLine("Enter your tax rate"); //declares the double tax as what the user enters.
            double tax = double.Parse(Console.ReadLine());




            Employee p1 = new Employee(name, salary, tax); //Creates the Employee object using the string name, the double salary and the double tax.


            Console.WriteLine($"{p1.Name}'s gross income is {p1.Gross()}"); //Shows the user their gross income.
            Console.ReadLine();
        }
    }
}
