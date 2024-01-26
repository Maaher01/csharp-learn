using System;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class AddDeptForm : Form
    {
        readonly EmployeeDbContext db = new EmployeeDbContext();

        public AddDeptForm()
        {
            InitializeComponent();
        }

        public Form1 FormOpener { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Department dept = new Department { DepartmentName = textBox1.Text };
            db.Departments.Add(dept);
            db.SaveChanges();
            MessageBox.Show("Department Saved", "Success!");
            textBox1.Clear();
            FormOpener.LoadData();
        }
    }
}
