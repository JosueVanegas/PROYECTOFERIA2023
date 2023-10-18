using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class ControlOferta
    {
        DataOferta dOFerta = new DataOferta();

        public List<Modelos.Ofertas> listarOfertas()
        {
            return dOFerta.listarOfertas();
        }
        public string registrar(Modelos.Ofertas oferta)
        {
            return dOFerta.registrar(oferta);
        }
        public string eliminar(int id)
        {
            return dOFerta.eliminar(id);
        }
    }
}
