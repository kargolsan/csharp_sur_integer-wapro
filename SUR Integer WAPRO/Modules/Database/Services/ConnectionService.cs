using SUR_Integer_WAPRO.Modules.Configuration.Services;
using System;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Database.Services
{
    class ConnectionService
    {
        /// <summary>
        /// Get connection string to dataqbase from settings user of application
        /// </summary>
        /// <returns></returns>
        public static string getConnectionString()
        {
            string dataSource = ConfigurationService.GetConfig<string>("WFMAG_DATASOURCE");
            string database = ConfigurationService.GetConfig<string>("WFMAG_DATABASE");
            string userName = ConfigurationService.GetConfig<string>("WFMAG_USERNAME");
            string password = ConfigurationService.GetConfig<string>("WFMAG_PASSWORD");

            return string.Format(ConfigurationService.GetConfig<string>("WFMAG_CONNECTIONSTRING_PATTERN"),
                dataSource, database, userName, password);
        }

        /// <summary>
        /// Check is exist connection with database
        /// </summary>
        /// <param name="dataSource">data source of WAPRO</param>
        /// <param name="database">database name<</param>
        /// <param name="userName">user name for SQL authenticate<</param>
        /// <param name="password">password for SQL authenticate</param>
        /// <returns></returns>
        public static bool checkConnection(string dataSource, string database, string userName, string password)
        {

            string connectionString = string.Format(ConfigurationService.GetConfig<string>("WFMAG_CONNECTIONSTRING_PATTERN"),
                dataSource, database, userName, password);

            try
            {
                TablesDataContext dbContext = new TablesDataContext(connectionString);

                dbContext.Connection.ConnectionString = connectionString;

                dbContext.Connection.Open();

                dbContext.Connection.Close();

                return true;

            } catch (Exception ex)
            {
                MessageBox.Show(string.Format("Błąd w czasie połączenia z bazą danych. Szczegóły:\n{0}", ex.Message), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
