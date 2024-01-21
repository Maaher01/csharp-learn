using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WindowsFormsApp1.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required, StringLength(40)]
        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }

    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required, StringLength(50)]
        public string EmployeeName { get; set; }

        [Required, Column(TypeName = "date")]
        public DateTime JoinDate { get; set; }

        [Required, ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }

    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
