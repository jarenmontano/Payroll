namespace Employee
{
    public class Employee
    {
        private decimal pay;

        public string Name { get; set; }
        public int Number { get; set; }
        public decimal PayRate { get; set; }
        public int Hours { get; set; }

        public Employee()
        {
            Name = string.Empty;
            Number = 0;
            PayRate = 0;
            Hours = 0;

        }
        public Employee(string name, int num, decimal pay, int hrs)
        {
            Name=name;
            Number = num;
            PayRate = pay;
            Hours = hrs;
            SetPay();
        }

        private decimal SetPay()
        {
            decimal temp;
            if(Hours > 40)
            {
                temp = Hours - 40;
                temp = temp * ((decimal)PayRate * 1.5m);
                return (temp + (decimal)PayRate * 40m);
            }
            else
            {
                return ((decimal)PayRate * (decimal)Hours);
            }
        }


        public string EmployeeSaveToFile()
        {
            return Name + "," + Number + "," + SetPay();
        }
    }
}