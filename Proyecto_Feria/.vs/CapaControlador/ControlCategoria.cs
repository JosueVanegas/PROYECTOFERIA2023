using CapaDatos;

namespace CapaControlador
{
    public class ControlCategoria
    {
        DataCategoria dCa = new DataCategoria();
        public ControlCategoria() { }
        public List<Modelos.Categoria> listarCategorias()
        {
            return dCa.listarCategorias();
        }
        public string registraModificar(Modelos.Categoria c)
        {

            return dCa.accionesCategoria(c);
        }
        public string eliminar(int id)
        {
            return dCa.eliminarCategoria(id);
        }
    }
}
