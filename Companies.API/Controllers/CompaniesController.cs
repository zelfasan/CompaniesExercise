using Companies.API.Extensions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Companies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IDbService _db;
        public CompaniesController(IDbService db) => _db = db;

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IResult> Get()
        {
            return await _db.HttpGetAsync<Company, CompanyDTO>();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            return await _db.HttpSingleAsync<Company, CompanyDTO>(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] CompanyDTO dto)
        {
            return await _db.HttpPostAsync<Company, CompanyDTO>(dto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] CompanyDTO dto)
        {
            return await _db.HttpPutAsync<Company, CompanyDTO>(id, dto);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _db.HttpDeleteAsync<Company, CompanyDTO>(id);
        }
    }
}
