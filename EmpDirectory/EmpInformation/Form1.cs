using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpInfo;


namespace EmpInformation
{
    public partial class EmpInfo : Form
    {
        public EmpInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.employeeName = textEmpName.Text;
            emp.empId = textEmpId.Text;
            emp.empMobile = textEmpmobile.Text;
            emp.empAddress = textEmpAddress.Text;
            try
            {
                emp.empTweetId = textTweetId.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
