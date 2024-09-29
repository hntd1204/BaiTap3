using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class FormNhanVien : Form
    {
        public Employee Employee { get; private set; }

        public FormNhanVien()
        {
            InitializeComponent();
        }

        public FormNhanVien(Employee employee) : this()
        {
            Employee = employee;
            textBox1.Text = employee.MSSV;
            textBox2.Text = employee.TenNV;
            textBox3.Text = employee.LuongCB.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Employee == null)
            {
                Employee = new Employee();
            }

            Employee.MSSV = textBox1.Text;
            Employee.TenNV = textBox2.Text;
            Employee.LuongCB = decimal.Parse(textBox3.Text);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
