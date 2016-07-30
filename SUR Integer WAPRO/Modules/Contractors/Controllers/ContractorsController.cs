using SUR_Integer_WAPRO.Modules.Articles.Controllers;
using SUR_Integer_WAPRO.Modules.Configuration.Services;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Services;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Views;
using SUR_Integer_WAPRO.Modules.Contractors.Services;
using SUR_Integer_WAPRO.Modules.Contractors.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Contractors.Controllers
{
    class ContractorsController
    {
        /// <summary>
        /// Services for this controller
        /// </summary>
        private ContractorsService _contractorsService;

        /// <summary>
        /// Controller for articles
        /// </summary>
        private ArticlesController _articlesController;

        /// <summary>
        /// MDI View
        /// </summary>
        private MDIService _mdiService;

        /// <summary>
        /// Constructor
        /// </summary>
        public ContractorsController()
        {
            _contractorsService = new ContractorsService();
            _articlesController = new ArticlesController();
            _mdiService = new MDIService();
        }

        /// <summary>
        /// Show View with contractors
        /// </summary>
        public void showContractorsView()
        {
            ContractorsView _contractorsView = _mdiService.findChildView<ContractorsView>();

            if (_contractorsView != null)
            {
                _contractorsView.BringToFront();
                return;
            }

            MDIView mdiView = _mdiService.findMDIView();

            if (mdiView == null)
            {
                MessageBox.Show("Nie znaleziono widoku MDI Parent.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ContractorsView contractorsView = new ContractorsView();
            contractorsView.MdiParent = mdiView;
            contractorsView.Show();

        }

        /// <summary>
        /// Load contractors to data grid view
        /// </summary>
        public async void loadContractors()
        {
            ContractorsView _contractorsView = _mdiService.findChildView<ContractorsView>();

            _contractorsView.Cursor = Cursors.WaitCursor;

            _contractorsView.dgvContractors.DataSource = null;

            _contractorsView.dgvContractors.DataSource = await _contractorsService.getContractors();

            _contractorsService.changeTableColumns(_contractorsView.dgvContractors);

            _contractorsView.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Load items sort for contractors
        /// </summary>
        public void loadSortItems()
        {
            ContractorsView _contractorsView = _mdiService.findChildView<ContractorsView>();

            _contractorsService.addSortItems(_contractorsView.cmbSort);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param">option for selected sort item of combo box</param>
        /// <param name="value">text for searched</param>
        public async void sortLoadContractors(string param, string value)
        {
            ContractorsView _contractorsView = _mdiService.findChildView<ContractorsView>();

            _contractorsView.Cursor = Cursors.WaitCursor;

            _contractorsView.dgvContractors.DataSource = null;

            _contractorsView.dgvContractors.DataSource = await _contractorsService.getSortContractors(param, value);

            _contractorsService.changeTableColumns(_contractorsView.dgvContractors);

            _contractorsView.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Load user configuraton for controls
        /// </summary>
        public void loadUserConfiguration()
        {
            ContractorsView _contractorsView = _mdiService.findChildView<ContractorsView>();

            _contractorsView.ckbAutoSort.Checked = ConfigurationService.GetConfig<bool>("CONTRACTORS_AUTOSORT");

        }

        /// <summary>
        /// Show view of articles with selected contractor
        /// </summary>
        public void showArticlesDeliveryFromContractor()
        {
            ContractorsView _contractorsView = _mdiService.findChildView<ContractorsView>();

            int rowindex = _contractorsView.dgvContractors.SelectedCells[0].RowIndex;

            int colId = _contractorsView.dgvContractors.Columns["ID_KONTRAHENTA"].Index;
            int colNameFull = _contractorsView.dgvContractors.Columns["NAZWA_PELNA"].Index;
            int colNip = _contractorsView.dgvContractors.Columns["NIP"].Index;

            decimal idContractor = (decimal)_contractorsView.dgvContractors.Rows[rowindex].Cells[colId].Value;
            string name = (string)_contractorsView.dgvContractors.Rows[rowindex].Cells[colNameFull].Value;
            string nip = (string)_contractorsView.dgvContractors.Rows[rowindex].Cells[colNip].Value;

            Dictionary<string, object> parametersArticles = new Dictionary<string, object>(){
                { "contractorDelivery", idContractor },  { "title", string.Format("Artykuły od {0}, NIP: {1}", name, nip).Replace(System.Environment.NewLine, " ") }
            };

            _articlesController.showArticlesView(parametersArticles);
        }

    }
}
