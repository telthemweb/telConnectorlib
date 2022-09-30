using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tel_DatabaseManger.providers;

namespace Tel_DatabaseManger.Data
{
    class TelPostgres : ITelIDbProvider
    {
        public IDbConnection Connection(string connectionString)
        {
            return new NpgsqlConnection(connectionString);
        }
        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new NpgsqlCommand(cmdText, (NpgsqlConnection)conn);
        }

        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new NpgsqlDataAdapter((NpgsqlCommand)command);
        }
    }
}
