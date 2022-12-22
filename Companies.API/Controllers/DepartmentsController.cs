using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Departments.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : Controller
    {
        private readonly IDbService _db;
        public DepartmentsController(IDbService db) => _db = db;

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IResult> Get()
        {
            return await _db.HttpGetAsync<Department, DepartmentDTO>();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            return await _db.HttpSingleAsync<Department, DepartmentDTO>(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] DepartmentDTO dto)
        {
            return await _db.HttpPostAsync<Department, DepartmentDTO>(dto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] DepartmentDTO dto)
        {
            return await _db.HttpPutAsync<Department, DepartmentDTO>(id, dto);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _db.HttpDeleteAsync<Department, DepartmentDTO>(id);
        }
    }
}
