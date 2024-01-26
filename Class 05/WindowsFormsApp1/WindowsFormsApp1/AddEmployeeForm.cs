using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class AddEmployeeForm : Form
    {
        readonly EmployeeDbContext db = new EmployeeDbContext();

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        public Form1 FormOpener {  get; set; }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            comboBox1.DataSource = db.Departments.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee { EmployeeName = textBox1.Text, JoinDate = dateTimePicker1.Value, DepartmentId = int.Parse(comboBox1.SelectedValue.ToString()) };
            db.Employees.Add(emp);
            db.SaveChanges();
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Today;
            MessageBox.Show("Employee Saved", "Success!");
            FormOpener.LoadData();
        }
    }
}
