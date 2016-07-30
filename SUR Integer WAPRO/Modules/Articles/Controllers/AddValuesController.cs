using SUR_Integer_WAPRO.Modules.Articles.Services;
using SUR_Integer_WAPRO.Modules.Articles.Views;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Services;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Views;
using SUR_Integer_WAPRO.Modules.Database.Validations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Articles.Controllers
{
    class AddValuesController
    {
        /// <summary>
        /// Services for this controller
        /// </summary>
        private AddValuesService _addValuesService;

        /// <summary>
        /// Article validator
        /// </summary>
        private ArticleValidate _articleValidate;

        /// <summary>
        /// MDI View
        /// </summary>
        private MDIService _mdiService;

        /// <summary>
        /// Constructor
        /// </summary>
        public AddValuesController()
        {
            _mdiService = new MDIService();
            _addValuesService = new AddValuesService();
            _articleValidate = new ArticleValidate();
        }

        /// <summary>
        /// Show View with add values to articles
        /// </summary>
        public void showDialogAddValuesView(Dictionary<string, object> parameters = null)
        {
            AddValuesView _addValuesView = _mdiService.findChildView<AddValuesView>();
            
            if (_addValuesView != null)
            {
                _addValuesView.BringToFront();
                return;
            }

            MDIView mdiView = _mdiService.findMDIView();

            if (mdiView == null)
            {
                MessageBox.Show("Nie znaleziono widoku MDI Parent.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddValuesView addValuesView = new AddValuesView();
            addValuesView.ShowDialog();

        }

        /// <summary>
        /// Add list columns to combo box
        /// </summary>
        public void loadColumns(AddValuesView view)
        {
            _addValuesService.addColumns(view.cmbColumn);
        }

        /// <summary>
        /// Get key column by value column
        /// </summary>
        /// <param name="cmb"></param>
        /// <returns>key of column</returns>
        public string getKeyColumn(string value)
        {
            return _addValuesService.getKeyColumn(value);
        }

        /// <summary>
        /// Add new variable to choose column
        /// </summary>
        /// <param name="keyColumn">key column in data grid view</param>
        /// <param name="newValue">new variable</param>
        /// <param name="noDouble">true if you want no double variable, false if you wand double variable</param>
        public void AddValues(string keyColumn, string newValue, bool noDouble)
        {
            ArticlesView _articlesView = _mdiService.findChildView<ArticlesView>();

            int col = _articlesView.dgvArticles.Columns[keyColumn].Index;

            foreach (DataGridViewRow row in _articlesView.dgvArticles.SelectedRows)
            {
                string oldValue = (string)row.Cells[col].Value;

                // No double variables
                if (noDouble && oldValue.Contains(newValue))
                {
                    continue;
                }

                string tempNewValue = string.Format("{0}{1}", oldValue, newValue);

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
