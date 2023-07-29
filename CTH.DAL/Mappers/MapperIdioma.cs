using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CTH.BE;

namespace CTH.DAL.Mappers
{
    public  class MapperIdioma : IConectDB<Idioma>
    {
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "EDUARDOSILVA1\\SQLEXPRESS01";
            cs.InitialCatalog = "CTH_V2";
            return cs.ConnectionString;
        }
        public List<Idioma> GetAll()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("GetIdiomas", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "GetIdiomas";
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    //cdm.ExecuteNonQuery();
                    da.Fill(dataTable);
                    conn.Close();
                    List<Idioma> idiomas = new List<Idioma>();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Idioma idioma = new Idioma();
                        idioma.id = Convert.ToInt32(row["id"]);
                        idioma._Idioma = row["nombre"].ToString();
                        idioma.principal = Convert.ToBoolean(row["principal"]);
                        idiomas.Add(idioma);
                    }
                    return idiomas;
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public Idioma GetByElement(Idioma element)
        {
            throw new NotImplementedException();
        }

        public Idioma GetById(int id)
        {
            throw new NotImplementedException();
        }

      

       
    }
}
