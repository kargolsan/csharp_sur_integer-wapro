using SUR_Integer_WAPRO.Modules.Database.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.StorageDocuments.Services
{
    class StorageDocumentsService
    {
        /// <summary>
        /// Get all storage documents from database without async
        /// </summary>
        /// <param name="parameters">parameters for filter articles</param>
        /// <returns>Contractors in table of linq</returns>
        public IQueryable<DOKUMENT_MAGAZYNOWY> getStorageDocuments(Dictionary<string, object> parameters = null)
        {

            try
            {
                TablesDataContext dbContext = new TablesDataContext(ConnectionService.getConnectionString());

                if (existParameter("contractor", parameters) && existParameter("typeDocuments", parameters)) 
                {
                    return dbContext.DOKUMENT_MAGAZYNOWies.Where(x => x.ID_KONTRAHENTA == (decimal)parameters["contractor"]).Where(x => x.RODZAJ_DOKUMENTU == (string)parameters["typeDocuments"]);
                }

                return from DOKUMENT_MAGAZYNOWY in dbContext.DOKUMENT_MAGAZYNOWies
                       select DOKUMENT_MAGAZYNOWY;

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Nie można pobrać danych z bazy danych. Szczegóły błędu:\n {0}", ex.Message), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        /// <summary>
        /// Check is exist parameter
        /// </summary>
        /// <typeparam name="T">type of parameter</typeparam>
        /// <param name="parameters">parameters for filter articles</param>
        /// <returns>object with value of parameter</returns>
        public bool existParameter(string parameterKey, Dictionary<string, object> parameters = null)
        {

            try
            {
                if (parameters[parameterKey].ToString() != "")
                {
                    return true;
                }
            }
            catch { }
            return false;
        }
    }
}
