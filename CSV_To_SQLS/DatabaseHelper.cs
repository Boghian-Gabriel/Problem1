using CSV_To_SQLS.StoreProcedures;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSV_To_SQLS
{
    public class DatabaseHelper
    {

        private static readonly string  connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMovie"].ToString();

        private readonly SqlConnection _connection;

        public  DatabaseHelper() 
        {
            _connection = new SqlConnection(connectionString);
        }

        private void Connected()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }     
        }

        private void Disconected()
        {
            if(_connection.State == ConnectionState.Open) 
            {
                _connection.Close();
            }
        }

        #region "Store procedure: Insert movie"
        public void InsertData(Movie movie)
        {
            try
            {
                //Connected();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(StoreProceduresName.SP_InsertMovie, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = movie.Title;
                        command.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = movie.Genre;
                        command.Parameters.Add("@ReleaseDate", SqlDbType.Date).Value = movie.ReleaseDate;

                        command.ExecuteNonQuery();
                    }
                }
                //Disconected();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        #endregion

        #region "Store procedure: GetMovies
        //to do....
        #endregion
    }
}
