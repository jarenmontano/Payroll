namespace Payroll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            TPxEmployee = new TabPage();
            lblErrors = new Label();
            BTNxSubmit = new Button();
            TBxHours = new TextBox();
            TBxPayRate = new TextBox();
            TBxNumber = new TextBox();
            TBxName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tpPayroll = new TabPage();
            label1 = new Label();
            RTBxPayroll = new RichTextBox();
            tabControl1.SuspendLayout();
            TPxEmployee.SuspendLayout();
            tpPayroll.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TPxEmployee);
            tabControl1.Controls.Add(tpPayroll);
            tabControl1.Location = new Point(12, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 432);
            tabControl1.TabIndex = 0;
            // 
            // TPxEmployee
            // 
            TPxEmployee.Controls.Add(lblErrors);
            TPxEmployee.Controls.Add(BTNxSubmit);
            TPxEmployee.Controls.Add(TBxHours);
            TPxEmployee.Controls.Add(TBxPayRate);
            TPxEmployee.Controls.Add(TBxNumber);
            TPxEmployee.Controls.Add(TBxName);
            TPxEmployee.Controls.Add(label5);
            TPxEmployee.Controls.Add(label4);
            TPxEmployee.Controls.Add(label3);
            TPxEmployee.Controls.Add(label2);
            TPxEmployee.Location = new Point(4, 24);
            TPxEmployee.Name = "TPxEmployee";
            TPxEmployee.Padding = new Padding(3);
            TPxEmployee.Size = new Size(768, 404);
            TPxEmployee.TabIndex = 0;
            TPxEmployee.Text = "Employee";
            TPxEmployee.UseVisualStyleBackColor = true;
            TPxEmployee.Enter += TPxEmployee_Enter;
            TPxEmployee.Leave += TPxEmployee_Leave;
            // 
            // lblErrors
            // 
            lblErrors.AutoSize = true;
            lblErrors.Location = new Point(492, 85);
            lblErrors.Name = "lblErrors";
            lblErrors.Size = new Size(43, 15);
            lblErrors.TabIndex = 9;
            lblErrors.Text = "Errors: ";
            // 
            // BTNxSubmit
            // 
            BTNxSubmit.Location = new Point(143, 318);
            BTNxSubmit.Name = "BTNxSubmit";
            BTNxSubmit.Size = new Size(75, 23);
            BTNxSubmit.TabIndex = 8;
            BTNxSubmit.Text = "Submit";
            BTNxSubmit.UseVisualStyleBackColor = true;
            BTNxSubmit.Click += BTNxSubmit_Click;
            // 
            // TBxHours
            // 
            TBxHours.Location = new Point(143, 227);
            TBxHours.Name = "TBxHours";
            TBxHours.Size = new Size(182, 23);
            TBxHours.TabIndex = 7;
            // 
            // TBxPayRate
            // 
            TBxPayRate.Location = new Point(143, 178);
            TBxPayRate.Name = "TBxPayRate";
            TBxPayRate.Size = new Size(182, 23);
            TBxPayRate.TabIndex = 6;
            // 
            // TBxNumber
            // 
            TBxNumber.Location = new Point(143, 118);
            TBxNumber.Name = "TBxNumber";
            TBxNumber.Size = new Size(182, 23);
            TBxNumber.TabIndex = 5;
            // 
            // TBxName
            // 
            TBxName.Location = new Point(143, 55);
            TBxName.Name = "TBxName";
            TBxName.Size = new Size(182, 23);
            TBxName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 230);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 3;
            label5.Text = "Hours Worked";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 181);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 2;
            label4.Text = "Pay Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 121);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 58);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // tpPayroll
            // 
            tpPayroll.Controls.Add(label1);
            tpPayroll.Controls.Add(RTBxPayroll);
            tpPayroll.Location = new Point(4, 24);
            tpPayroll.Name = "tpPayroll";
            tpPayroll.Padding = new Padding(3);
            tpPayroll.Size = new Size(768, 404);
            tpPayroll.TabIndex = 1;
            tpPayroll.Text = "Payroll";
            tpPayroll.UseVisualStyleBackColor = true;
            tpPayroll.Enter += tpPayroll_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Payroll";
            // 
            // RTBxPayroll
            // 
            RTBxPayroll.Location = new Point(49, 89);
            RTBxPayroll.Name = "RTBxPayroll";
            RTBxPayroll.Size = new Size(671, 293);
            RTBxPayroll.TabIndex = 0;
            RTBxPayroll.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "PayRoll";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            TPxEmployee.ResumeLayout(false);
            TPxEmployee.PerformLayout();
            tpPayroll.ResumeLayout(false);
            tpPayroll.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TPxEmployee;
        private TabPage tpPayroll;
        private Label label1;
        private RichTextBox RTBxPayroll;
        private Button BTNxSubmit;
        private TextBox TBxHours;
        private TextBox TBxPayRate;
        private TextBox TBxNumber;
        private TextBox TBxName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblErrors;
    }
}