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
    public class D_JOB
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_JOB> JobList(string Search)
        {
            SqlDataReader ReadRow;
            SqlCommand cmd = new SqlCommand("SP_SEARCHJOB", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@SEARCH", Search);

            ReadRow = cmd.ExecuteReader();

            List<E_JOB> Listing = new List<E_JOB>();


            while (ReadRow.Read())
            {
                Listing.Add(new E_JOB
                {
                    IDJOB = ReadRow.GetInt32(0),
                    JOB = ReadRow.GetString(1),
                    DESCRIP = ReadRow.GetString(2),


                });
            }
            conexion.Close();
            ReadRow.Close();
            return Listing;
        }
        public void DeleteJob(E_JOB entities)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETEJOB", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDJOB", entities.IDJOB);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void UpdateJob(E_JOB entities)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATEJOB", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDJOB", entities.IDJOB);
            cmd.Parameters.AddWithValue("@JOB", entities.JOB);
            cmd.Parameters.AddWithValue("@DESCRIP", entities.DESCRIP);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void InsertJob(E_JOB entities)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTJOB", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@JOB", entities.JOB);
            cmd.Parameters.AddWithValue("@DESCRIP", entities.DESCRIP);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
