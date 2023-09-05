using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace FrazierPawTracks.Database
{
    public class SQLiteHelper : IDisposable
    {
        private SQLiteConnection connection;

        public SQLiteHelper(string dbFilePath)
        {
            string connectionString = $"Data Source={dbFilePath};Version=3;";
            connection = new SQLiteConnection(connectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public SQLiteDataReader ExecuteQuery(string query, SQLiteParameter[] parameters = null)
        {
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteReader();
            }
        }

        public void ExecuteNonQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
