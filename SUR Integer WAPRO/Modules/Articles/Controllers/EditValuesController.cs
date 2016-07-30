using SUR_Integer_WAPRO.Modules.Articles.Services;
using SUR_Integer_WAPRO.Modules.Articles.Views;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Services;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Views;
using SUR_Integer_WAPRO.Modules.Database.Validations;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Articles.Controllers
{
    class EditValuesController
    {
        /// <summary>
        /// Services for this controller
        /// </summary>
        private EditValuesService _editValuesService;

        /// <summary>
        /// Services for this controller
        /// </summary>
        private ArticleValidate _articleValidate;

        /// <summary>
        /// MDI View
        /// </summary>
        private MDIService _mdiService;

        /// <summary>
        /// Constructor
        /// </summary>
        public EditValuesController()
        {
            _mdiService = new MDIService();
            _editValuesService = new EditValuesService();
            _articleValidate = new ArticleValidate();
        }

        /// <summary>
        /// For edited cells in data grid view of articles
        /// </summary>
        /// <param name="keyColumn">key column in data grid view</param>
        /// <param name="newValue">new variable</param>
        public void editedCell(string keyColumn, string newValue, DataGridViewCell cell)
        {

            ArticlesView _articlesView = _mdiService.findChildView<ArticlesView>();

            string tempNewValue = _articleValidate.limitAndNullValue(keyColumn, newValue, cell, _articlesView.OldValueEditCell);

            cell.Value = tempNewValue;

            if (tempNewValue != _articlesView.OldValueEditCell)
            {
                _articlesView.panelSave.Visible = true;
            }

            _articlesView.dgvArticles.ClearSelection();

        }

        /// <summary>
        /// Show View with edit values to articles
        /// </summary>
        public void showDialogEditValuesView(Dictionary<string, object> parameters = null)
        {
            EditValuesView _editValuesView = _mdiService.findChildView<EditValuesView>();

            if (_editValuesView != null)
            {
                _editValuesView.BringToFront();
                return;
            }

            MDIView mdiView = _mdiService.findMDIView();

            if (mdiView == null)
            {
                MessageBox.Show("Nie znaleziono widoku MDI Parent.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditValuesView editValuesView = new EditValuesView();
            editValuesView.ShowDialog();

        }

        /// <summary>
        /// Add list columns to combo box
        /// </summary>
        public void loadColumns(EditValuesView view)
        {
            _editValuesService.addColumns(view.cmbColumn);
        }

        /// <summary>
        /// Get key column by value column
        /// </summary>
        /// <param name="cmb"></param>
        /// <returns>key of column</returns>
        public string getKeyColumn(string value)
        {
            return _editValuesService.getKeyColumn(value);
        }

        /// <summary>
        /// Add new variable to choose column
        /// </summary>
        /// <param name="keyColumn">key column in data grid view</param>
        /// <param name="findValue">fint variable to replace</param>
        /// <param name="changeValue">new variable before replace</param>
        public void EditValues(string keyColumn, string findValue, string changeValue)
        {
            ArticlesView _articlesView = _mdiService.findChildView<ArticlesView>();

            int col = _articlesView.dgvArticles.Columns[keyColumn].Index;

            foreach (DataGridViewRow row in _articlesView.dgvArticles.SelectedRows)
            {
                string oldValue = (string)row.Cells[col].Value;

                string tempNewValue = oldValue.Replace(findValue, changeValue);

                tempNewValue = _articleValidate.limitAndNullValue(keyColumn, tempNewValue, row.Cells[col], oldValue);

                if (tempNewValue != oldValue)
                {
                    _articlesView.panelSave.Visible = true;
                }

                row.Cells[col].Value = tempNewValue;
            }

            _articlesView.dgvArticles.ClearSelection();

        }
    }
}
