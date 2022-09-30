using System.Data;
using Tel_DatabaseManger;
using TelDatabaseManger.Data;
using TelDatabaseManger.Helper;

namespace TelDatabaseManger
{
    /// <summary>
    ///   ALL DATABASE TABLE TRANSACTION
    ///   Author:  Innocent Tauzeni
    ///   06/09/2022
    ///   HATCLIFFE
    ///   One day i will conquer the world: God have mercy on me!
    ///   My vision will not die but produce quality results that will help whole world
    ///   with God nothing is impossible
    ///   Telthemweb to the world
    /// </summary>
    /// <returns></returns>
    public class TelSqlTransaction 
    {
        TelDatabaseConfigCL telDatabaseConfigCL = new TelDatabaseConfigCL();
       
        IDbCommand cmd;
        IDbDataAdapter da;

        TelHelpersdb datmhelper = new TelHelpersdb();

        public DataTable TelRetrieve(string query)
        {
            try
            {
                

                cmd = telDatabaseConfigCL.TelCommand(query);
                da = (IDbDataAdapter)telDatabaseConfigCL.TeldataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt =new DataTable();
                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
                return dt;
            }
            catch
            {
                return null;
            }

        }




        /// <summary>
        /// Insert new record
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool TelInsert(string query)
        {
            try
            {
                int numRows = 0;
                cmd = telDatabaseConfigCL.TelCommand(query);
                numRows = cmd.ExecuteNonQuery();
                if (numRows > 0)
                { return true; }
                else
                { return false; }
            }
            catch
            { return false; }

        }

        /// <summary>
        /// Insert new record using stored procedure
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>

        public bool TelInsertStoredProcedure(string query)
        {
            try
            {
                int numRows = 0;
                cmd = telDatabaseConfigCL.TelCommand(query);
                cmd.CommandType = CommandType.StoredProcedure;
                numRows = cmd.ExecuteNonQuery();
                if (numRows > 0)
                { return true; }
                else
                { return false; }
            }
            catch
            { return false; }

        }



        /// <summary>
        /// Update record
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool TelUpdate(string query)
        {
            try
            {
                int numRows = 0;
                cmd = telDatabaseConfigCL.TelCommand(query);
                numRows = cmd.ExecuteNonQuery();
                if (numRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// delete a record
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool TelDelete(string query)
        {
            try
            {
                int numRows = 0;
                cmd = telDatabaseConfigCL.TelCommand(query);
                numRows = cmd.ExecuteNonQuery();
                if (numRows > 0)
                { return true; }
                else
                { return false; }
            }
            catch
            { return false; }

        }



        /// <summary>
        /// This will open the configuration form 
        /// </summary>
        /// <param name="trigger"></param>
        public void telshowConfigurationForm(bool trigger)
        {
            if (trigger == true)
            {
                TelDbConfigurationfm telform = new TelDbConfigurationfm();
                telform.ShowDialog();
            }
        }

















    }
}
