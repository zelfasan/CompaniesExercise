using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Companies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePositionsController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployeePositionsController(IDbService db) => _db = db;

        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeePositionDTO employeePosition) =>
            await _db.HttpAddAsync<EmployeePosition, EmployeePositionDTO>(employeePosition);

        [HttpDelete]
        public async Task<IResult> Delete(EmployeePositionDTO dto) =>
            await _db.HttpDeleteAsync<EmployeePosition, EmployeePositionDTO>(dto);
    }
}
