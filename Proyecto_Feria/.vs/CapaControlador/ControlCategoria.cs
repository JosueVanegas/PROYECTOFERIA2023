using CapaDatos;

namespace CapaControlador
{
    public class ControlCategoria
    {
        DataCategoria dCa = new DataCategoria();
        public ControlCategoria() { }
        public List<Categoria> listarCategorias()
        {
            return dCa.listarCategorias();
        }
        public string registraModificar(Categoria c)
        {
            return dCa.accionesCategoria(c);
        }
        public string eliminar(int id)
        {
            return dCa.eliminarCategoria(id);
        }
    }
}
