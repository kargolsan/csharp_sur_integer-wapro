using SUR_Integer_WAPRO.Modules.Articles.Controllers;
using System;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Articles.Views
{
    public partial class AddValuesView : Form
    {
        /// <summary>
        /// Controller for this view
        /// </summary>
        private AddValuesController _addValuesController;

        /// <summary>
        /// Selected column in combobox
        /// </summary>
        private string _setColumn;

        /// <summary>
        /// Controller
        /// </summary>
        public AddValuesView()
        {
            InitializeComponent();
            _addValuesController = new AddValuesController();
        }

        /// <summary>
        /// Get and Set of selected column in combobox
        /// </summary>
        public string SetColumn
        {
            get
            {
                return _setColumn;
            }
            set
            {
                _setColumn = value;
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
        /// Events for shown this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddValuesView_Shown(object sender, EventArgs e)
        {
            _addValuesController.loadColumns(this);
        }

        /// <summary>
        /// Sort item has been selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColumn = _addValuesController.getKeyColumn((sender as ComboBox).SelectedItem.ToString());
            
        }

        /// <summary>
        /// Add new variable to choose cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbColumn.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę zaznaczyć kolumnę do modyfikacji.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newValue = txtNewValue.Text;
            bool noDouble = ckbNoDouble.Checked;

            _addValuesController.AddValues(SetColumn, newValue, noDouble);

            this.Close();

        }
    }
}
