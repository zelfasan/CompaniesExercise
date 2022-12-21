using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Common.DTOs
{
    public record CompanyDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? OrganizationNumber { get; set; }
    }
}
