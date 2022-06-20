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
    public class D_DASHBOARD
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public void ShowTotals(E_DASHBOARD entities)
        {
            SqlCommand cmd = new SqlCommand("DASHBOARD", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalsale = new SqlParameter("@SALES", 0);
            totalsale.Direction = ParameterDirection.Output;

            SqlParameter totalpurchase = new SqlParameter("@PURCHASE", 0);
            totalpurchase.Direction = ParameterDirection.Output;

            SqlParameter totalpaywork = new SqlParameter("@PAY", 0);
            totalpaywork.Direction = ParameterDirection.Output;


            SqlParameter totalmilksale = new SqlParameter("@MILKSALE", 0);
            totalmilksale.Direction = ParameterDirection.Output;


            SqlParameter customers = new SqlParameter("@CUSTOMERS", 0);
            customers.Direction = ParameterDirection.Output;

            SqlParameter supplier = new SqlParameter("@SUPPLIER", 0);
            supplier.Direction = ParameterDirection.Output;

            SqlParameter workers = new SqlParameter("@WORKERS", 0);
            workers.Direction = ParameterDirection.Output;

            SqlParameter cattle = new SqlParameter("@CATTLES", 0);
            cattle.Direction = ParameterDirection.Output;

            SqlParameter money = new SqlParameter("@MONEY", 0);
            money.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(totalsale);
            cmd.Parameters.Add(totalpurchase);
            cmd.Parameters.Add(totalpaywork);
            cmd.Parameters.Add(totalmilksale);
            cmd.Parameters.Add(customers);
            cmd.Parameters.Add(supplier);
            cmd.Parameters.Add(cattle);
            cmd.Parameters.Add(workers);
            cmd.Parameters.Add(money);

            conexion.Open();
            cmd.Parameters.AddWithValue("@DATE1", entities.DATE1);
            cmd.Parameters.AddWithValue("@DATE2", entities.DATE2);
            cmd.ExecuteNonQuery();

            entities.TOTALSALE = cmd.Parameters["@SALES"].Value.ToString();
            entities.TOTALMILKSALE = cmd.Parameters["@MILKSALE"].Value.ToString();
            entities.TOTALPAY = cmd.Parameters["@PAY"].Value.ToString();
            entities.TOTALPURCHASE = cmd.Parameters["@PURCHASE"].Value.ToString();
            entities.TOTALCUSTOMERS = cmd.Parameters["@CUSTOMERS"].Value.ToString();
            entities.TOTALSUPPLIER = cmd.Parameters["@SUPPLIER"].Value.ToString();
            entities.TOTALWOKERS = cmd.Parameters["@WORKERS"].Value.ToString();
            entities.TOTALCATTLE = cmd.Parameters["@CATTLES"].Value.ToString();
            entities.MONEY = cmd.Parameters["@MONEY"].Value.ToString();

            conexion.Close();


        }
    }
}
