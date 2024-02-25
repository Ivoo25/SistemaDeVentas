using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente oCD_Cliente = new CD_Cliente();
        public List<Cliente> Listar()
        {
            return oCD_Cliente.Listar();
        }
        public int Registrar(Cliente u, out string Mensaje)
        {
            return oCD_Cliente.Registrar(u, out Mensaje);
        }
        public bool Editar(Cliente u, out string Mensaje)
        {
            return oCD_Cliente.Editar(u, out Mensaje);
        }
        public bool Eliminar(Cliente u, out string Mensaje)
        {
            return oCD_Cliente.Eliminar(u, out Mensaje);
        }
    }
}
