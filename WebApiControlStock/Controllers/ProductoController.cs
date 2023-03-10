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
    public class ProductoController : ControllerBase
    {
        private readonly DbControlStockContext context;

        public ProductoController(DbControlStockContext context)
        {
            this.context = context;
        }
        // GET
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            var result = context.Productos.Include(x => x.Categoria).ToList();
            return result;
        }

        //POST
        [HttpPost]
        public ActionResult Post(Producto producto) 
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }
            context.Productos.Add(producto);
            context.SaveChanges();

            return Ok();
        }
    }
}
