using Companies.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Data.Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string? FirstName { get; set; }

        [MaxLength(50), Required]
        public string? LastName { get; set; }
        public int DepartmentId { get; set; }
        public int Salary { get; set; }
        public bool Unionized { get; set; }
        public virtual Department? Department { get; set; }
        public virtual EmployeePosition? EmployeePosition { get; set; }
    }
}
