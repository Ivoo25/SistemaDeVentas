using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto oCD_Producto = new CD_Producto();
        public List<Producto> Listar()
        {
            return oCD_Producto.Listar();
        }
        public int Registrar(Producto u, out string Mensaje)
        {
            return oCD_Producto.Registrar(u, out Mensaje);
        }
        public bool Editar(Producto u, out string Mensaje)
        {
            return oCD_Producto.Editar(u, out Mensaje);
        }
        public bool Eliminar(Producto u, out string Mensaje)
        {
            return oCD_Producto.Eliminar(u, out Mensaje);
        }
    }
}
