using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tel_DatabaseManger.Data;
using TelDatabaseManger.TelEnum;
using TelDatabaseManger.Helper;
using Oracle.ManagedDataAccess.Client;

namespace TelDatabaseManger.Data
{
    public class TelDatabaseConfigCL
    {
        
        DatabaseConfiguration setting = new DatabaseConfiguration();
        TelHelpersdb datmhelper = new TelHelpersdb();








        TelMSSQLConnector telMSSQLConnector = new TelMSSQLConnector();
        TelMysqlConnector telMysqlConnector = new TelMysqlConnector();
        TelPostgres telPostgres = new TelPostgres();
        TelORACLEConnecter telORACLEConnecter = new TelORACLEConnecter();
        IDbConnection conn;
        IDbCommand cmd;
        IDataAdapter da;
        DatabaseType databaseTypes;

        public IDbConnection TestconnectDatabase(string servertype, string connectionString)
        {

            if (conn == null)
            {

               

                if (servertype =="MYSQL")
                {
                    if (conn == null)
                    {
                        conn = telMysqlConnector.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                }
                else if (servertype == "MSSQL")
                {
                    if (conn == null)
                    {
                        conn = telMSSQLConnector.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                }
                else if (servertype == "NPGSQL") //Npgsql
                {

                    if (conn == null)
                    {
                        conn = telPostgres.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                }

                else if (servertype == "ORACLE") //ORACLE
                {

                    if (conn == null)
                    {
                        conn = telPostgres.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                }
            }
          
            return conn;
        }
        public IDbConnection TelConnection()
        {
            var cstr = datmhelper.TelDecryptData(setting.GetConnectionStringCL("constring"));
            string DbProviderPlugin = datmhelper.TelDecryptData(ConfigurationManager.AppSettings["databaseType"]);
            if (DbProviderPlugin == "MYSQL")
            {
                if (conn == null)
                {
                    conn = telMysqlConnector.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

            }
            else if (DbProviderPlugin == "MSSQL")
            {
                if (conn == null)
                {
                    conn = telMSSQLConnector.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            else if (DbProviderPlugin == "NPGSQL") //Npgsql
            {

                if (conn == null)
                {
                    conn = telPostgres.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }

            else if (DbProviderPlugin == "ORACLE") //Npgsql
            {

                if (conn == null)
                {
                    conn = telPostgres.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            return conn;
        }







        /*
    |=============================================================================
    |
    |                 Create Company database Dynamically  : From Company Name
    |
    |=============================================================================
    */
        public void CreateDatabase(string dbname, string servertype, string connectionString) 
        {
            try
            {
                string query = "CREATE DATABASE " + dbname;
                if (servertype == "MYSQL")
                {
                    cmd = telMysqlConnector.Command(query, TestconnectDatabase(servertype, connectionString));
                }
                else if (servertype == "MSSQL")
                {
                    cmd = telMSSQLConnector.Command(query, TestconnectDatabase(servertype, connectionString));
                }
                else if (servertype == "NPGSQL")
                {
                    cmd = telPostgres.Command(query, TestconnectDatabase(servertype, connectionString));
                }

                else if (servertype == "ORACLE")
                {
                    cmd = telORACLEConnecter.Command(query, TestconnectDatabase(servertype, connectionString));
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        /*
        |==========================================================================
        |
        |                 Importing All Tables to the new Company Database
        |
        |=======================================================================
        */
        public  void TelImportBDStoredProcedureDb(string query)
        {
            try
            {

                cmd = TelCommand(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }


        
        public  void TelImportAllDBView(string query)
        {
            try { 
                cmd = TelCommand(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }


        public IDbCommand TelCommand(string query)
        {
            
            string DbProviderPlugin = datmhelper.TelDecryptData(ConfigurationManager.AppSettings["databaseType"]);
            if (DbProviderPlugin == "MYSQL")
            {

                cmd = telMysqlConnector.Command(query, TelConnection());


            }
            else if (DbProviderPlugin == "MSSQL")
            {

                cmd = telMSSQLConnector.Command(query, TelConnection());

            }
            else if (DbProviderPlugin == "NPGSQL")
            {
                cmd = telPostgres.Command(query, TelConnection());
            }
            
            else if (DbProviderPlugin == "ORACLE")
            {
                cmd = telORACLEConnecter.Command(query, TelConnection());
            }
            return cmd;
        }

        public IDataAdapter TeldataAdapter(IDbCommand command)
        {
            string DbProviderPlugin = datmhelper.TelDecryptData(ConfigurationManager.AppSettings["databaseType"]);
            if (DbProviderPlugin == "MYSQL")
            {

                da = telMysqlConnector.DataAdapter((MySqlCommand)command);


            }
            else if (DbProviderPlugin == "MSSQL")
            {

                da = telMSSQLConnector.DataAdapter((SqlCommand)command);

            }
            else if (DbProviderPlugin == "NPGSQL")
            {
                da = telPostgres.DataAdapter((NpgsqlCommand)command);
            }

            else if (DbProviderPlugin == "ORACLE")
            {
                da = telORACLEConnecter.DataAdapter((OracleCommand)command);
            }
            return da;

        }


















    }

    public enum DatabaseTypeLoc
    {
        MYSQL,
        ORACLE,
        MSSQL,
        SQLITE,
        POSTGRES
    }
}
