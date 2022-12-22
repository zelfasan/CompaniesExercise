using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Companies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly IDbService _db;
        public PositionsController(IDbService db) => _db = db;

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IResult> Get()
        {
            return await _db.HttpGetAsync<Position, PositionDTO>();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            return await _db.HttpSingleAsync<Position, PositionDTO>(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] PositionDTO dto)
        {
            return await _db.HttpPostAsync<Position, PositionDTO>(dto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] PositionDTO dto)
        {
            return await _db.HttpPutAsync<Position, PositionDTO>(id, dto);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _db.HttpDeleteAsync<Position, PositionDTO>(id);
        }
    }
}
