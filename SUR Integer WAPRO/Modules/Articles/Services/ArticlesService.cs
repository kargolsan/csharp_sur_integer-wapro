using SUR_Integer_WAPRO.Modules.Database.Services;
using SUR_Integer_WAPRO.Modules.StorageDocuments.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Articles.Services
{
    class ArticlesService
    {

        /// <summary>
        /// Services for storage documents
        /// </summary>
        private StorageDocumentsService _storageDocumentsService;

        /// <summary>
        /// Services for positions storage document
        /// </summary>
        private PositionsStorageDocument _positionsStorageDocument;

        /// <summary>
        /// Constructor
        /// </summary>
        public ArticlesService()
        {
            _storageDocumentsService = new StorageDocumentsService();
            _positionsStorageDocument = new PositionsStorageDocument();
        }

        /// <summary>
        /// Get all contractors from database
        /// </summary>
        /// <param name="parameters">parameters for filter articles</param>
        /// <returns>Contractors in table of linq</returns>
        public async Task<IQueryable<ARTYKUL>> getArticles(Dictionary<string, object> parameters = null)
        {
            return await Task.Run(() => {
                
                try
                {
                    TablesDataContext dbContext = new TablesDataContext(ConnectionService.getConnectionString());

                    if (existParameter("contractorDelivery", parameters))
                    {
                        return getArticlesOfDeliveryContractor(dbContext, parameters);
                    }

                    return dbContext.ARTYKULs;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Nie można pobrać danych z bazy danych. Szczegóły błędu:\n {0}", ex.Message), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            });

        }

        /// <summary>
        /// Get list with key and value of sort items
        /// </summary>
        /// <returns>List with key and value of sort items</returns>
        private List<KeyValuePair<string, string>> getSortItems()
        {
            return new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("ALL", "Wszystkie kolumny"),
                new KeyValuePair<string, string>("NAZWA", "Nazwa"),
                new KeyValuePair<string, string>("NAZWA_ORYG", "Nazwa oryginalna"),
                new KeyValuePair<string, string>("INDEKS_KATALOGOWY", "Indeks katalogowy"),
                new KeyValuePair<string, string>("INDEKS_HANDLOWY", "Indeks handlowy"),
            };
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

        /// <summary>
        /// Rename header text of columns
        /// </summary>
        /// <param name="dgv">data grid view with contractors</param>
        public void changeTableColumns(DataGridView dgv)
        {
            try
            {
                DataGridViewColumn id = dgv.Columns[dgv.Columns["ID_ARTYKULU"].Index];
                id.HeaderText = "ID";
                id.Width = 50;
                id.ReadOnly = true;
                id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn name = dgv.Columns[dgv.Columns["NAZWA"].Index];
                name.HeaderText = "Nazwa";
                name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn nameOrginal = dgv.Columns[dgv.Columns["NAZWA_ORYG"].Index];
                nameOrginal.HeaderText = "Nazwa oryginalna";
                nameOrginal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn name2 = dgv.Columns[dgv.Columns["NAZWA2"].Index];
                name2.HeaderText = "Nazwa cd.";
                name2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                DataGridViewColumn indexCatalog = dgv.Columns[dgv.Columns["INDEKS_KATALOGOWY"].Index];
                indexCatalog.HeaderText = "Indeks katalogowy";
                indexCatalog.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                
                DataGridViewColumn indexMerchant = dgv.Columns[dgv.Columns["INDEKS_HANDLOWY"].Index];
                indexMerchant.HeaderText = "Indeks handlowy";
                indexMerchant.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                DataGridViewColumn barcode = dgv.Columns[dgv.Columns["KOD_KRESKOWY"].Index];
                barcode.HeaderText = "Kod kreskowy";
                barcode.ReadOnly = true;
                barcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Nie można zmodyfikować tablicy artykułów. Szczegóły błędu:\n {0}", ex.Message), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Get articles for contractors of delivery
        /// </summary>
        /// <param name="dbContext">databasse context for tables</param>
        /// <param name="parameters">parameters for filter of articles</param>
        /// <returns></returns>
        private IQueryable<ARTYKUL> getArticlesOfDeliveryContractor(TablesDataContext dbContext, Dictionary<string, object> parameters)
        {
            Dictionary<string, object> parametersStorageDocuments = new Dictionary<string, object>() {
                            { "contractor", (decimal)parameters["contractorDelivery"] }, { "typeDocuments", "PZ" } };

            IQueryable<DOKUMENT_MAGAZYNOWY> storageDocuments = _storageDocumentsService.getStorageDocuments(parametersStorageDocuments);

            IQueryable<POZYCJA_DOKUMENTU_MAGAZYNOWEGO> positionsStorageDocument = _positionsStorageDocument.getPositions(storageDocuments);

            var idsArticles = positionsStorageDocument.Select(x => x.ID_ARTYKULU).ToList();

            return dbContext.ARTYKULs.Where(x => idsArticles.Contains(x.ID_ARTYKULU));
        }

        /// <summary>
        /// Get sort articles from database
        /// </summary>
        /// <param name="param">name selected param sort item</param>
        /// <param name="value"></param>
        /// <returns>Contractors in table of linq</returns>
        public async Task<IQueryable<ARTYKUL>> sortArticles(string param, string value, IQueryable<ARTYKUL> articles)
        {
            
            return await Task.Run(() => {

                try
                { 
                    switch (getKeySortItem(param))
                    {
                        case "ALL":
                            return articles.Where(x => x.NAZWA.Contains(value) || x.NAZWA_ORYG.Contains(value) || x.INDEKS_KATALOGOWY.Contains(value) || x.INDEKS_HANDLOWY.Contains(value));
                        case "NAZWA":
                            return articles.Where(x => x.NAZWA.Contains(value));
                        case "NAZWA_ORYG":
                            return articles.Where(x => x.NAZWA_ORYG.Contains(value));
                        case "INDEKS_KATALOGOWY":
                            return articles.Where(x => x.INDEKS_KATALOGOWY.Contains(value));
                        case "INDEKS_HANDLOWY":
                            return articles.Where(x => x.INDEKS_HANDLOWY.Contains(value));
                        default:
                            return articles;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Nie można pobrać danych z bazy danych. Szczegóły błędu:\n {0}", ex.Message), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return articles;
                }

            });

        }

        /// <summary>
        /// Get key sort item
        /// </summary>
        /// <param name="param">param of sort item</param>
        public string getKeySortItem(string param)
        {
            foreach (KeyValuePair<string, string> sortItem in getSortItems())
            {
                if (sortItem.Value == param)
                {
                    return sortItem.Key;
                }
            }

            return "";
        }

        /// <summary>
        /// Add items to sort combo box
        /// </summary>
        /// <param name="cmb">combobox from view</param>
        public void addSortItems(ComboBox cmb)
        {
            foreach (KeyValuePair<string, string> sortItem in getSortItems())
            {
                cmb.Items.Add(sortItem.Value);
                cmb.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// update selected rows to database
        /// </summary>
        /// <param name="rows">selected rows in data grid view of articles</param>
        /// <returns>Contractors in table of linq</returns>
        public async Task<bool> updateDatabase(DataGridView dgv)
        {
            try
            {
                DataGridViewSelectedRowCollection rows = dgv.SelectedRows;

                int colId = dgv.Columns["ID_ARTYKULU"].Index;
                int colName = dgv.Columns["NAZWA"].Index;
                int colNameOriginal = dgv.Columns["NAZWA_ORYG"].Index;
                int colName2 = dgv.Columns["NAZWA2"].Index;
                int colIdCat = dgv.Columns["INDEKS_KATALOGOWY"].Index;
                int colIdCommercial = dgv.Columns["INDEKS_HANDLOWY"].Index;

                TablesDataContext dbContext = new TablesDataContext(ConnectionService.getConnectionString());

                foreach (DataGridViewRow row in rows)
                {


                    await Task.Run(() => {
                        ARTYKUL article = dbContext.ARTYKULs.SingleOrDefault(x => x.ID_ARTYKULU == (decimal)row.Cells[colId].Value);
                        article.NAZWA = (string)row.Cells[colName].Value;
                        article.NAZWA_ORYG = (string)row.Cells[colNameOriginal].Value;
                        article.NAZWA2 = (string)row.Cells[colName2].Value;
                        article.INDEKS_KATALOGOWY = (string)row.Cells[colIdCat].Value;
                        article.INDEKS_HANDLOWY = (string)row.Cells[colIdCommercial].Value;

                    });

                }

                await Task.Run(() => {
                    dbContext.SubmitChanges();

                });
                
                return true;

            } catch (Exception ex)
            {
                MessageBox.Show(string.Format("Błąd podczas aktualizacji danych. Szczaegóły błędu:\n{0}", ex.Message), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
        }

    }
}
