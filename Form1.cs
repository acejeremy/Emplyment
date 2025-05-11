using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EmployeeDetail;
using System.Xml.Linq;

namespace ReadWriteWithForms
{
    public partial class Form1 : Form
    {
        private List<Employee> employeeList;
        public Form1()
        {
            InitializeComponent();

            
            employeeList = new List<Employee>();


            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });


            cmbDepartment.Items.AddRange(new string[] {
                "Information Technology",
                "Accounts",
                "Research",
                "Human Resources",
                "Public Relations"
            });
            textAge.ReadOnly = true;    
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
          
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string gender = cmbGender.Text;
            DateTime dateOfBirth = dtpDOB.Value;
            string department = cmbDepartment.Text; 

            Employee employee = new Employee(name, surname, gender, dateOfBirth, department);
            int age = employee.AgeCalculator();

            
            employeeList.Add(employee);

            
            string employeeDetailsString = $"{name} {surname}, Gender: {gender}, DOB: {dateOfBirth.ToShortDateString()}, Department: {department}, Age: {age}";
            lbEmployeeDetails.Text = employeeDetailsString; 

            
            ClearFormFields();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ClearFormFields()
        {
            textBox1.Clear();   
            textBox2.Clear();   
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            cmbDepartment.SelectedIndex = -1;
        }
    }
}
