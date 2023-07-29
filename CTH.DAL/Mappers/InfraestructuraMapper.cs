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
    public class InfraestructuraMapper
    {

        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "EDUARDOSILVA1\\SQLEXPRESS01";
            cs.InitialCatalog = "CTH_V2";
            return cs.ConnectionString;
        }

        public List<Edificio> getEdificios()
        {
            List<Edificio> edificios = new List<Edificio>();
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("GetuserByusername", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "getEdificios";
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Edificio edificio = new Edificio();
                        edificio.id = Convert.ToInt32(item["id"]);
                        edificio.nombre = item["nombre"].ToString();
                        edificios.Add(edificio);
                    }
                   
                }
                return edificios;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Sector> getSectoresByEdificio(int id)
        {
            List<Sector> sectores = new List<Sector>();
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("getSectoresByEdificio", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "getSectoresByEdificio";
                    cdm.Parameters.Add("@id_edificio", SqlDbType.Int).Value = id;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Sector sector = new Sector();
                        sector.id = Convert.ToInt32(item["id"]);
                        sector.nombre = item["nombre"].ToString();
                        sectores.Add(sector);
                    }

                }
                return sectores;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public List<Equipo> getEquiposBySector(int id)
        {
            List<Equipo> equipos = new List<Equipo>();
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cdm = new SqlCommand("getEquiposBySector", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "getEquiposBySector";
                    cdm.Parameters.Add("@id_sector", SqlDbType.Int).Value = id;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Equipo equipo = new Equipo();
                        equipo.id = Convert.ToInt32(item["id"]);
                        equipo.nombre = item["nombre"].ToString();
                        equipos.Add(equipo);
                    }

                }
                return equipos;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
