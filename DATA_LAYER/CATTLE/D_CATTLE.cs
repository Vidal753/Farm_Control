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
    public class D_CATTLE
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable CattleListing()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_CATTLELISTING", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }
        public DataTable SearchCattle(E_CATTLE entities,E_CATEGORY category,E_RACE race)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_SEARCHCATTLE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CHAPA", entities.CHAPA);
            cmd.Parameters.AddWithValue("@SEX", entities.SEX);
            cmd.Parameters.AddWithValue("@STAT", entities.STAT);
            cmd.Parameters.AddWithValue("@CATEGORY", category.CATEGORY1);
            cmd.Parameters.AddWithValue("@RACE", race.RACE1);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public void UpdateCattle(E_CATTLE entities)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATECATTLE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCUTTLE", entities.IDCATTLE);
            cmd.Parameters.AddWithValue("@CHAPA", entities.CHAPA);
            cmd.Parameters.AddWithValue("@WEIGTH", entities.WEIGTHS);
            cmd.Parameters.AddWithValue("@COLOUR", entities.COLOUR);
            cmd.Parameters.AddWithValue("@STAT", entities.STAT);
            cmd.Parameters.AddWithValue("@SEX", entities.SEX);
            cmd.Parameters.AddWithValue("@DATEBORN", entities.DATEBORN);
            cmd.Parameters.AddWithValue("@IDCATEGORY", entities.IDCATEGORY);
            cmd.Parameters.AddWithValue("@IDRACE", entities.IDRACE);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void UpdatePro(E_CATTLE entities)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATEPRO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDWON", entities.IDCATTLE);
            cmd.Parameters.AddWithValue("@ESTATUS", entities.ESTATUS);
           

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void DeleteCattle(int id)
        {

            SqlCommand cmd = new SqlCommand("SP_DELETECATTLE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("IDCATTLE",id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void InsertCattle(E_CATTLE entities)
        {
            SqlCommand cmd = new SqlCommand("INSERTCATTLE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CHAPA", entities.CHAPA);
            cmd.Parameters.AddWithValue("@WEIGTH", entities.WEIGTHS);
            cmd.Parameters.AddWithValue("@COLOUR", entities.COLOUR);
            cmd.Parameters.AddWithValue("@STAT", entities.STAT);
            cmd.Parameters.AddWithValue("@SEX", entities.SEX);
            cmd.Parameters.AddWithValue("@DATEBORN", entities.DATEBORN);
            cmd.Parameters.AddWithValue("@IDCATEGORY", entities.IDCATEGORY);
            cmd.Parameters.AddWithValue("@IDRACE", entities.IDRACE);
            cmd.Parameters.AddWithValue("@ESTATUS", entities.ESTATUS);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void ShowTotals(E_CATTLE entities)
        {
            SqlCommand cmd = new SqlCommand("SP_TOTALCATTLE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalcattle = new SqlParameter("@TOTALCATTLE", 0);
            totalcattle.Direction = ParameterDirection.Output;

            SqlParameter totalrace = new SqlParameter("@TOTALRACE", 0);
            totalrace.Direction = ParameterDirection.Output;

            SqlParameter totalcategory = new SqlParameter("@TOTALCATEGORY", 0);
            totalcategory.Direction = ParameterDirection.Output;


            cmd.Parameters.Add(totalcattle);
            cmd.Parameters.Add(totalrace);
            cmd.Parameters.Add(totalcategory);
    

            conexion.Open();
            cmd.ExecuteNonQuery();

            entities.TOTALCATTLE = cmd.Parameters["@TOTALCATTLE"].Value.ToString();
            entities.TOTALRACE = cmd.Parameters["@TOTALRACE"].Value.ToString();
            entities.TOTALCATEGORY = cmd.Parameters["@TOTALCATEGORY"].Value.ToString();
           

            conexion.Close();


        }
    }
}
