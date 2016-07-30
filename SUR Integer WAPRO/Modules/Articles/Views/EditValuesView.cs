using SUR_Integer_WAPRO.Modules.Articles.Controllers;
using System;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Articles.Views
{
    public partial class EditValuesView : Form
    {
        /// <summary>
        /// Controller for this view
        /// </summary>
        private EditValuesController _editValuesController;

        /// <summary>
        /// Selected column in combobox
        /// </summary>
        private string _setColumn;

        /// <summary>
        /// Controller
        /// </summary>
        public EditValuesView()
        {
            InitializeComponent();
            _editValuesController = new EditValuesController();
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
        private void EditValuesView_Shown(object sender, EventArgs e)
        {
            _editValuesController.loadColumns(this);
        }

        /// <summary>
        /// Sort item has been selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColumn = _editValuesController.getKeyColumn((sender as ComboBox).SelectedItem.ToString());
            
        }

        /// <summary>
        /// Edit new variable to choose cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbColumn.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę zaznaczyć kolumnę do modyfikacji.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string findValue = txtFind.Text;
            string changeValue = txtChange.Text;

            _editValuesController.EditValues(SetColumn, findValue, changeValue);

            this.Close();

        }
    }
}
