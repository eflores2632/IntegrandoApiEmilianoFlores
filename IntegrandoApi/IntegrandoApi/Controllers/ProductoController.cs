using IntegrandoApi.Models;
using IntegrandoApi.Services;
using Microsoft.AspNetCore.Mvc;
namespace IntegrandoApi.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ProductoController : Controller
    {
        private ProductoService Pservice;
        public ProductoController(ProductoService pservice)
        {
            this.Pservice = pservice;
        }
        [HttpGet]
        [Route("obtenerproducto/{id}")]
        public ActionResult<Producto> ObtenerProducto(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            else
            {
                return this.Pservice.ObtenerProducto(id);
            }
        }
        [HttpGet]
        [Route("listarproductos")]
        public ActionResult<List<Producto>> ObtenerProductos()
        {
            return this.Pservice.ListarProductos();
        }
        [HttpPost]
        [Route("crearproducto")]
        public ActionResult CrearProducto([FromBody] Producto product)
        {
            try
            {
                if (this.Pservice.CrearProducto(product))
                {
                    return Ok();
                }
                return Ok();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return BadRequest(); }
        }
        [HttpPut]
        [Route("modificarproducto")]
        public ActionResult ModificarProducto([FromBody] Producto product)
        {
            if (this.Pservice.ModificarProducto(product.Id, product))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("eliminarproducto/{id}")]
        public ActionResult EliminarProducto(int id)
        {
            if (this.Pservice.EliminarProducto(id))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
