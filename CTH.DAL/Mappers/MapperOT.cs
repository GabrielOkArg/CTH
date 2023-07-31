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
    public class MapperOT : IConectDB<OrdenTrabajo>
    {
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "EDUARDOSILVA1\\SQLEXPRESS01";
            cs.InitialCatalog = "CTH_V2";
            return cs.ConnectionString;
        }

        public void saveOrden(OrdenTrabajo orden, List<Material> materials)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cdm = new SqlCommand("saveOrdenTrabajo", conn);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.CommandText = "saveOrdenTrabajo";
                cdm.Parameters.Add("@id_coordinador", SqlDbType.Int).Value = orden.cordinadorId;
                cdm.Parameters.Add("@id_tecnico", SqlDbType.Int).Value = orden.tecnicoId;
                cdm.Parameters.Add("@detallecoordinador", SqlDbType.NVarChar).Value = orden.detalleCoordinador;
                cdm.Parameters.Add("@fechacreacion", SqlDbType.Date).Value = orden.fechacreacion;
                cdm.Parameters.Add("@id_solicitud", SqlDbType.Int).Value = orden.solicitud_id;

                    SqlParameter outputParameter = new SqlParameter("@IdGenerado", SqlDbType.Int);
                    outputParameter.Direction = ParameterDirection.Output;
                    cdm.Parameters.Add(outputParameter);

                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    cdm.ExecuteNonQuery();
                    int idgenerado = Convert.ToInt32(outputParameter.Value);
                    conn.Close();

                if (materials.Count > 0)
                {
                    MapperMaterial mapperMaterial = new MapperMaterial();
                    mapperMaterial.saveMaterialOT(materials, idgenerado);
                }

            }
        }

        public List<OrdenTrabajo>getOrdenesCoordinador(int coordinador)
        {
            List<OrdenTrabajo> ordenes = new List<OrdenTrabajo>();
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("getByCoordinador", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "getByCoordinador";
                    cdm.Parameters.Add("@id", SqlDbType.Int).Value = coordinador;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    //cdm.ExecuteNonQuery();
                    da.Fill(dataTable);
                    conn.Close();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
                        ordenTrabajo.id = Convert.ToInt32(row["NumOrden"]);
                        ordenTrabajo.solicitud_id = Convert.ToInt32(row["NumSolicitud"]);
                        ordenTrabajo.tecnico = row["Tecnico"].ToString();
                        if (!Convert.IsDBNull(row["Creada"]))
                        {
                            ordenTrabajo.fechacreacion = Convert.ToDateTime(row["Creada"]);
                        }
                        ordenes.Add(ordenTrabajo);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ordenes;
        }

        public List<OrdenTrabajo> getOrdenesAsignadas(int tecnico)
        {
            List<OrdenTrabajo> ordenes = new List<OrdenTrabajo>();
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("getOTAsignada", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "getOTAsignada";
                    cdm.Parameters.Add("@id_tecnico",SqlDbType.Int).Value = tecnico;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    //cdm.ExecuteNonQuery();
                    da.Fill(dataTable);
                    conn.Close();
                  
                    foreach (DataRow row in dataTable.Rows)
                    {
                       OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
                        ordenTrabajo.id = Convert.ToInt32(row["numorden"]);
                        ordenTrabajo.solicitud_id = Convert.ToInt32(row["idsolicitud"]);
                        ordenTrabajo.cordinadorId = Convert.ToInt32(row["idcoordinador"]);
                        ordenTrabajo.coordinador = row["coordinador"].ToString();
                        ordenTrabajo.tecnicoId = Convert.ToInt32(row["idtecnico"]);
                        ordenTrabajo.tecnico = row["tecnico"].ToString();
                        ordenTrabajo.detalleCoordinador = row["detallecoordinador"].ToString();
                        ordenTrabajo.detalleTecnico = row["detalletecnico"].ToString();
                        ordenTrabajo.horas = Convert.ToInt32(row["horas"]);
                        ordenTrabajo.finalizada = Convert.ToBoolean(row["finalizada"]);
                        if (!Convert.IsDBNull(row["fechacreacion"]))
                        {
                            ordenTrabajo.fechacreacion = Convert.ToDateTime(row["fechacreacion"]);
                        }
                        if (!Convert.IsDBNull(row["fechafinalizada"]))
                        {
                            ordenTrabajo.fechafinalizacion = Convert.ToDateTime(row["fechafinalizada"]);
                        }
                            if (!Convert.IsDBNull(row["fechacierre"]))
                        {
                            ordenTrabajo.fechacierre = Convert.ToDateTime(row["fechacierre"]);
                        }
                                
                        
                        ordenTrabajo.cerrada = Convert.ToBoolean(row["cerrada"]);

                        ordenes.Add(ordenTrabajo);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ordenes;
        }
        public List<OrdenTrabajo> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrdenTrabajo GetByElement(OrdenTrabajo element)
        {
            throw new NotImplementedException();
        }

        public OrdenTrabajo GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
