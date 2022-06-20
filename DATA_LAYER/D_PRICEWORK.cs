using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ENTITIES_LAYER;
namespace DATA_LAYER
{
    public class D_PRICEWORK
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable PriceListing()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_PRICELISTING", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }
        public DataTable SearchPrice(E_WORKERS entities)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_SEARCHPRICE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CEDULA", entities.CEDULA);
            cmd.Parameters.AddWithValue("@NAMES", entities.NAMES);
            cmd.Parameters.AddWithValue("@LASTNAME", entities.LASTNAME);
            
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public void UpdatePriceWorker(E_PRICEWORK entities)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATEPRICE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPRICE", entities.IDPRICE);
            cmd.Parameters.AddWithValue("@TOTAL", entities.TOTAL);
            cmd.Parameters.AddWithValue("@IDWORKER", entities.IDWORKERS);
            cmd.Parameters.AddWithValue("@IDJOB", entities.IDJOB);
            cmd.Parameters.AddWithValue("@STAR", entities.STAR);
            cmd.Parameters.AddWithValue("@FINISH", entities.FINISH);
           

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void DeletePrice(int id)
        {

            SqlCommand cmd = new SqlCommand("SP_DELETEPRICE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPRICE", id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void InsertPrice(E_PRICEWORK entities)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTPRICE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            
            cmd.Parameters.AddWithValue("@TOTAL", entities.TOTAL);
            cmd.Parameters.AddWithValue("@IDWORKER", entities.IDWORKERS);
            cmd.Parameters.AddWithValue("@IDJOB", entities.IDJOB);
            cmd.Parameters.AddWithValue("@STAR", entities.STAR);
            cmd.Parameters.AddWithValue("@FINISH", entities.FINISH);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
