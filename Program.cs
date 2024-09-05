using System;
using System.Collections.Generic;
using EmployeeProject;
using System.Xml.Linq;

namespace program
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number os employees: ");
            int numberEmployees = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numberEmployees; i++)
            {
                Console.WriteLine($"Employee {i + 1}");
                Console.WriteLine("Outsourced (y/n)");
                char answer = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter the employee name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the worked hours");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine());


                if (answer == 'y')
                {
                    Console.WriteLine("Additional Charge: ");
                    double addCharge = double.Parse(Console.ReadLine());

                    Employee employee = new OutSourcedEmployee(name, hours, valuePerHour, addCharge);
                    employees.Add(employee);
                }
                else if (answer == 'n')
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }
                else
                {
                    throw new Exception("Invalid Answer");
                }


            }

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}