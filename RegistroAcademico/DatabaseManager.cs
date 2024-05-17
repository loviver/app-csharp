using MySql.Data.MySqlClient;
using System;
using System.Data;

public class DatabaseManager
{
    private string connectionString;

    public DatabaseManager(string server, string database, string userId, string password)
    {
        connectionString = $"server={server};user={userId};database={database};password={password};";
    }

    private MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public DataTable ExecuteQuery(string sql, Dictionary<string, object> parameters = null)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                DataTable dt = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                return dt;
            }
        }
    }

    public int ExecuteNonQuery(string sql, Dictionary<string, object> parameters)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
                return cmd.ExecuteNonQuery();
            }
        }
    }
}