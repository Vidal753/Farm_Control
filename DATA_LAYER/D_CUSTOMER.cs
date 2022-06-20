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
    public class D_CUSTOMER
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_CUSTOMER> CustomerList(string Search, String LastName, String Cedula)
        {
            SqlDataReader ReadRow;
            SqlCommand cmd = new SqlCommand("SP_SEARCHCUSTOMER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NAME", Search);
            cmd.Parameters.AddWithValue("@LASTNAME", LastName);
            cmd.Parameters.AddWithValue("@CEDULA", Cedula);

            ReadRow = cmd.ExecuteReader();

            List<E_CUSTOMER> Listing = new List<E_CUSTOMER>();


            while (ReadRow.Read())
            {
                Listing.Add(new E_CUSTOMER
                {
                    IDCUSTOMER = ReadRow.GetInt32(0),
                    CEDULA = ReadRow.GetString(1),
                    NAMES = ReadRow.GetString(2),
                    LASTNAME = ReadRow.GetString(3),
                    PHONE = ReadRow.GetString(4),
                    ADRESS = ReadRow.GetString(5),


                });
            }
            conexion.Close();
            ReadRow.Close();
            return Listing;
        }

        public void DeleteCustomer(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETECUSTOMER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCUSTOMER", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void UpdateCustomer(E_CUSTOMER entities)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATECUSTOMER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCUSTOMER", entities.IDCUSTOMER);
            cmd.Parameters.AddWithValue("@CEDULA", entities.CEDULA);
            cmd.Parameters.AddWithValue("@NAMES", entities.NAMES);
            cmd.Parameters.AddWithValue("@LASTNAME", entities.LASTNAME);
            cmd.Parameters.AddWithValue("@PHONE", entities.PHONE);
            cmd.Parameters.AddWithValue("@DIRECTION", entities.ADRESS);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void InsertCustomer(E_CUSTOMER entities)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTCUSTOMER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@CEDULA", entities.CEDULA);
            cmd.Parameters.AddWithValue("@NAMES", entities.NAMES);
            cmd.Parameters.AddWithValue("@LASTNAME", entities.LASTNAME);
            cmd.Parameters.AddWithValue("@PHONE", entities.PHONE);
            cmd.Parameters.AddWithValue("@DIRECTION", entities.ADRESS);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
