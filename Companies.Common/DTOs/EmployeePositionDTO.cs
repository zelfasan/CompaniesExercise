using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Common.DTOs
{
    public record EmployeePositionDTO
    {
        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public EmployeePositionDTO(int employeeId, int positionId) => (EmployeeId, PositionId) = (employeeId, positionId);
    }
}
