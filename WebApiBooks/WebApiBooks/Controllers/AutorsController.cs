using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBooks.Context;
using WebApiBooks.Entities;

namespace WebApiBooks.Controllers
{

    //-nombre debe terminar en controller
    //-debe heredar de controller base
    //-API controller es un atributo que trae un conjunto de convenciones para simplificar el codigo de las acciones
    //-Regla de ruteo
    [Route("api/[controller]")]
    [ApiController]
    public class AutorsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        //Con el controlador se puede hacer el CRUD hacia la bd
        //Inyectar el ApplicationDbContext en la clase autors controller

        public AutorsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        //Ienumerable → Colección/Lista
        //Action result → Posibles respuestas que se pueden retornar 
        public ActionResult<IEnumerable<Autor>> Get()
        {
            return context.Autores.Include(x=> x.Books).ToList();
        }

        [HttpGet("{id}", Name = "ObtenerAutor")]
        public ActionResult<Autor> Get(int id)
        {
            var autor = context.Autores.Include(x => x.Books).FirstOrDefault(x => x.Id == id);
            if (autor == null)
            {
                return NotFound();
            }
            return autor;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Autor autor) 
        {
            context.Autores.Add(autor);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.Id }, autor);
            
        }

        [HttpPut("{id}")]
        //Id del url
        public ActionResult Put(int id, [FromBody] Autor value)
        {
            if (id != value.Id) 
            {
                //Validar que id del cuerpo y la url sean iguales
                return BadRequest();
            }


            context.Entry(value).State= EntityState.Modified;
            context.SaveChanges();
            return Ok();  
        }

        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id) 
        {
            //Buscar autor en la BD
            var autor = context.Autores.FirstOrDefault(x => x.Id == id);

            if (autor == null)
            {
                return NotFound();
            }

            context.Autores.Remove(autor);
            context.SaveChanges();
            return autor;

        }
    }
}
