using Microsoft.AspNetCore.Mvc;

namespace WebApiPrueba.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController: ControllerBase
    {
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpGet("{id}")] // Se le pasa el nommbre del parametro entre llaves
        //GET api/values/5
        public ActionResult<string> Get(int id)
        {
            return "value" + id.ToString();
        }


        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value) 
        {

        }

        //PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) 
        { 

        }

        //DELETE
        [HttpDelete("{id}")]
        public void Delete(int id) 
        {

        }
    }
}
