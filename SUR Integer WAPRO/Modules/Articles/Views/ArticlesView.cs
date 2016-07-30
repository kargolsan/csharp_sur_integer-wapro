using SUR_Integer_WAPRO.Modules.Articles.Controllers;
using SUR_Integer_WAPRO.Modules.Configuration.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Articles.Views
{
    public partial class ArticlesView : Form
    {
        /// <summary>
        /// Controller for this view
        /// </summary>
        private ArticlesController _articlesController;

        /// <summary>
        /// Controller for edit values
        /// </summary>
        private EditValuesController _editValuesController;

        /// <summary>
        /// Parameters for display articles
        /// </summary>
        Dictionary<string, object> _parametersArticles;

        /// <summary>
        /// Get value before edit cell of articles data grid view
        /// </summary>
        private string _oldValueEditCell;

        /// <summary>
        /// Controller
        /// </summary>
        public ArticlesView()
        {
            InitializeComponent();
            _articlesController = new ArticlesController();
            _editValuesController = new EditValuesController();

        }

        /// <summary>
        /// Get and Set of parameters for display articles
        /// </summary>
        public Dictionary<string, object> ParametersArticles
        {
            get
            {
                return _parametersArticles;
            }
            set
            {
                _parametersArticles = value;
            }
        }
        
        /// <summary>
        /// Get and Set of value before edit cell of articles data grid view
        /// </summary>
        public string OldValueEditCell
        {
            get
            {
                return _oldValueEditCell;
            }
            set
            {
                _oldValueEditCell = value;
            }
        }

        /// <summary>
        /// Button for close this view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Events for shown this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArticlesView_Shown(object sender, EventArgs e)
        {
            _articlesController.loadArticles(ParametersArticles);
            _articlesController.loadSortItems();
            _articlesController.loadUserConfiguration();
            lblTitle.Text = _articlesController.getTitle(lblTitle.Text, ParametersArticles);
        }

        /// <summary>
        /// Refresh datas in table of contractors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            sortItems();
        }

        /// <summary>
        /// Sort items
        /// </summary>
        public void sortItems()
        {
            string param = cmbSort.SelectedItem.ToString();
            string value = txtSort.Text;

            if (param == "")
            {
                return;
            }
            _articlesController.sortloadArticles(param, value, ParametersArticles);
        }

        /// <summary>
        /// Write text for sort datas in data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSort_TextChanged(object sender, EventArgs e)
        {
            if (ckbAutoSort.Checked)
            {
                sortItems();
            }

        }

        /// <summary>
        /// Sort item has been selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortItems();
        }

        /// <summary>
        /// Sort click button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, EventArgs e)
        {
            sortItems();
        }

        /// <summary>
        /// Press the enter in textbox value of sort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                sortItems();
            }
        }

        /// <summary>
        /// Chande value autosort of checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbAutoSort_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationService.SetConfig<bool>("ARTICLES_AUTOSORT", (sender as CheckBox).Checked);
        }

        /// <summary>
        /// Select all rows in data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDgvSelectAll_Click(object sender, EventArgs e)
        {
            dgvArticles.SelectAll();
        }

        /// <summary>
        /// Add value to selected row in data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDgvAddValues_Click(object sender, EventArgs e)
        {
            if (dgvArticles.SelectedRows.Count <= 0) {
                MessageBox.Show("Zaznacz przynajmniej jeden wiersz , aby wykonać tę operację.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _articlesController.addValues(dgvArticles);

        }

        /// <summary>
        /// Update rows to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDgvUpdateDatabase_Click(object sender, EventArgs e)
        {
            if (dgvArticles.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Zaznacz przynajmniej jeden wiersz , aby wykonać tę operację.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _articlesController.updateDatabase(dgvArticles);
        }

        /// <summary>
        /// For end edit cell in data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvArticles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            string keyColumn = (sender as DataGridView).Columns[e.ColumnIndex].Name;

            string newValue = (string)(sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            _editValuesController.editedCell(keyColumn, newValue, (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex]);
        }

        /// <summary>
        /// For begin edit cell in data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvArticles_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            OldValueEditCell = (string)(sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        /// <summary>
        /// Edit value to selected row in data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDgvEditValues_Click(object sender, EventArgs e)
        {
            if (dgvArticles.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Zaznacz przynajmniej jeden wiersz , aby wykonać tę operację.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _articlesController.editValues(dgvArticles);
        }

        /// <summary>
        /// Lock choose controls
        /// </summary>
        /// <param name="value">true if unlock, false if lock</param>
        public void lockControls(bool value)
        {
            dgvArticles.Enabled = value;
            cmbSort.Enabled = value;
            txtSort.Enabled = value;
            btnSort.Enabled = value;
            btnRefreshTable.Enabled = value;
            btnClose.Enabled = value;
        }
    }
}
