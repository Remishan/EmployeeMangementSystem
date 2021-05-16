using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMangementSystem
{
    public partial class Registration : Form
    {
        Read read = new Read();
        public Registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(txtName.Text==""&&txtAge.Text==""&&txtEmail.Text==""&&txtSalary.Text=="")
            {
                MessageBox.Show("Enter All Fields");
            }
            else 
            {
                read.Name = txtName.Text;
                read.Age =Convert.ToInt32 (txtAge.Text);
                read.Salary = Convert.ToDouble( txtSalary.Text);
                read.Email = txtEmail.Text;
                MessageBox.Show("Saved Sucessfully");
                txtAge.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                txtSalary.Text = "";
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtNameRead.Text = read.Name.ToUpper();
            txtAgeRead.Text = read.Age.ToString();
            double basic = read.Salary + 10;
            txtSalaryRead.Text = basic.ToString();
            txtEmailRead.Text = read.Email;
        }

        private void txtEmailRead_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
