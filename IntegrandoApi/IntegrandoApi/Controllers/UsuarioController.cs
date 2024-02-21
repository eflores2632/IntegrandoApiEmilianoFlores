using IntegrandoApi.Models;
using IntegrandoApi.Services;
using Microsoft.AspNetCore.Mvc;
namespace IntegrandoApi.Controllers
{
    [ApiController]
    [Route("api/")]
    public class UsuarioController : Controller
    {
        private UsuarioService Uservice;
        public UsuarioController(UsuarioService uservice)
        {
            this.Uservice = uservice;
        }
        [HttpGet]
        [Route("obtenerusuario/{id}")]
        public ActionResult<Usuario> ObtenerUsuario(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            else
            {
                return this.Uservice.ObtenerUsuario(id);
            }
        }
        [HttpGet]
        [Route("listarusuarios")]
        public ActionResult<List<Usuario>> ObtenerUsuarios()
        {
            return this.Uservice.ListarUsuarios();
        }
        [HttpPost]
        [Route("crearusuario")]
        public ActionResult CrearUsuario([FromBody] Usuario user)
        {
            try
            {
                if (this.Uservice.CrearUsuario(user))
                {
                    return Ok();
                }
                return Ok();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return BadRequest(); }
        }
        [HttpPut]
        [Route("modificarusuario")]
        public ActionResult ModificarUsuario([FromBody] Usuario user)
        {
            if (this.Uservice.ModificarUsuario(user.Id, user))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("eliminarusuario/{id}")]
        public ActionResult EliminarUsuario(int id)
        {
            if (this.Uservice.EliminarUsuario(id))
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
