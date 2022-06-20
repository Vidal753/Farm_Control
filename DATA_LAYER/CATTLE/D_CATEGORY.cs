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
    public class D_CATEGORY
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_CATEGORY>CategoryList(string Search)
        {
            SqlDataReader ReadRow;
            SqlCommand cmd = new SqlCommand("SP_SEARCHCATEGORY",conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@SEARCH",Search);

            ReadRow = cmd.ExecuteReader();

            List<E_CATEGORY> Listing = new List<E_CATEGORY>();


            while (ReadRow.Read())
            {
                Listing.Add(new E_CATEGORY
                {
                    IDCATEGORY1 = ReadRow.GetInt32(0),
                    CODIGO1 = ReadRow.GetString(1),
                    CATEGORY1 = ReadRow.GetString(2),
                  

                });
            }
            conexion.Close();
            ReadRow.Close();
            return Listing;
        }
        public void DeleteCategory(E_CATEGORY entities)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETECATEGORY",conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCATEGORY",entities.IDCATEGORY1);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditCategory(E_CATEGORY entities)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITCATEGORY", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCATEGORY", entities.IDCATEGORY1);
            cmd.Parameters.AddWithValue("@CATEGORY",entities.CATEGORY1);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void SaveCategory(E_CATEGORY entities)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTCATEGORY", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

           
            cmd.Parameters.AddWithValue("@CATEGORY", entities.CATEGORY1);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


    }
}
