using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario oCD_Usuario = new CD_Usuario();
        public List<Usuario> Listar()
        {
            return oCD_Usuario.Listar();
        }
        public int Registrar(Usuario u, out string Mensaje)
        {
            return oCD_Usuario.Registrar(u, out Mensaje);
        }
        public bool Editar(Usuario u, out string Mensaje)
        {
            return oCD_Usuario.Editar(u, out Mensaje);
        }
        public bool Eliminar(Usuario u, out string Mensaje)
        {
            return oCD_Usuario.Eliminar(u, out Mensaje);
        }
    }
}
