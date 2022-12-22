using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployeesController(IDbService db) => _db = db;

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IResult> Get()
        {
            return await _db.HttpGetAsync<Employee, EmployeeDTO>();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            return await _db.HttpSingleAsync<Employee, EmployeeDTO>(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeeDTO dto)
        {
            return await _db.HttpPostAsync<Employee, EmployeeDTO>(dto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] EmployeeDTO dto)
        {
            return await _db.HttpPutAsync<Employee, EmployeeDTO>(id, dto);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _db.HttpDeleteAsync<Employee, EmployeeDTO>(id);
        }
    }
}
