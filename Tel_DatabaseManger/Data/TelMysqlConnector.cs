using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tel_DatabaseManger.providers;

namespace Tel_DatabaseManger.Data
{
    public class TelMysqlConnector : ITelIDbProvider
    {
        public MySqlConnection conn;
        public IDbConnection Connection(string connectionString)
        {
                conn = new MySqlConnection(connectionString);
                return conn;
        }
        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new MySqlCommand(cmdText, (MySqlConnection)conn);
        }

        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new MySqlDataAdapter((MySqlCommand)command);
        }

    }
}
