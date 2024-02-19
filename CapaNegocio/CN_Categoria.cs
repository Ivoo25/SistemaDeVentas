using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria oCD_Categoria = new CD_Categoria();
        public List<Categoria> Listar()
        {
            return oCD_Categoria.Listar();
        }
        public int Registrar(Categoria c, out string Mensaje)
        {
            return oCD_Categoria.Registrar(c, out Mensaje);
        }
        public bool Editar(Categoria c, out string Mensaje)
        {
            return oCD_Categoria.Editar(c, out Mensaje);
        }
        public bool Eliminar(Categoria c, out string Mensaje)
        {
            return oCD_Categoria.Eliminar(c, out Mensaje);
        }
    }
}
