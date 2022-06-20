using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ENTITIES_LAYER;

namespace DATA_LAYER
{
    public class D_RACE
    {
        SqlConnection connection =new  SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        
        public List<E_RACE>ListRace(String Search)
        {
            SqlDataReader ReadRow;
            SqlCommand cmd = new SqlCommand("SP_SEARCHRACE", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@SEARCH", Search);

            ReadRow = cmd.ExecuteReader();

            List<E_RACE> Listing = new List<E_RACE>();


            while (ReadRow.Read())
            {
                Listing.Add(new E_RACE
                {
                    IDRACE1 = ReadRow.GetInt32(0),
                    CODE1 = ReadRow.GetString(1),
                    RACE1 = ReadRow.GetString(2),


                });
            }
            connection.Close();
            ReadRow.Close();
            return Listing;
        }

        public void DeleteRace(E_RACE entites)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETERACE",connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDRACE",entites.IDRACE1);

            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void UpdateRace(E_RACE entities)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATERACE", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDRACE", entities.IDRACE1);
            cmd.Parameters.AddWithValue("@RACE", entities.RACE1);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void InsertRace(E_RACE entities)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTRACE", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@RACE", entities.RACE1);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
