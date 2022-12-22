using Companies.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<EmployeePosition>().HasKey(ep => new { ep.EmployeeId, ep.PositionId });

            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var employee = new List<Employee>
            {
                 new Employee { Id = 1, FirstName = "name1", LastName = "last1", DepartmentId = 1, Salary = 10000, Unionized = true},
                 new Employee { Id = 2, FirstName = "name2", LastName = "last2", DepartmentId = 2, Salary = 20000, Unionized = false},
                 new Employee { Id = 3, FirstName = "name3", LastName = "last3", DepartmentId = 2, Salary = 30000, Unionized = false},
                 new Employee { Id = 4, FirstName = "name4", LastName = "last4", DepartmentId = 3, Salary = 40000, Unionized = true}
            };

            builder.Entity<Employee>().HasData(employee);

            var departments = new List<Department>
            {
                new Department { Id = 1,  CompanyId = 1, Name = "dep1"},
                new Department { Id = 2,  CompanyId = 1, Name = "dep2"},
                new Department { Id = 3,  CompanyId = 2, Name = "dep3"},
                new Department { Id = 4,  CompanyId = 2, Name = "dep4"}
            };

            builder.Entity<Department>().HasData(departments);

            var companies = new List<Company>
            {
                new Company { Id = 1, Name = "comp1", OrganizationNumber = "11111111111" },
                new Company { Id = 2, Name = "comp2", OrganizationNumber = "22222222222" }
            };


            builder.Entity<Company>().HasData(companies);

            var positions = new List<Position>
            {
                new Position { Id = 1, Name = "pos1"},
                new Position { Id = 2, Name = "pos2"},
                new Position { Id = 3, Name = "pos3"}
            };

            builder.Entity<Position>().HasData(positions);

            var employeePositions = new List<EmployeePosition>
            {
                new EmployeePosition { PositionId = 1, EmployeeId = 1},
                new EmployeePosition { PositionId = 1, EmployeeId = 2},
                new EmployeePosition { PositionId = 2, EmployeeId = 3},
                new EmployeePosition { PositionId = 3, EmployeeId = 4}
            };

            builder.Entity<EmployeePosition>().HasData(employeePositions);
        }


        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Position> Positions => Set<Position>();
        public DbSet<EmployeePosition> EmployeePositions =>
         Set<EmployeePosition>();
    }
}
