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
    public class MapperTraduccion : IConectDB<Traducido>
    {
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "EDUARDOSILVA1\\SQLEXPRESS01";
            cs.InitialCatalog = "CTH_V2";
            return cs.ConnectionString;
        }

        public List<Traducido> getTraducidos(string form, int language)
        {
            List<Traducido> listado = new List<Traducido>();
            try
            {
              using(SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("GetTraduiccion", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "GetTraduiccion"; //nombre del store procedure
                    cdm.Parameters.Add("@formulario", SqlDbType.NVarChar).Value = form;
                    cdm.Parameters.Add("@id_idioma", SqlDbType.Int).Value = language;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Traducido _traduccion = new Traducido();
                        _traduccion.item = item.ItemArray[0].ToString();
                        _traduccion.traduccion = item.ItemArray[1].ToString();
                        _traduccion.formulario = item.ItemArray[2].ToString();
                        listado.Add(_traduccion);
                    }
                }
              return listado;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Traducido> GetAll()
        {
            throw new NotImplementedException();
        }

        public Traducido GetByElement(Traducido element)
        {
            throw new NotImplementedException();
        }

        public Traducido GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
