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
     public class D_PURCHASE
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable PurchaseList()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_PURCHASELIST", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }
        public DataTable SearchPurchase(E_PURCHASE entities, E_SUPPLIER supplier)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_SEARCHPURCHASES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NAME", supplier.NAMES1);
            cmd.Parameters.AddWithValue("@CODE", entities.CODE);
            cmd.Parameters.AddWithValue("@PAY", entities.PAY);
           

            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public void UpdatePurchase(E_PURCHASE entities)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATEPURCHASE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPURCHASE", entities.IDPURCHASE);
            cmd.Parameters.AddWithValue("@DATE", entities.DATE);
            cmd.Parameters.AddWithValue("@TOTAL", entities.TOTAL);
            cmd.Parameters.AddWithValue("@IDSUPPLIER", entities.IDSUPPLIER);
            cmd.Parameters.AddWithValue("@PAY", entities.PAY);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void DeletePurchase(int id)
        {

            SqlCommand cmd = new SqlCommand("SP_DELETEPURCHASE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPURCHASE", id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void InsertPurchase(E_PURCHASE entities)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTPURCHASE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@DATE", entities.DATE);
            cmd.Parameters.AddWithValue("@TOTAL", entities.TOTAL);
            cmd.Parameters.AddWithValue("@IDSUPPLIER", entities.IDSUPPLIER);
            cmd.Parameters.AddWithValue("@PAY", entities.PAY);
            cmd.Parameters.AddWithValue("@AMOUNT", entities.AMOUNT);
          //  cmd.Parameters.AddWithValue("@IDPURCHASE", entities.IDPURCHASEF);
          //  cmd.Parameters.AddWithValue("@IDCATTLE", entities.IDCATTLE);
            cmd.Parameters.AddWithValue("@PRICEKG", entities.PRICEKG);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void ShowTotals(E_PURCHASE entities)
        {
            SqlCommand cmd = new SqlCommand("SP_TOTALPURCHASE", conexion);
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
