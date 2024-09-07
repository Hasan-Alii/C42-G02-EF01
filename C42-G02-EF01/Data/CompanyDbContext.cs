using C42_G02_EF01.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01.Data
{
    internal class CompanyDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server = HASAN\\MSSQLSERVER09; Database = Company; Trusted_Connection = true; TrustServerCertificate = true");
        //optionsBuilder.UseSqlServer("Data Source = .; Initial Catalog = Company; Integrated Security = true");

        public DbSet<Employee> Employees { get; set; } //represents table not view

        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
