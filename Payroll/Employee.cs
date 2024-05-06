using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    internal class Employee
    {
        private decimal pay;

        public string Name { get; set; }
        public string Number { get; set; }
        public decimal PayRate { get; set; }
        public decimal Hours { get; set; }

        public Employee()
        {
            Name = string.Empty;
            Number = string.Empty;
            PayRate = 0;
            Hours = 0M;

        }
        public Employee(string name, string num, decimal pay, decimal hrs)
        {
            Name = name;
            Number = num;
            PayRate = pay;
            Hours = hrs;
            SetPay();
        }

        private decimal SetPay()
        {
            decimal temp;
            if (Hours > 40)
            {
                temp = Hours - 40;
                temp = temp * ((decimal)PayRate * 1.5m);
                pay = (temp + (decimal)PayRate * 40m);
                return pay;
            }
            else
            {
                pay = ((decimal)PayRate * (decimal)Hours);
                return pay;
            }
        }


        public string EmployeeSaveToFile()
        {
            return Name + "?" + Number + "?" + SetPay().ToString("C");
        }

        public override string ToString()
        {
            return "Name: " + Name +"\n" +
                "Number: " + Number +"\n " +
                "Hours: " + Hours + "\n" + 
                "PayRate: " + PayRate + "\n" +
                "Pay: " + SetPay().ToString("C");
           
        }
    }
}
