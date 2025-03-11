using Microsoft.Data.SqlClient;
using RouteBeheerBL.interfaces;
using RouteBeheerBL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteBeheerDB.Repository
{
    public class NetwerkRepository : INetwerkRepository
    {
        private string connectionString;

        public NetwerkRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddLocation(Locatie location)
        {
            string query = "INSERT INTO locatie(naam) output INSERTED.ID VALUES(@naam)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@naam", location.Name);
                connection.Open();
                location.id = (int)cmd.ExecuteScalar();
            }
        }
        public void UpdateLocatie(Locatie location)
        {
            string query = "UPDATE locatie Set naam = @naam WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@naam", location.Name);
                cmd.Parameters.AddWithValue("@id", location.id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool HasLocationName(Locatie location)
        {
            string query = "SELECT count(*) FROM locatie WHERE naam = @naam";
            using(SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@naam", location.Name);
                connection.Open();
                if ((int)cmd.ExecuteScalar() == 0) return false; else return true;
            }
        }
        public bool HasLocationId(int id)
        {
            string query = "SELECT count(*) FROM locatie WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                if ((int)cmd.ExecuteScalar() == 0) return false; else return true;
            }
        }
        

    }
}
