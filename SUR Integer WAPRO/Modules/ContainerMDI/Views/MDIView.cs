using SUR_Integer_WAPRO.Modules.Articles.Controllers;
using SUR_Integer_WAPRO.Modules.Authorization.Controllers;
using SUR_Integer_WAPRO.Modules.Contractors.Controllers;
using System;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.ContainerMDI.Views
{
    public partial class MDIView : Form
    {
        /// <summary>
        /// Controller for this view
        /// </summary>
        private AuthenticateController _authenticateController;

        /// <summary>
        /// Controller for contractors
        /// </summary>
        private ContractorsController _contractorsController;

        /// <summary>
        /// Controller for articles
        /// </summary>
        private ArticlesController _articlesController;

        /// <summary>
        /// Constructor of class
        /// </summary>
        public MDIView()
        {
            InitializeComponent();
            _authenticateController = new AuthenticateController();
            _contractorsController = new ContractorsController();
            _articlesController = new ArticlesController();
        }

        /// <summary>
        /// Event for shown form
        /// </summary>
        /// <param name="sender">object - object of sender for this event</param>
        /// <param name="e">event - event for this object of sender</param>
        private void MDIView_Shown(object sender, EventArgs e)
        {
            _authenticateController.showAuthenticateView();
            //_contractorsController.showContractorsView();
            //_articlesController.showArticlesView();
        }

        /// <summary>
        /// Open window of authenticate to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWindowAuthenticate_Click(object sender, EventArgs e)
        {
            _authenticateController.showAuthenticateView();
        }

        /// <summary>
        /// Logout from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuLogout_Click(object sender, EventArgs e)
        {
            _authenticateController.logout();
        }

        /// <summary>
        /// Show view with contractors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuContractors_Click(object sender, EventArgs e)
        {
            _contractorsController.showContractorsView();
        }

        /// <summary>
        /// Show view with articles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuArticles_Click(object sender, EventArgs e)
        {
            _articlesController.showArticlesView();
        }
    }
}
