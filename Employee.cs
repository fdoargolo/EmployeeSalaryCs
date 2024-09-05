using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class Employee
    {
        public string name  { get; set; }
        public int hours { get; set; }
        private double valuePerHour { get; set; }

        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            this.name = name;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }
        public double payment()
        {
            return hours * valuePerHour;
        }

        public override string ToString()
        {
            return name + " - " + payment();
        }
    }
}
