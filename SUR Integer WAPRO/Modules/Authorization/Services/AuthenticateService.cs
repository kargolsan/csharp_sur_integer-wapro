using SUR_Integer_WAPRO.Modules.Configuration.Services;
using SUR_Integer_WAPRO.Modules.ContainerMDI.Controllers;

namespace SUR_Integer_WAPRO.Modules.Authorization.Services
{
    class AuthenticateService
    {
        /// <summary>
        /// Footer controller for mdi parent window
        /// </summary>
        private MenuTopController _menuTopController;

        /// <summary>
        /// Constructor
        /// </summary>
        public AuthenticateService()
        {
            _menuTopController = new MenuTopController();
        }
        /// <summary>
        /// Save authentication datas from fields of view authenticate
        /// </summary>
        /// <param name="dataSource">data source of WAPRO</param>
        /// <param name="database">database name<</param>
        /// <param name="userName">user name for SQL authenticate<</param>
        /// <param name="password">password for SQL authenticate</param>
        public void saveAuthenticate(string dataSource, string database, string userName, string password)
        {
            ConfigurationService.SetConfig<string>("WFMAG_DATASOURCE", dataSource);
            ConfigurationService.SetConfig<string>("WFMAG_DATABASE", database);
            ConfigurationService.SetConfig<string>("WFMAG_USERNAME", userName);
            ConfigurationService.SetConfig<string>("WFMAG_PASSWORD", password);
        }

        /// <summary>
        /// Set controls of top menu for authorize to database
        /// </summary>
        public void authorizationMenuTop()
        {
            _menuTopController.offMenu("menuWindowAuthenticate");
            _menuTopController.onMenu("menuLogout");
            _menuTopController.onMenu("menuContractors");
            _menuTopController.onMenu("menuArticles");
        }

        /// <summary>
        /// Set controls of top menu for unauthorize to database
        /// </summary>
        public void unauthorizationMenuTop()
        {
            _menuTopController.onMenu("menuWindowAuthenticate");
            _menuTopController.offMenu("menuLogout");
            _menuTopController.offMenu("menuContractors");
            _menuTopController.offMenu("menuArticles");
        }
    }
}
