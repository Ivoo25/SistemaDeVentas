using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idUsuario)
        {
            List<Permiso> listaPermiso = new List<Permiso>();
            using (SqlConnection oconexion = new SqlConnection(Connection.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.IdRol, NombreMenu ");
                    query.AppendLine("FROM Permiso p INNER JOIN Rol R on R.IdRol = p.IdRol ");
                    query.AppendLine("INNER JOIN USUARIO U ON U.IdRol = R.IdRol");
                    query.AppendLine("WHERE U.IdUsuario = @idUsuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaPermiso.Add(new Permiso()
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString()

                            });
                        }
                    }
                    oconexion.Close();
                }
                catch (Exception ex)
                {
                    listaPermiso = new List<Permiso>();
                }
            }
            return listaPermiso;
        }
    }
}
