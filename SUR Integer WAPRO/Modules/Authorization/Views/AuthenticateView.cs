using SUR_Integer_WAPRO.Modules.Authorization.Controllers;
using SUR_Integer_WAPRO.Modules.Configuration.Services;
using System;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Authorization.Views
{
    public partial class AuthenticateView : Form
    {

        /// <summary>
        /// Controller for view
        /// </summary>
        private AuthenticateController _authenticateController;

        /// <summary>
        /// Constructor of class
        /// </summary>
        public AuthenticateView()
        {
            InitializeComponent();
            _authenticateController = new AuthenticateController();
        }

        /// <summary>
        /// Event click for the authenticate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAuthenticate_Click(object sender, EventArgs e)
        {
            string dataSource = txtDataSource.Text;
            string database = txtDatabase.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            
            (sender as Button).Enabled = false;
            WaitIcon.Visible = true;

            bool authenticated = await _authenticateController.authenticate(dataSource, database, userName, password);

            (sender as Button).Enabled = true;
            WaitIcon.Visible = false;

            _authenticateController.closeView(this, authenticated);

        }

        /// <summary>
        /// Fill the fields for authenticate from settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthenticateView_Shown(object sender, EventArgs e)
        {
            txtDataSource.Text = ConfigurationService.GetConfig<string>("WFMAG_DATASOURCE");
            txtDatabase.Text = ConfigurationService.GetConfig<string>("WFMAG_DATABASE");
            txtUserName.Text = ConfigurationService.GetConfig<string>("WFMAG_USERNAME");
        }
    }
}
