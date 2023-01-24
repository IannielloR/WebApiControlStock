using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using WebApiControlStock.Data;
using WebApiControlStock.Models;

namespace WebApiControlStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly DbControlStockContext context;

        public CategoriaController(DbControlStockContext context)
        {
            this.context = context;
        }
        // GET
        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return  context.Categorias.ToList();
       
        }

        //POST
        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Categorias.Add(categoria);
            context.SaveChanges();

            return Ok();
        }
    }
}
