using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Classes
{
    class Employee
    {
        //Getters and Setters
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Tax { get; set; }

        //Constructor
        public Employee(string _name, double _salary, double _tax)
        {
            Name = _name;
            Salary = _salary;
            Tax = _tax;


        }

        //Method Gross times Salary by 1 - tax /100 and it is returned so it can be displayed back to the user
        public double Gross()
        {

            return Salary * (1 - Tax / 100);

        }
    }
}
