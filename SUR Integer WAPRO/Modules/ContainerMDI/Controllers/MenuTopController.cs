using SUR_Integer_WAPRO.Modules.ContainerMDI.Services;
using System.Linq;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.ContainerMDI.Controllers
{
    class MenuTopController
    {
        /// <summary>
        /// MDI View
        /// </summary>
        private MDIService _mdiService;

        /// <summary>
        /// Constructor
        /// </summary>
        public MenuTopController()
        {
            _mdiService = new MDIService();
        }

        /// <summary>
        /// off item of top menu in mdi parent window
        /// </summary>
        /// <param name="name">name of menu</param>
        public void offMenu(string name)
        {

            _mdiService.findMDIView().BeginInvoke(new MethodInvoker(() =>
            {
                _mdiService.findMDIView().menuTop.Items.Find(name, true).First().Enabled = false;
            }));
            
        }

        /// <summary>
        /// on item of top menu in mdi parent window
        /// </summary>
        /// <param name="name">name of menu</param>
        public void onMenu(string name)
        {
            _mdiService.findMDIView().BeginInvoke(new MethodInvoker(() =>
            {
                _mdiService.findMDIView().menuTop.Items.Find(name, true).First().Enabled = true;
            }));
        }

    }
}
