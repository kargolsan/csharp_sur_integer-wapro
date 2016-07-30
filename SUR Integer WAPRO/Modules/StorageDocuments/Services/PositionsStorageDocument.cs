using SUR_Integer_WAPRO.Modules.Database.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.StorageDocuments.Services
{
    class PositionsStorageDocument
    {

        /// <summary>
        /// Get all positions from storage documents
        /// </summary>
        /// <param name="storageDocuments">storage documents</param>
        /// <returns>Positions in storage documents</returns>
        public IQueryable<POZYCJA_DOKUMENTU_MAGAZYNOWEGO> getPositions(IQueryable<DOKUMENT_MAGAZYNOWY> storageDocuments)
        {

            try
            {
                TablesDataContext dbContext = new TablesDataContext(ConnectionService.getConnectionString());

                var idsStorageDocuments = storageDocuments.Select(x => x.ID_DOK_MAGAZYNOWEGO).ToList();

                return dbContext.POZYCJA_DOKUMENTU_MAGAZYNOWEGOs.Where(x => idsStorageDocuments.Contains(x.ID_DOK_MAGAZYNOWEGO.Value));

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Nie można pobrać danych z bazy danych. Szczegóły błędu:\n {0}", ex.Message), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
