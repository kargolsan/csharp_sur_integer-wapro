using System.Collections.Generic;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Articles.Services
{
    class AddValuesService
    {
        /// <summary>
        /// Get list with key and value of sort items
        /// </summary>
        /// <returns>List with key and value of sort items</returns>
        private List<KeyValuePair<string, string>> getColumns()
        {
            return new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("NAZWA", "Nazwa"),
                new KeyValuePair<string, string>("NAZWA_ORYG", "Nazwa oryginalna"),
                new KeyValuePair<string, string>("NAZWA2", "Nazwa cd."),
                new KeyValuePair<string, string>("INDEKS_KATALOGOWY", "Indeks katalogowy"),
                new KeyValuePair<string, string>("INDEKS_HANDLOWY", "Indeks handlowy"),
            };
        }

        /// <summary>
        /// Add items of column to combo box
        /// </summary>
        /// <param name="cmb">combobox from view</param>
        public void addColumns(ComboBox cmb)
        {
            foreach (KeyValuePair<string, string> column in getColumns())
            {
                cmb.Items.Add(column.Value);
            }

        }

        /// <summary>
        /// Get key column
        /// </summary>
        /// <param name="param">param of sort item</param>
        public string getKeyColumn(string param)
        {
            foreach (KeyValuePair<string, string> sortItem in getColumns())
            {
                if (sortItem.Value == param)
                {
                    return sortItem.Key;
                }
            }

            return "";
        }

    }
}
