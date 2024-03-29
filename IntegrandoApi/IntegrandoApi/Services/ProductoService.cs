﻿using IntegrandoApi.Database;
using IntegrandoApi.Models;

namespace IntegrandoApi.Services
{
    public class ProductoService
    {
        private ProductoData Pdata;
        public ProductoService(ProductoData pdata)
        {
            this.Pdata = pdata;
        }
        public Producto ObtenerProducto(int id)
        {
            return this.Pdata.ObtenerProducto(id);
        }
        public List<Producto> ListarProductos()
        {
            return this.Pdata.ListarProductos();
        }
        public bool CrearProducto(Producto producto)
        {
            return this.Pdata.CrearProducto(producto);
        }
        public bool ModificarProducto(int id, Producto producto)
        {
            return this.Pdata.ModificarProducto(id, producto);
        }
        public bool EliminarProducto(int id)
        {
            return this.Pdata.EliminarProducto(id);
        }
    }
}
