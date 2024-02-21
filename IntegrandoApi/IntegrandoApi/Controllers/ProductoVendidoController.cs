using IntegrandoApi.Models;
using IntegrandoApi.Services;
using Microsoft.AspNetCore.Mvc;
namespace IntegrandoApi.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ProductoVendidoController : Controller
    {
        private ProductoVendidoService PVService;
        public ProductoVendidoController(ProductoVendidoService pvService)
        {
            this.PVService = pvService;
        }

        [HttpGet]
        [Route("obtenerproductovendido/{id}")]
        public ActionResult<ProductoVendido> ObtenerProducto(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            else
            {
                return this.PVService.ObtenerProductoVendido(id);
            }
        }
        [HttpGet]
        [Route("listarproductosvendidos")]
        public ActionResult<List<ProductoVendido>> ObtenerProductos()
        {
            return this.PVService.ListarPrductosVendidos();
        }
        [HttpPost]
        [Route("crearproductovendido")]
        public ActionResult CrearProductoVendido([FromBody] ProductoVendido productvendido)
        {
            try
            {
                if (this.PVService.CrearProductoVendido(productvendido))
                {
                    return Ok();
                }
                return Ok();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return BadRequest(); }
        }
        [HttpPut]
        [Route("modificarproductovendido")]
        public ActionResult ModificarProductoVendido([FromBody] ProductoVendido productvendido)
        {
            if (this.PVService.ModificarProductoVendido(productvendido.Id, productvendido))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("eliminarproductovendido/{id}")]
        public ActionResult EliminarProductoVendido(int id)
        {
            if (this.PVService.EliminarProductoVendido(id))
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
