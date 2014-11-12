using Devart.Data.MySql;

namespace OpenResKit.Energy
{
    public class DBConnector

    {
        private MySqlConnection Connection;

        public bool IsConnect()
        {
            if (Connection == null)
            {
                string connectionString = string.Format(
                    "Server=servdata; database={0}; UID=NovaRead; password=novaread", "nova2");
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
            }
            return true;
        }

        public MySqlConnection GetConnection()
        {
            return Connection;
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}