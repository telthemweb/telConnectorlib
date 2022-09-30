using System;
using System.Configuration;
namespace TelDatabaseManger.Data
{
    public class DatabaseConfiguration
    {
        Configuration config;
        public DatabaseConfiguration()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string GetConnectionString(string key)
        {
           string varkeyvalue =string.Empty;
           var keyvalue= config.ConnectionStrings.ConnectionStrings[key]?.ConnectionString;
            if (!string.IsNullOrEmpty(keyvalue) || !string.IsNullOrWhiteSpace(keyvalue))
            {
                varkeyvalue= config.ConnectionStrings.ConnectionStrings[key]?.ConnectionString;
            }
            else
            {
                varkeyvalue = "no configurations";
            }

            return varkeyvalue;
        }

      
        public void TelSaveConnectionString(string key, string value)
        {

                ConfigurationManager.RefreshSection("connectionStrings");
                ConnectionStringSettings database = new ConnectionStringSettings();
                database.ConnectionString = value;
                database.Name = key;
                database.ProviderName = "MySql.Data.MySqlClient";
                config.ConnectionStrings.ConnectionStrings.Add(database);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
        }

        public void RemoveConnectionString(string key)
        {
            ConnectionStringSettings database = new ConnectionStringSettings();
            database.Name = key;
            config.ConnectionStrings.ConnectionStrings.Remove(database);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }


        public void TelSaveConnectionStringCLI(string dbprovider, string key, string value)
        {
            ConfigurationManager.RefreshSection("telthemString");
            config.AppSettings.Settings.Add("databaseType", dbprovider);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("telthemString");
        }

        public string GetConnectionStringCL(string key)
        {
            string result = "";
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? "0";
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return result;

        }

        public void AddUpdateAppSettingsCL(string key, string value)
        {
            try
            {

                var settings = config.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

    }
}
