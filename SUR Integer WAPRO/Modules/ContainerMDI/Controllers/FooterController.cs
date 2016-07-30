
using SUR_Integer_WAPRO.Modules.ContainerMDI.Services;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Views;
using System.Drawing;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.ContainerMDI.Controllers
{
    class FooterController
    {
        /// <summary>
        /// MDI View
        /// </summary>
        private MDIService _mdiService;

        /// <summary>
        /// Constructor
        /// </summary>
        public FooterController()
        {
            _mdiService = new MDIService();
        }

        /// <summary>
        /// Set information of connection to database in footer of mdi window
        /// </summary>
        /// <param name="dataSource">data source of WAPRO</param>
        /// <param name="database">database name<</param>
        /// <param name="userName">user name for SQL authenticate<</param>
        public void setDatabaseInformation(string dataSource, string database, string userName)
        {

            _mdiService.findMDIView().BeginInvoke(new MethodInvoker(() =>
            {
                MDIView mdiView = _mdiService.findMDIView();

                mdiView.footerDatabaseInformation.Text = string.Format("Źródło danych: {0}; Nazwa bazy: {1}; Użytkownik: {2}",
                    dataSource, database, userName);

                mdiView.footerDatabaseInformation.ForeColor = Color.Green;
            }));

        }

        /// <summary>
        /// Unset information of connection to database in footer of mdi window
        /// </summary>
        public void unsetDatabaseInformation()
        {

            _mdiService.findMDIView().BeginInvoke(new MethodInvoker(() =>
            {
                MDIView mdiView = _mdiService.findMDIView();

                mdiView.footerDatabaseInformation.Text = "Brak połączenia";

                mdiView.footerDatabaseInformation.ForeColor = Color.FromName("GrayText");
            }));
            
        }
    }
}
