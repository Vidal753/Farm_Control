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
    public class D_SUPPLIER
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_SUPPLIER> SupplierList(string Search,String LastName,String Cedula)
        {
            SqlDataReader ReadRow;
            SqlCommand cmd = new SqlCommand("SP_SEARCHSUPPLIER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@SEARCH", Search);
            cmd.Parameters.AddWithValue("@LASTNAME", LastName);
            cmd.Parameters.AddWithValue("@CEDULA", Cedula);

            ReadRow = cmd.ExecuteReader();

            List<E_SUPPLIER> Listing = new List<E_SUPPLIER>();


            while (ReadRow.Read())
            {
                Listing.Add(new E_SUPPLIER
                {
                    IDSUPPLIER1 = ReadRow.GetInt32(0),
                    CEDULA1 = ReadRow.GetString(1),
                    NAMES1 = ReadRow.GetString(2),
                    LASTNAME1 = ReadRow.GetString(3),
                    PHONE1 = ReadRow.GetString(4),
                    ADRESS1 = ReadRow.GetString(5),


                });
            }
            conexion.Close();
            ReadRow.Close();
            return Listing;
        }

        public void DeleteSupplier(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETESUPPLIER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSUPPLIER",id);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void UpdateSupplier(E_SUPPLIER entities)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATESUPPLIER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSUPPLIER", entities.IDSUPPLIER1);
            cmd.Parameters.AddWithValue("@CEDULA", entities.CEDULA1);
            cmd.Parameters.AddWithValue("@NAMES", entities.NAMES1);
            cmd.Parameters.AddWithValue("@LASTNAME", entities.LASTNAME1);
            cmd.Parameters.AddWithValue("@PHONE", entities.PHONE1);
            cmd.Parameters.AddWithValue("@DIRECTION", entities.ADRESS1);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void InsertSupplier(E_SUPPLIER entities)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTSUPPLIER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

           
            cmd.Parameters.AddWithValue("@CEDULA", entities.CEDULA1);
            cmd.Parameters.AddWithValue("@NAMES", entities.NAMES1);
            cmd.Parameters.AddWithValue("@LASTNAME", entities.LASTNAME1);
            cmd.Parameters.AddWithValue("@PHONE", entities.PHONE1);
            cmd.Parameters.AddWithValue("@DIRECTION", entities.ADRESS1);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
