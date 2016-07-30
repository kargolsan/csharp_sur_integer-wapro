using SUR_Integer_WAPRO.Modules.Authorization.Views;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Services;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Views;
using System.Windows.Forms;
using SUR_Integer_WAPRO.Modules.Database.Services;
using SUR_Integer_WAPRO.Modules.Authorization.Services;
using System.Threading.Tasks;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Controllers;
using System.Collections.Generic;

namespace SUR_Integer_WAPRO.Modules.Authorization.Controllers
{
    class AuthenticateController
    {
        /// <summary>
        /// Services for this controller
        /// </summary>
        private AuthenticateService _authenticateService;

        /// <summary>
        /// Footer controller for mdi parent window
        /// </summary>
        private FooterController _footerController;

        /// <summary>
        /// MDI View
        /// </summary>
        private MDIService _mdiService;

        /// <summary>
        /// Constructor
        /// </summary>
        public AuthenticateController()
        {
            _mdiService = new MDIService();
            _authenticateService = new AuthenticateService();
            
            _footerController = new FooterController();
        }

        /// <summary>
        /// Show View with authenticate
        /// </summary>
        public void showAuthenticateView()
        {
            AuthenticateView _authenticateView = _mdiService.findChildView<AuthenticateView>();

            if (_authenticateView != null)
            {
                _authenticateView.BringToFront();
                return;
            }

            MDIView mdiView = _mdiService.findMDIView();

            if (mdiView == null)
            {
                MessageBox.Show("Nie znaleziono widoku MDI Parent.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AuthenticateView authenticateView = new AuthenticateView();
            authenticateView.MdiParent = mdiView;
            authenticateView.Show();

        }

        /// <summary>
        /// Authenticate to datasource of WAPRO
        /// </summary>
        /// <param name="dataSource">data source of WAPRO</param>
        /// <param name="database">database name<</param>
        /// <param name="userName">user name for SQL authenticate<</param>
        /// <param name="password">password for SQL authenticate</param>
        /// <returns>true if authenticated or false if not authenticated</returns>
        public async Task<bool> authenticate(string dataSource, string database, string userName, string password)
        {

            return await Task.Run(() => {

                if (!ConnectionService.checkConnection(dataSource, database, userName, password)) {
                    return false;
                }

                _authenticateService.saveAuthenticate(dataSource, database, userName, password);

                _footerController.setDatabaseInformation(dataSource, database, userName);

                _authenticateService.authorizationMenuTop();
                
                return true;

            });
                
        }

        /// <summary>
        /// Close View of this controller
        /// </summary>
        public void closeView(AuthenticateView view, bool condition)
        {
            if (condition)
            {
                view.Close();
            }
            
        }

        /// <summary>
        /// Logout from application
        /// </summary>
        public void logout()
        {
            if (!findAndCloseViews())
            {
                return;
            }

            _authenticateService.unauthorizationMenuTop();
            
            _footerController.unsetDatabaseInformation();

            showAuthenticateView();

        }

        /// <summary>
        /// Find and close all views of child mdi
        /// </summary>
        /// <returns>true if all views is closed, false if not all views is closed</returns>
        private bool findAndCloseViews()
        {
            List<Form> childViews = _mdiService.getAllChildViews();

            if (childViews.Count <= 0)
            {
                return true;
            }

            DialogResult result = MessageBox.Show("Wylogowanie możliwe wyłącznie po zamknięciu wszystkich okienek.\n Czy pozamykać wszystkie okienka?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (Form view in childViews)
                {
                    view.Close();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
