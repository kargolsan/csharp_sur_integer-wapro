using SUR_Integer_WAPRO.Modules.ContainerMDI.Views;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.ContainerMDI.Services
{
    class MDIService
    {
        /// <summary>
        /// Find MDI Parent
        /// </summary>
        /// <returns>form with MDI parent</returns>
        public MDIView findMDIView()
        {
            return Application.OpenForms.Cast<MDIView>().Where(x => x.Name == "MDIView").FirstOrDefault();
        }

        /// <summary>
        /// Find form of application
        /// </summary>
        /// <returns>form with MDI parent</returns>
        public T findChildView<T>()
        {
            return findMDIView().MdiChildren.OfType<T>().FirstOrDefault();
        }

        /// <summary>
        /// Find all views child in mdi parent
        /// </summary>
        /// <returns>views in mdi parent</returns>
        public List<Form> getAllChildViews()
        {
            return findMDIView().MdiChildren.OfType<Form>().ToList();
        }

    }
}
