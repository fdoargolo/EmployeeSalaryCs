using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class OutSourcedEmployee : Employee 
    {
        private double additionalCharge { get; set; }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour) 
        {
            this.additionalCharge = additionalCharge; 
        }

        public override string ToString()
        {
            double paymantValue = payment();
            return name + " - " + (paymantValue + additionalCharge);
        }
    }
}
