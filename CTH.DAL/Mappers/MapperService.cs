using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.Servicios;
using System.Data.SqlClient;
using System.Data;


namespace CTH.DAL.Mappers
{
    public class MapperService : IConectDB<Bitacora>
    {
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "EDUARDOSILVA1\\SQLEXPRESS01";
            cs.InitialCatalog = "CTH_V2";
            return cs.ConnectionString;
        }
        public List<Bitacora> GetAll()
        {
            throw new NotImplementedException();
        }

        public Bitacora GetByElement(Bitacora element)
        {
            throw new NotImplementedException();
        }

        public Bitacora GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveBitacora(Bitacora bitacora)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cdm = new SqlCommand("insertBitacora", conn);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.CommandText = "insertBitacora";
                cdm.Parameters.Add("@Fecha", SqlDbType.Date).Value = bitacora.fechaBitacora();
                cdm.Parameters.Add("@Motivo", SqlDbType.NVarChar).Value = bitacora.motivo;
                cdm.Parameters.Add("@userName", SqlDbType.NVarChar).Value = bitacora.userName;
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cdm);
                conn.Open();
                cdm.ExecuteNonQuery();
                //da.Fill(dataTable);
                conn.Close();
            }
        }
    }
}
