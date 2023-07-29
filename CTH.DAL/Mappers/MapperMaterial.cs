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
    public class MapperMaterial : IConectDB<Material>
    {

        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "EDUARDOSILVA1\\SQLEXPRESS01";
            cs.InitialCatalog = "CTH_V2";
            return cs.ConnectionString;
        }


        public List<Material> searchMaterial(string cadena)
        {
            List<Material> materiales = new List<Material>();
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("searchMateriales", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "searchMateriales";
                    cdm.Parameters.Add("@key", SqlDbType.NVarChar).Value = cadena;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Material material = new Material();
                        material.id = Convert.ToInt32(row["id"]);
                        material.nombre = row["nombre"].ToString();
                        material.stock = Convert.ToInt32(row["stock"]);
                        materiales.Add(material);
                    }
                }

                    return materiales;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void saveMaterialOT(List<Material> materials, int orden)
        {


            foreach (Material item in materials)
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("saveMaterialOrden", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "saveMaterialOrden";
                    cdm.Parameters.Add("@id_material", SqlDbType.Int).Value = item.id;
                    cdm.Parameters.Add("@id_orden",SqlDbType.Int).Value = orden;
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    cdm.ExecuteNonQuery();
                    conn.Close();
                  
                }
            }
        }
        public List<Material> GetAll()
        {
            throw new NotImplementedException();
        }

        public Material GetByElement(Material element)
        {
            throw new NotImplementedException();
        }

        public Material GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
