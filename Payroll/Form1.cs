using System.Diagnostics;

namespace Payroll
{
    public partial class Form1 : Form
    {
        private Employee newEmployee;
        private StreamWriter fil;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            newEmployee = new Employee();

           
        }

        private void BTNxSubmit_Click(object sender, EventArgs e)
        {

            newEmployee.Name = TBxName.Text;

            try
            {
                newEmployee.Number = TBxNumber.Text;
                newEmployee.Hours = decimal.Parse(TBxHours.Text);
                newEmployee.PayRate = decimal.Parse(TBxPayRate.Text);

                StoreDataInFile(newEmployee);
                MessageBox.Show(newEmployee.ToString(), "Employee");
                ClearForm();

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Method\'s actual argument does not match formal parameter." +
                               "\nException: " + ex.Message);
                lblErrors.Text += "\nException: " + ex.Message;

            }
            catch (ArithmeticException ex)
            {
                Debug.WriteLine("Errors in an arithmetic, casting, or conversion." +
                                "\nException: " + ex.Message);
                lblErrors.Text += "\nException: " + ex.Message;

            }
            catch (Exception ex)
            {
                lblErrors.Text += "\nException: " + ex.Message;
                Console.WriteLine("Exception: " + ex.Message);
            }


        }


        private void StoreDataInFile(Employee employee)
        {
            try
            {
                fil.WriteLineAsync(employee.EmployeeSaveToFile());
            }
            catch (DirectoryNotFoundException exc)
            {
                lblErrors.Text = "Invalid directory"
                        + exc.Message;
            }
            catch (InvalidDataException exc)
            {
                lblErrors.Text = "Invalid format in data stream"
                        + exc.Message;
            }
            catch (System.IO.IOException exc)
            {
                lblErrors.Text = exc.Message;
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fil.Close();
            }
            catch (IOException exc)  // Note: it is not necessary to fully quality
            {
                lblErrors.Text = exc.Message;
            }
        }


        private void ClearForm()
        {
            TBxName.Text = string.Empty;
            TBxHours.Text = string.Empty;
            TBxNumber.Text = string.Empty;
            TBxPayRate.Text = string.Empty;
            TBxName.Focus();
        }

        private void tpPayroll_Enter(object sender, EventArgs e)
        {
            String line;
            string[] temp;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\Jaren\\source\\repos\\Payroll\\Payroll\\bin\\Debug\\net7.0-windows\\Payroll.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        temp = line.Split("?");

                        RTBxPayroll.AppendText("Name: " + temp[0] + " Total Pay: " + temp[2] + "\n");
                    }

                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

        private void TPxEmployee_Leave(object sender, EventArgs e)
        {
            try
            {
                fil.Close();
            }
            catch (IOException exc)  // Note: it is not necessary to fully quality
            {
                lblErrors.Text = exc.Message;
            }
        }

        private void TPxEmployee_Enter(object sender, EventArgs e)
        {
            try
            {
                //
                //// To append data onto the end of the file,
                //// as opposed to creating a new file, 
                //// add true as the 2nd argument
                if (File.Exists("Payroll.txt")) {
                    fil = new StreamWriter("Payroll.txt", true);
                }
                else
                {
                    fil = new StreamWriter("Payroll.txt");
                }
                
            }
            catch (DirectoryNotFoundException exc)
            {
                lblErrors.Text = "Invalid directory"
                        + exc.Message;
            }
            catch (System.IO.IOException exc)
            {
                lblErrors.Text = exc.Message;
            }

            RTBxPayroll.ResetText();
        }
    }
}


