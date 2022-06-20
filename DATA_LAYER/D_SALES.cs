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
    public class D_SALES
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable SaleList()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_SALELIST", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }
        public void DeleteWonSale(int id)
        {

            SqlCommand cmd = new SqlCommand("SP_DELETEWONSALE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDWON", id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void InsertWonsale(E_SALES entities)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTWONSALE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@PRICE", entities.PRICE);
            cmd.Parameters.AddWithValue("@AMOUNT", entities.AMOUNT);
            cmd.Parameters.AddWithValue("@DATE", entities.DATE);
            cmd.Parameters.AddWithValue("@TOTAL", entities.TOTAL);
            cmd.Parameters.AddWithValue("@IDCUSTOMER", entities.IDCUSTOMERS);
            cmd.Parameters.AddWithValue("@PAY", entities.PAY);
            cmd.Parameters.AddWithValue("@IDWON", entities.IDWON);
            //  cmd.Parameters.AddWithValue("@IDPURCHASE", entities.IDPURCHASEF);
            //  cmd.Parameters.AddWithValue("@IDCATTLE", entities.IDCATTLE);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void ShowTotals(E_SALES entities)
        {
            SqlCommand cmd = new SqlCommand("SP_TOTALSALE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalcattle = new SqlParameter("@TOTALCATTLE", 0);
            totalcattle.Direction = ParameterDirection.Output;

            SqlParameter totalrace = new SqlParameter("@TOTALRACE", 0);
            totalrace.Direction = ParameterDirection.Output;

            SqlParameter totalcategory = new SqlParameter("@TOTALCATEGORY", 0);
            totalcategory.Direction = ParameterDirection.Output;
            SqlParameter total = new SqlParameter("@TOTAL", 0);
            total.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(totalcattle);
            cmd.Parameters.Add(totalrace);
            cmd.Parameters.Add(totalcategory);
            cmd.Parameters.Add(total);



            conexion.Open();
            cmd.ExecuteNonQuery();

            entities.TOTALCATTLE = cmd.Parameters["@TOTALCATTLE"].Value.ToString();
            entities.TOTALRACE = cmd.Parameters["@TOTALRACE"].Value.ToString();
            entities.TOTALCATEGORY = cmd.Parameters["@TOTALCATEGORY"].Value.ToString();
            entities.TOTALPURCHASE = cmd.Parameters["@TOTAL"].Value.ToString();


            conexion.Close();


        }
    }
}
