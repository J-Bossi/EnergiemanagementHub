
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Devart.Data.MySql;


namespace OpenResKit.Energy
{
    public class DBConnector

    {
        private MySqlConnection Connection;

        public bool IsConnect() {
    if (Connection == null) {
    var connectionString = string.Format ("Server=servdata; database={0}; UID=NovaRead; password=novaread", "nova2");
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
