﻿using Companies.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Data.Entities
{
    public class Position : IEntity
    {
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string? Name { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
