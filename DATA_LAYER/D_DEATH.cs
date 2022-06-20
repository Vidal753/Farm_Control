using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using ENTITIES_LAYER;

namespace DATA_LAYER
{
   public  class D_DEATH
    {
          SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable DeathList()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_DEATHLISTING", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }
        public void InsertDeath(E_DEATH entities)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTDEATH", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@DATEDIE", entities.DATEDIE);
            cmd.Parameters.AddWithValue("@DESCRIP", entities.DESCRIPTION);
            cmd.Parameters.AddWithValue("@IDCATTLE", entities.IDCATTLE);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
