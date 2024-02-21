using IntegrandoApi.Database;
using IntegrandoApi.Models;
namespace IntegrandoApi.Services
{
    public class UsuarioService
    {
        private UsuarioData Udata;
        public UsuarioService(UsuarioData udata)
        {
            this.Udata = udata;
        }
        public Usuario ObtenerUsuario(int id)
        {
            return this.Udata.ObtenerUsuario(id);
        }
        public List<Usuario> ListarUsuarios()
        {
            return this.Udata.ListarUsuarios();
        }
        public bool CrearUsuario(Usuario user)
        {
            return this.Udata.CrearUsuario(user);
        }
        public bool ModificarUsuario(int id, Usuario user)
        {
            return this.Udata.ModificarUsuario(id, user);
        }
        public bool EliminarUsuario(int id)
        {
            return this.Udata.EliminarUsuario(id);
        }
    }
}
