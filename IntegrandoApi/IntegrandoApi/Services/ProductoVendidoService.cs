using IntegrandoApi.Database;
using IntegrandoApi.Models;

namespace IntegrandoApi.Services
{
    public class ProductoVendidoService
    {
        private ProductoVendidoData PVdata;
        public ProductoVendidoService(ProductoVendidoData pvdata)
        {
            this.PVdata = pvdata;
        }
        public ProductoVendido ObtenerProductoVendido(int id)
        {
            return this.PVdata.ObtenerProductoVendido(id);
        }
        public List<ProductoVendido> ListarPrductosVendidos()
        {
            return this.PVdata.ListarPrductosVendidos();
        }
        public bool CrearProductoVendido(ProductoVendido productovendido)
        {
            return this.PVdata.CrearProductoVendido(productovendido);
        }
        public bool ModificarProductoVendido(int id, ProductoVendido productovendido)
        {
            return this.PVdata.ModificarProductoVendido(id, productovendido);
        }
        public bool EliminarProductoVendido(int id)
        {
            return this.PVdata.EliminarProductoVendido(id);
        }
    }
}
