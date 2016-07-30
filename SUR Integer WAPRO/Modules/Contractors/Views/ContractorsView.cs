using SUR_Integer_WAPRO.Modules.Configuration.Services;
using SUR_Integer_WAPRO.Modules.Contractors.Controllers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Contractors.Views
{
    public partial class ContractorsView : Form
    {
        
        /// <summary>
        /// Controller for this view
        /// </summary>
        private ContractorsController _contractorsController;



        /// <summary>
        /// Controller
        /// </summary>
        public ContractorsView()
        {
            InitializeComponent();
            _contractorsController = new ContractorsController();
        }

        /// <summary>
        /// Events for shown this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContractorsView_Shown(object sender, EventArgs e)
        {
            _contractorsController.loadContractors();
            _contractorsController.loadSortItems();
            _contractorsController.loadUserConfiguration();
        }

        /// <summary>
        /// Refresh datas in table of contractors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            sortItems();
        }

        /// <summary>
        /// Event of opening context menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuContractors_Opening(object sender, CancelEventArgs e)
        {
            if (dgvContractors.SelectedRows.Count <= 0)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Button for close this view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Write text for sort datas in data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSort_TextChanged(object sender, EventArgs e)
        {
            if (ckbAutoSort.Checked)
            {
                sortItems();
            }
            
        }

        /// <summary>
        /// Sort item has been selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortItems();
        }

        /// <summary>
        /// Sort click button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, EventArgs e)
        {
            sortItems();
        }

        /// <summary>
        /// Sort items
        /// </summary>
        private void sortItems()
        {
            string param = cmbSort.SelectedItem.ToString();
            string value = txtSort.Text;

            if (param == "")
            {
                return;
            }

            _contractorsController.sortLoadContractors(param, value);
        }

        /// <summary>
        /// Press the enter in textbox value of sort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                sortItems();
            }
        }

        /// <summary>
        /// Chande value autosort of checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbAutoSort_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationService.SetConfig<bool>("CONTRACTORS_AUTOSORT", (sender as CheckBox).Checked);
        }

        /// <summary>
        /// Show article of selected contrator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDgvProductsDeliveryFromContractor_Click(object sender, EventArgs e)
        {
            _contractorsController.showArticlesDeliveryFromContractor();
        }
    }
}
