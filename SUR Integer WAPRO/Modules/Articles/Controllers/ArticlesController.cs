using SUR_Integer_WAPRO.Modules.Articles.Services;
using SUR_Integer_WAPRO.Modules.Articles.Views;
using SUR_Integer_WAPRO.Modules.Configuration.Services;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Services;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Articles.Controllers
{
    class ArticlesController
    {
        /// <summary>
        /// Services for this controller
        /// </summary>
        private ArticlesService _articlesService;

        /// <summary>
        /// MDI View
        /// </summary>
        private MDIService _mdiService;

        /// <summary>
        /// Controller for add values
        /// </summary>
        private AddValuesController _addValuesController;

        /// <summary>
        /// Controller for edit values
        /// </summary>
        private EditValuesController _editValuesController;

        /// <summary>
        /// For db context is busy
        /// </summary>
        private bool _dbContextIsBusy;

        /// <summary>
        /// Constructor
        /// </summary>
        public ArticlesController()
        {
            _articlesService = new ArticlesService();
            _mdiService = new MDIService();
            _addValuesController = new AddValuesController();
            _editValuesController = new EditValuesController();
        }

        /// <summary>
        /// Get and Set db context is busy
        /// </summary>
        public bool DbContextIsBusy
        {
            get
            {
                return _dbContextIsBusy;
            }
            set
            {
                _dbContextIsBusy = value;

                ArticlesView _articlesView = _mdiService.findChildView<ArticlesView>();
                _articlesView.lockControls(!value);
            }
        }

        /// <summary>
        /// Show View with contractors
        /// </summary>
        public void showArticlesView(Dictionary<string, object> parameters = null)
        {
            ArticlesView _articlesView = _mdiService.findChildView<ArticlesView>();

            if (_articlesView != null && parameters != null)
            {
                MessageBox.Show("Zamknij otwarte okno a artykułami i ponów operację.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _articlesView.BringToFront();
                return;
            }
                if (_articlesView != null)
            {
                _articlesView.BringToFront();
                return;
            }

            MDIView mdiView = _mdiService.findMDIView();

            if (mdiView == null)
            {
                MessageBox.Show("Nie znaleziono widoku MDI Parent.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ArticlesView articlesView = new ArticlesView();
            articlesView.MdiParent = mdiView;
            articlesView.ParametersArticles = parameters;
            articlesView.Show();

        }

        /// <summary>
        /// Load articles to data grid view
        /// </summary>
        public async void loadArticles(Dictionary<string, object> parameters = null)
        {
            ArticlesView _articlesView = _mdiService.findChildView<ArticlesView>();

            _articlesView.Cursor = Cursors.WaitCursor;

            _articlesView.dgvArticles.DataSource = null;

            _articlesView.panelSave.Visible = false;

            _articlesView.dgvArticles.DataSource = await _articlesService.getArticles(parameters);

            _articlesService.changeTableColumns(_articlesView.dgvArticles);

            _articlesView.Cursor = Cursors.Default;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param">option for selected sort item of combo box</param>
        /// <param name="value">text for searched</param>
        public async void sortloadArticles(string param, string value, Dictionary<string, object> parameters = null)
        {
            ArticlesView _articlesView = _mdiService.findChildView<ArticlesView>();

            _articlesView.Cursor = Cursors.WaitCursor;

            _articlesView.dgvArticles.DataSource = null;

            var articles = await _articlesService.getArticles(parameters);

            _articlesView.panelSave.Visible = false;

            _articlesView.dgvArticles.DataSource = await _articlesService.sortArticles(param, value, articles);

            _articlesService.changeTableColumns(_articlesView.dgvArticles);

            _articlesView.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Get title of filter article to view
        /// </summary>
        /// <param name="parameters">parameters for articles</param>
        public string getTitle(string oldTitle, Dictionary<string, object> parameters = null)
        {
            if (_articlesService.existParameter("title", parameters))
            {
                return (string)parameters["title"];
            }

            return oldTitle;
        }

        /// <summary>
        /// Load items sort for contractors
        /// </summary>
        public void loadSortItems()
        {
            ArticlesView _articlesView = _mdiService.findChildView<ArticlesView>();

            _articlesService.addSortItems(_articlesView.cmbSort);
            
        }

        /// <summary>
        /// Load user configuraton for controls
        /// </summary>
        public void loadUserConfiguration()
        {
            ArticlesView _articlesView = _mdiService.findChildView<ArticlesView>();

            _articlesView.ckbAutoSort.Checked = ConfigurationService.GetConfig<bool>("ARTICLES_AUTOSORT");

        }

        /// <summary>
        /// Event from menu data grid view to add value to cell
        /// </summary>
        public void addValues(DataGridView dgv)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>(){ { "dgvArticles", dgv } };

            _addValuesController.showDialogAddValuesView(parameters);
        }

        /// <summary>
        /// Event from menu data grid view to edit value to cell
        /// </summary>
        public void editValues(DataGridView dgv)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>() { { "dgvArticles", dgv } };

            _editValuesController.showDialogEditValuesView(parameters);
        }

        /// <summary>
        /// Update rows to database
        /// </summary>
        /// <param name="dgv">data grid view with articles</param>
        public async void updateDatabase(DataGridView dgv)
        {

            ArticlesView _articlesView = _mdiService.findChildView<ArticlesView>();

            DbContextIsBusy = true;

            _articlesView.PleaseWait.Visible = true;

            bool result = await _articlesService.updateDatabase(dgv);

            _articlesView.PleaseWait.Visible = false;

            if (result)
            {
                _articlesView.panelSave.Visible = false;
                MessageBox.Show("Poprawnie zaktualizowano dane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            DbContextIsBusy = false;

        }

    }
}
