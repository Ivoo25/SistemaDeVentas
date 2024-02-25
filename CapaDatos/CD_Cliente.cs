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
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            using (SqlConnection oconexion = new SqlConnection(Connection.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCliente, Documento, NombreCompleto, Correo, Telefono, Estado");
                    query.AppendLine("FROM Cliente");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaCliente.Add(new Cliente()
                            {
                                IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                    oconexion.Close();
                }
                catch (Exception ex)
                {
                    listaCliente = new List<Cliente>();
                }
            }
            return listaCliente;
        }

        public int Registrar(Cliente Cliente, out string Mensaje)
        {
            int idClienteGenerado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Connection.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGRISTRARCLIENTE", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", Cliente.Documento);
                    cmd.Parameters.AddWithValue("@NombreCompleto", Cliente.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Correo", Cliente.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", Cliente.Estado);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                    oconexion.Close();
                }
            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                Mensaje = ex.Message;
            }
            return idClienteGenerado;
        }

        public bool Editar(Cliente Cliente, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Connection.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_MODIFICARCLIENTE", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@Documento", Cliente.Documento);
                    cmd.Parameters.AddWithValue("@NombreCompleto", Cliente.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Correo", Cliente.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", Cliente.Estado);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                    oconexion.Close();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;
            }
            return resultado;
        }

        public bool Eliminar(Cliente Cliente, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Connection.cadena))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM CLIENTE WHERE IdCliente = @id", oconexion);
                    cmd.Parameters.AddWithValue("@id", Cliente.IdCliente);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    resultado = cmd.ExecuteNonQuery() > 0 ? true : false;

                    oconexion.Close();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;
            }
            return resultado;
        }
    }
}
