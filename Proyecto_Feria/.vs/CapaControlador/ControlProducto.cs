﻿using CapaDatos;

namespace CapaControlador
{

    public class ControlProducto
    {
        DataProducto dProd = new DataProducto();

        public List<Producto> listarProductos()
        {
            return dProd.listarProductos();
        }
        public List<Proveedor> listarProveedores()
        {
            return dProd.listarProveedores();
        }
        public List<Categoria> listarCategoria()
        {
            return dProd.listarCategorias();
        }
        public string accionesProducto(Producto p)
        {
            return dProd.accionesProducto(p);
        }
        public string eliminarProducto(int id)
        {
            return dProd.eliminarProducto(id);
        }
    }
}
