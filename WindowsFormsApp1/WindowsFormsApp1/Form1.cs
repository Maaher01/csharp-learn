using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BindingSource bsE = new BindingSource();
        BindingSource bsD = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView2.AutoGenerateColumns = false;
            LoadData();                       
        }

        public void LoadData()
        {
            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                bsD.DataSource = db.Departments.ToList();
                dataGridView1.DataSource = bsD;
                bsE.DataSource = bsD;
                bsE.DataMember = "Employees";
                dataGridView2.DataSource = bsE;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddDeptForm { FormOpener = this }.ShowDialog();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm { FormOpener = this }.ShowDialog();
        }
    }
}
