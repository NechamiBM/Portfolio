using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CVSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoryController : ControllerBase
    {

        // GET api/<RepositoryController>/5
        [HttpGet("{userName}")]
        public  IEnumerable<string> GetPortfolio(string userName)
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<RepositoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RepositoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RepositoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
