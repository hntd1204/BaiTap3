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
    public partial class Form1 : Form
    {
        private BindingList<Employee> employees = new BindingList<Employee>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = employees;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNhanVien form = new FormNhanVien();
            if (form.ShowDialog() == DialogResult.OK)
            {
                employees.Add(form.Employee);
                dataGridView1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Employee selectedEmployee = dataGridView1.CurrentRow.DataBoundItem as Employee;
                if (selectedEmployee != null)
                {
                    FormNhanVien form = new FormNhanVien(selectedEmployee);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView1.Refresh();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Employee selectedEmployee = dataGridView1.CurrentRow.DataBoundItem as Employee;
                if (selectedEmployee != null)
                {
                    employees.Remove(selectedEmployee);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Employee
    {
        public string MSSV { get; set; }
        public string TenNV { get; set; }
        public decimal LuongCB { get; set; }
    }
}
