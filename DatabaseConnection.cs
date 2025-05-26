using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace NutriTrack
{
    public sealed class DatabaseConnection : IDisposable
    {
        private static readonly Lazy<DatabaseConnection> _instance =
            new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        private readonly string connectionString;
        private SqlConnection connection;

        private DatabaseConnection()
        {
            connectionString = "Server=.\\SQLEXPRESS;Database=NitriTrak;Pooling=true;Max Pool Size=100;Integrated Security=SSPI;TrustServerCertificate=True";
        }

        public static DatabaseConnection Instance => _instance.Value;

        private SqlConnection GetConnection()
        {
            if (connection == null)
                connection = new SqlConnection(connectionString);

            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }

        public async Task<SqlDataReader> ExecuteReaderAsync(string query, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(query, GetConnection());

            if (parameters != null && parameters.Length > 0)
                command.Parameters.AddRange(parameters);

            return await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
    
        public SqlDataReader ExecuteReader(string query, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(query, GetConnection());
    
            if (parameters != null && parameters.Length > 0)
                command.Parameters.AddRange(parameters);
    
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }


        public void Dispose()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}