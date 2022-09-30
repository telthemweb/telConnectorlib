using System;
using System.Windows.Forms;
using Tel_DatabaseManger.Data;
using TelDatabaseManger.Data;
using TelDatabaseManger.Helper;
using TelDatabaseManger.TelEnum;

namespace Tel_DatabaseManger
{
    public partial class TelDbConfigurationfm : Form
    {
        public TelDbConfigurationfm()
        {
            InitializeComponent();
        }

        private void TelDbConfigurationfm_Load(object sender, EventArgs e)
        {
            //
            telcmbDbType.Items.Clear();
            telcmbDbType.Items.Add(DatabaseType.MYSQL);
            telcmbDbType.Items.Add(DatabaseType.MSSQL);
            telcmbDbType.Items.Add(DatabaseType.NPGSQL);
            telcmbDbType.Items.Add(DatabaseType.ORACLE);
            telcmbDbType.Items.Add(DatabaseType.SQLITE);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string passwordvalue = string.Empty;
                TelHelpersdb datmhelper = new TelHelpersdb();
                if (telcmbDbType.Text == "MYSQL")
                {
                    
                    if (string.IsNullOrEmpty(teltxtPassword.Text) && string.IsNullOrWhiteSpace(teltxtPassword.Text))
                    {



                        passwordvalue = string.Format("server={0};database={1};userid={2};password=;SSL Mode=None;Port=3306;Connection Timeout=600", teltxtServername.Text, teltxtDatabaseName.Text, teltxtUsername.Text);

                    }
                    else
                    {
                        passwordvalue = string.Format("server={0};database={1};userid={2};password={3};SSL Mode=None;Port=3306;Connection Timeout=600", teltxtServername.Text, teltxtDatabaseName, teltxtUsername.Text, teltxtPassword.Text);

                    }
                }
                else if (telcmbDbType.Text == "MSSQL")
                {
                    passwordvalue = string.Format("Server={0};Database={1};User Id={2};Password={3}", teltxtServername.Text, teltxtDatabaseName.Text, teltxtUsername.Text, teltxtPassword.Text);
                }
                else if (telcmbDbType.Text == "NPGSQL")
                {
                    //SQLITE Host=localhost;Username=postgres;Password=s$cret;Database=testdb"
                    passwordvalue = string.Format("Host={0};Database={1};Username={2};Password={3}", teltxtServername.Text, teltxtDatabaseName.Text, teltxtUsername.Text, teltxtPassword.Text);
                }
                else if (telcmbDbType.Text == "ORACLE")
                {
                    passwordvalue = string.Format("Server={0};Database={1};User Id={2};Password={3}", teltxtServername.Text, teltxtDatabaseName.Text, teltxtUsername.Text, teltxtPassword.Text);
                }
                
                else if (telcmbDbType.Text == "SQLITE")
                {
                    MessageBox.Show("This Database library is Coming soon please keep checking ........", "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }






                string connectionString = datmhelper.TelEncryptData(passwordvalue);
                


                DatabaseConfiguration databaseconfig = new DatabaseConfiguration();
                string keyname = "constring";
                databaseconfig.TelSaveConnectionStringCLI(datmhelper.TelEncryptData(telcmbDbType.Text), keyname, connectionString);


                MessageBox.Show("New schedule time has been successfully saved  (*v*)!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                string passwordvalue = string.Empty;
                TelHelpersdb datmhelper = new TelHelpersdb();
                if (telcmbDbType.Text == "MYSQL")
                {

                    if (string.IsNullOrEmpty(teltxtPassword.Text) && string.IsNullOrWhiteSpace(teltxtPassword.Text))
                    {



                        passwordvalue = string.Format("server={0};database={1};userid={2};password=;SSL Mode=None;Port=3306;Connection Timeout=600", teltxtServername.Text, teltxtDatabaseName.Text, teltxtUsername.Text);

                    }
                    else
                    {
                        passwordvalue = string.Format("server={0};database={1};userid={2};password={3};SSL Mode=None;Port=3306;Connection Timeout=600", teltxtServername.Text, teltxtDatabaseName, teltxtUsername.Text, teltxtPassword.Text);

                    }
                }
                else if (telcmbDbType.Text == "MSSQL")
                {
                    passwordvalue = string.Format("Server={0};Database={1};User Id={2};Password={3}", teltxtServername.Text, teltxtDatabaseName.Text, teltxtUsername.Text, teltxtPassword.Text);
                }
                else if (telcmbDbType.Text == "NPGSQL")
                {
                    //SQLITE Host=localhost;Username=postgres;Password=s$cret;Database=testdb"
                    passwordvalue = string.Format("Host={0};Database={1};Username={2};Password={3}", teltxtServername.Text, teltxtDatabaseName.Text, teltxtUsername.Text, teltxtPassword.Text);
                }
                else if (telcmbDbType.Text == "ORACLE")
                {
                    passwordvalue = string.Format("Server={0};Database={1};User Id={2};Password={3}", teltxtServername.Text, teltxtDatabaseName.Text, teltxtUsername.Text, teltxtPassword.Text);
                }

                else if (telcmbDbType.Text == "SQLITE")
                {
                    MessageBox.Show("This Database library is Coming soon please keep checking ........", "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string connectionString = passwordvalue;
                TelSqlHelper helper = new TelSqlHelper(telcmbDbType.Text, connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test connection succeeded.", "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
