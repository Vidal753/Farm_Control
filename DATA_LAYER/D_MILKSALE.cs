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
    public class D_MILKSALE
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable MilkList()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_LISTMILKSALE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }
        public DataTable SearchMilkSale(E_MILKSALE entities, E_CUSTOMER customer)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_SEARCHMILKSALE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@DATEPURCHASE", entities.DATEPURCHASE);
            cmd.Parameters.AddWithValue("@NAME", customer.NAMES);
            cmd.Parameters.AddWithValue("@LASTNAME", customer.LASTNAME);

            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public void UpdateMilkSale(E_MILKSALE entities)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATESALE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDMILK", entities.IDMILKSALE);
            cmd.Parameters.AddWithValue("@AMOUNT", entities.AMOUNT);
            cmd.Parameters.AddWithValue("@PRICE", entities.PRICE);
            cmd.Parameters.AddWithValue("@DATEPURCHASE", entities.DATEPURCHASE);
            cmd.Parameters.AddWithValue("@IDCUSTOMERS", entities.IDCUSTOMERS);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void DeleteMilkSale(int id)
        {

            SqlCommand cmd = new SqlCommand("SP_DELETESALE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDMILK", id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void InsertMilkSale(E_MILKSALE entities)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTSALE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@AMOUNT", entities.AMOUNT);
            cmd.Parameters.AddWithValue("@PRICE", entities.PRICE);
            cmd.Parameters.AddWithValue("@DATEPURCHASE", entities.DATEPURCHASE);
            cmd.Parameters.AddWithValue("@IDCUSTOMERS", entities.IDCUSTOMERS);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void ShowTotals(E_MILKSALE entities)
        {

            SqlCommand cmd = new SqlCommand("SP_TOTALSALES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter amounttotal = new SqlParameter("@AMOUNTTOTAL", 0);
            amounttotal.Direction = ParameterDirection.Output;

            SqlParameter price = new SqlParameter("@PRICE", 0);
            price.Direction = ParameterDirection.Output;

            SqlParameter customer = new SqlParameter("@CUSTOMER", 0);
            customer.Direction = ParameterDirection.Output;

            SqlParameter total = new SqlParameter("@TOTAL", 0);
            total.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(amounttotal);
            cmd.Parameters.Add(price);
            cmd.Parameters.Add(customer);
            cmd.Parameters.Add(total);

            conexion.Open();
            cmd.Parameters.AddWithValue("@DATE", entities.DATE);
            cmd.ExecuteNonQuery();

            entities.AMOUNTTOTAL = cmd.Parameters["@AMOUNTTOTAL"].Value.ToString();
            entities.TOTALPRICE = cmd.Parameters["@PRICE"].Value.ToString();
            entities.CUSTOMER = cmd.Parameters["@CUSTOMER"].Value.ToString();
            entities.TOTALS = cmd.Parameters["@TOTAL"].Value.ToString();

            conexion.Close();

        }
    }
}
