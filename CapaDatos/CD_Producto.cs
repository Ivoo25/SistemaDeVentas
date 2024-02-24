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
    public class CD_Producto
    {
        public List<Producto> Listar()
        {
            List<Producto> listaProducto = new List<Producto>();
            using (SqlConnection oconexion = new SqlConnection(Connection.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.IdProducto, u.Codigo, u.Nombre, u.Descripcion, r.Descripcion [DescripcionCategoria], r.IdCategoria, u.Stock, u.PrecioCompra, u.PrecioVenta, u.Estado");
                    query.AppendLine("FROM Producto u ");
                    query.AppendLine("INNER JOIN Categoria r ON r.IdCategoria = u.IdCategoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaProducto.Add(new Producto()
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                Codigo = dr["Codigo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(dr["IdCategoria"]), Descripcion = dr["DescripcionCategoria"].ToString() },
                                Stock = Convert.ToInt32(dr["Stock"]),
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                    oconexion.Close();
                }
                catch (Exception ex)
                {
                    listaProducto = new List<Producto>();
                }
            }
            return listaProducto;
        }

        public int Registrar(Producto Producto, out string Mensaje)
        {
            int idProductoGenerado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Connection.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", Producto.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", Producto.Descripcion);
                    cmd.Parameters.AddWithValue("@IdCategoria", Producto.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("@Estado", Producto.Estado);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idProductoGenerado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                    oconexion.Close();
                }
            }
            catch (Exception ex)
            {
                idProductoGenerado = 0;
                Mensaje = ex.Message;
            }
            return idProductoGenerado;
        }

        public bool Editar(Producto Producto, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Connection.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_MODIFICARPRODUCTO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdProducto", Producto.IdProducto);
                    cmd.Parameters.AddWithValue("@Codigo", Producto.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", Producto.Descripcion);
                    cmd.Parameters.AddWithValue("@IdCategoria", Producto.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("@Estado", Producto.Estado);
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

        public bool Eliminar(Producto Producto, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Connection.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARPRODUCTO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdProducto", Producto.IdProducto);
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
    }
}
