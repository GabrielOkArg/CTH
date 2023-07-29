using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using System.Data;
using System.Data.SqlClient;

namespace CTH.DAL.Mappers
{
    public class MapperSolicitud : IConectDB<Solicitud>
    {

        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "EDUARDOSILVA1\\SQLEXPRESS01";
            cs.InitialCatalog = "CTH_V2";
            return cs.ConnectionString;
        }
        public void saveSolicitud(Solicitud solicitud)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {

                    SqlCommand cdm = new SqlCommand("saveSolicitud", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "saveSolicitud";
                    cdm.Parameters.Add("@id_edificio", SqlDbType.Int).Value = solicitud.id_edificio;
                    cdm.Parameters.Add("@id_sector", SqlDbType.Int).Value = solicitud.id_sector;
                    cdm.Parameters.Add("@id_equipo", SqlDbType.Int).Value = solicitud.id_equipo;
                    cdm.Parameters.Add("@detalle", SqlDbType.NVarChar).Value = solicitud.detalle;
                    cdm.Parameters.Add("@creador", SqlDbType.Int).Value = solicitud.id_creador;
                    cdm.Parameters.Add("@estado", SqlDbType.NVarChar).Value =solicitud.estado;
                    cdm.Parameters.Add("@creado", SqlDbType.DateTime).Value = DateTime.UtcNow;    
                    conn.Open();
                    cdm.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Solicitud> getSolicitudesByUsuario(int id)
        {
            List<Solicitud> solicitudes = new List<Solicitud>();

            try
            {

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {

                    SqlCommand cdm = new SqlCommand("getSolicitudesByIdUser", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "getSolicitudesByIdUser";
                    cdm.Parameters.Add("@creador", SqlDbType.Int).Value = id;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Solicitud solicitud = new Solicitud();
                        solicitud.id =Convert.ToInt32(item["id"]);
                        solicitud.edificio = item["Edificio"].ToString();
                        solicitud.sector = item["Sector"].ToString();
                        solicitud.equipo = item["Equipo"].ToString();
                        solicitud.creador = new Usuario(item["Creador"].ToString());
                        solicitud.userName = item["Creador"].ToString();
                        solicitud.estado = item["Estado"].ToString();
                        solicitud.Creado = Convert.ToDateTime(item["Creado"].ToString());
                        solicitudes.Add(solicitud);
                    }
                }
                return solicitudes;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Solicitud> getByEstado(string estado)
        {
            List<Solicitud> solicitudes = new List<Solicitud>();

            try
            {

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {

                    SqlCommand cdm = new SqlCommand("getSolicitudByEstado", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "getSolicitudByEstado";
                    cdm.Parameters.Add("@estado", SqlDbType.NVarChar).Value = estado;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Solicitud solicitud = new Solicitud();
                        solicitud.id = Convert.ToInt32(item["id"]);
                        solicitud.edificio = item["Edificio"].ToString();
                        solicitud.sector = item["Sector"].ToString();
                        solicitud.equipo = item["Equipo"].ToString();
                        solicitud.detalle = item["Detalle"].ToString();
                        solicitud.creador = new Usuario(item["Creador"].ToString());
                        solicitud.userName = item["Creador"].ToString();
                        solicitud.estado = item["Estado"].ToString();
                        solicitud.Creado = Convert.ToDateTime(item["Creado"].ToString());
                        solicitudes.Add(solicitud);
                    }
                }
                return solicitudes;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Solicitud> GetAll()
        {
            throw new NotImplementedException();
        }

        public Solicitud GetByElement(Solicitud element)
        {
            throw new NotImplementedException();
        }

        public Solicitud GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
