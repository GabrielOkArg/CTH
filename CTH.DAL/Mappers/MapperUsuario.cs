using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using System.Data.SqlClient;
using System.Data;

namespace CTH.DAL.Mappers
{
    public class MapperUsuario : IConectDB<Usuario>
    {
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "EDUARDOSILVA1\\SQLEXPRESS01";
            cs.InitialCatalog = "CTH_V2";
            return cs.ConnectionString;
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetByElement(Usuario element)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("GetuserByusername", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "GetuserByusername";
                    cdm.Parameters.Add("@username", SqlDbType.NVarChar).Value = element.getUserName;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    if (dataTable.Rows.Count > 0)
                    {
                        element.apellido = dataTable.Rows[0].ItemArray[1].ToString();
                        element.nombre = dataTable.Rows[0].ItemArray[0].ToString();
                        element.id = Convert.ToInt32(dataTable.Rows[0].ItemArray[2]);
                        element.pass = dataTable.Rows[0].ItemArray[4].ToString();
                        element.bloqueo = Convert.ToBoolean(dataTable.Rows[0].ItemArray[5]);
                        element.intentos = dataTable.Rows[0].ItemArray[6].ToString();
                    }
                    else
                    {
                        element = null;
                    }
                }
                return element;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void BloquearUsuario(string userName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("BloquearUsuario", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "BloquearUsuario";
                    cdm.Parameters.Add("@username", SqlDbType.NVarChar).Value = userName;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    cdm.ExecuteNonQuery();
                    //da.Fill(dataTable);
                    conn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool DesbloquearUsuario(string userName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("desbloquearusuario", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "desbloquearusuario";
                    cdm.Parameters.Add("@username", SqlDbType.NVarChar).Value = userName;
                    conn.Open();
                    cdm.ExecuteNonQuery();
                    conn.Close();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void updateIntentos(string username, string intentos)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cdm = new SqlCommand("updateIntentos", conn);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.CommandText = "updateIntentos";
                cdm.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                cdm.Parameters.Add("@intentos", SqlDbType.NVarChar).Value = intentos;
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cdm);
                conn.Open();
                cdm.ExecuteNonQuery();
                //da.Fill(dataTable);
                conn.Close();
            }
        }

        public void saveUsuario(Usuario usuario)
        {
            using(SqlConnection conn = new SqlConnection(GetConnectionString()))
            {

                SqlCommand cdm = new SqlCommand("InsertarUsuario", conn);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.CommandText = "InsertarUsuario";
                cdm.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = usuario.nombre;
                cdm.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = usuario.apellido;
                cdm.Parameters.Add("@username", SqlDbType.NVarChar).Value = usuario.getUserName;
                cdm.Parameters.Add("@pass", SqlDbType.NVarChar).Value = usuario.pass;
                cdm.Parameters.Add("@bloqueo", SqlDbType.Bit).Value = usuario.bloqueo;
                cdm.Parameters.Add("@intentos", SqlDbType.NVarChar).Value = usuario.intentos;
                conn.Open();
                cdm.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void cambiarPass(Usuario usuario, string newpass)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cdm = new SqlCommand("cambiarcontraseña", conn);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.CommandText = "cambiarcontraseña";
                cdm.Parameters.Add("@username", SqlDbType.NVarChar).Value = usuario.getUserName;
                cdm.Parameters.Add("@pass", SqlDbType.NVarChar).Value = newpass;
                conn.Open();
                cdm.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
