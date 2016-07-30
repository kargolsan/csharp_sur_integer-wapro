using SUR_Integer_WAPRO.Modules.Database.Services;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Contractors.Services
{
    class ContractorsService
    {

        /// <summary>
        /// Get all contractors from database
        /// </summary>
        /// <returns>Contractors in table of linq</returns>
        public async Task<Table<KONTRAHENT>> getContractors()
        {
            return await Task.Run(() => {

                try
                {
                    TablesDataContext dbContext = new TablesDataContext(ConnectionService.getConnectionString());

                    return dbContext.KONTRAHENTs;

                } catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Nie można pobrać danych z bazy danych. Szczegóły błędu:\n {0}", ex.Message), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                
            });

        }

        /// <summary>
        /// Rename header text of columns
        /// </summary>
        /// <param name="dgv">data grid view with contractors</param>
        public void changeTableColumns(DataGridView dgv)
        {
            try
            {
                DataGridViewColumn id = dgv.Columns[dgv.Columns["ID_KONTRAHENTA"].Index];
                id.HeaderText = "ID";
                id.Width = 45;
                id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn contractor = dgv.Columns[dgv.Columns["NAZWA"].Index];
                contractor.HeaderText = "Kontrahent";
                contractor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                contractor.DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font.Name, 12F, FontStyle.Bold, GraphicsUnit.Pixel);

                DataGridViewColumn contractorFull = dgv.Columns[dgv.Columns["NAZWA_PELNA"].Index];
                contractorFull.HeaderText = "Pełna nazwa kontrahenta";
                contractorFull.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn nip = dgv.Columns[dgv.Columns["NIP"].Index];
                nip.HeaderText = "NIP";
                nip.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                DataGridViewColumn postCode = dgv.Columns[dgv.Columns["KOD_POCZTOWY"].Index];
                postCode.HeaderText = "Kod pocztowy";
                postCode.Width = 70;
                postCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn city = dgv.Columns[dgv.Columns["MIEJSCOWOSC"].Index];
                city.HeaderText = "Miejscowość";

                DataGridViewColumn street = dgv.Columns[dgv.Columns["ULICA_LOKAL"].Index];
                street.HeaderText = "Adres";
                street.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn update = dgv.Columns[dgv.Columns["LAST_MODIFIED"].Index];
                update.HeaderText = "Aktualizacja";
                update.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Nie można zmodyfikować tablicy kontrahentów. Szczegóły błędu:\n {0}", ex.Message), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Get list with key and value of sort items
        /// </summary>
        /// <returns>List with key and value of sort items</returns>
        private List<KeyValuePair<string, string>> getSortItems()
        {
            return new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("NAZWA", "Kontrahent"),
                new KeyValuePair<string, string>("NAZWA_PELNA", "Pełna nazwa kontrahenta"),
                new KeyValuePair<string, string>("NIP", "NIP"),
                new KeyValuePair<string, string>("MIEJSCOWOSC", "Miejscowość"),
                new KeyValuePair<string, string>("ULICA_LOKAL", "Adres"),
            };
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
        /// Get sort contractors from database
        /// </summary>
        /// <param name="param">name selected param sort item</param>
        /// <param name="value"></param>
        /// <returns>Contractors in table of linq</returns>
        public async Task<IQueryable<KONTRAHENT>> getSortContractors(string param, string value)
        {
            return await Task.Run(() => {

                try
                {

                    TablesDataContext dbContext = new TablesDataContext(ConnectionService.getConnectionString());
                    
                    switch (getKeySortItem(param))
                    {
                        case "NAZWA":
                            return dbContext.KONTRAHENTs.Where(x => x.NAZWA.Replace("\"", "").Replace("-", " ").Contains(value.Replace("\"", "").Replace("-", " ")));
                        case "NAZWA_PELNA":
                            return dbContext.KONTRAHENTs.Where(x => x.NAZWA_PELNA.Replace("\"", "").Replace("-", " ").Contains(value.Replace("\"", "").Replace("-", " ")));
                        case "NIP":
                            return dbContext.KONTRAHENTs.Where(x => x.NIP.Replace("-", "").Contains(value.Replace("-", "")));
                        case "MIEJSCOWOSC":
                            return dbContext.KONTRAHENTs.Where(x => x.MIEJSCOWOSC.Contains(value));
                        case "ULICA_LOKAL":
                            return dbContext.KONTRAHENTs.Where(x => x.ULICA_LOKAL.Contains(value));
                        default:
                            return dbContext.KONTRAHENTs;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Nie można pobrać danych z bazy danych. Szczegóły błędu:\n {0}", ex.Message), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            });

        }
    }
}
