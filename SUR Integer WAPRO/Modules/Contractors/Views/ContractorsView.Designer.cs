namespace SUR_Integer_WAPRO.Modules.Contractors.Views
{
    partial class ContractorsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractorsView));
            this.dgvContractors = new System.Windows.Forms.DataGridView();
            this.menuContractors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDgvProductsDeliveryFromContractor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.ckbAutoSort = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractors)).BeginInit();
            this.menuContractors.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContractors
            // 
            this.dgvContractors.AllowUserToAddRows = false;
            this.dgvContractors.AllowUserToDeleteRows = false;
            this.dgvContractors.AllowUserToResizeRows = false;
            this.dgvContractors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContractors.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvContractors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvContractors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvContractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractors.ContextMenuStrip = this.menuContractors;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContractors.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContractors.Location = new System.Drawing.Point(12, 42);
            this.dgvContractors.MultiSelect = false;
            this.dgvContractors.Name = "dgvContractors";
            this.dgvContractors.ReadOnly = true;
            this.dgvContractors.RowHeadersVisible = false;
            this.dgvContractors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractors.Size = new System.Drawing.Size(1030, 398);
            this.dgvContractors.TabIndex = 0;
            // 
            // menuContractors
            // 
            this.menuContractors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDgvProductsDeliveryFromContractor});
            this.menuContractors.Name = "menuContractors";
            this.menuContractors.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuContractors.Size = new System.Drawing.Size(354, 26);
            this.menuContractors.Opening += new System.ComponentModel.CancelEventHandler(this.menuContractors_Opening);
            // 
            // menuDgvProductsDeliveryFromContractor
            // 
            this.menuDgvProductsDeliveryFromContractor.Image = ((System.Drawing.Image)(resources.GetObject("menuDgvProductsDeliveryFromContractor.Image")));
            this.menuDgvProductsDeliveryFromContractor.Name = "menuDgvProductsDeliveryFromContractor";
            this.menuDgvProductsDeliveryFromContractor.Size = new System.Drawing.Size(353, 22);
            this.menuDgvProductsDeliveryFromContractor.Text = "Pokaż wszystkie dostarczone artykuły od kontrahenta";
            this.menuDgvProductsDeliveryFromContractor.Click += new System.EventHandler(this.menuDgvProductsDeliveryFromContractor_Click);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshTable.BackgroundImage")));
            this.btnRefreshTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshTable.Location = new System.Drawing.Point(1018, 12);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(24, 24);
            this.btnRefreshTable.TabIndex = 1;
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(967, 446);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.DisplayMember = "1";
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.ItemHeight = 16;
            this.cmbSort.Location = new System.Drawing.Point(12, 11);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(165, 24);
            this.cmbSort.TabIndex = 4;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // txtSort
            // 
            this.txtSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSort.Location = new System.Drawing.Point(183, 11);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(152, 23);
            this.txtSort.TabIndex = 5;
            this.txtSort.TextChanged += new System.EventHandler(this.txtSort_TextChanged);
            this.txtSort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSort_KeyPress);
            // 
            // btnSort
            // 
            this.btnSort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSort.BackgroundImage")));
            this.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSort.Location = new System.Drawing.Point(341, 11);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(22, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // ckbAutoSort
            // 
            this.ckbAutoSort.AutoSize = true;
            this.ckbAutoSort.Location = new System.Drawing.Point(369, 15);
            this.ckbAutoSort.Name = "ckbAutoSort";
            this.ckbAutoSort.Size = new System.Drawing.Size(147, 17);
            this.ckbAutoSort.TabIndex = 7;
            this.ckbAutoSort.Text = "Automatyczne sortowanie";
            this.ckbAutoSort.UseVisualStyleBackColor = true;
            this.ckbAutoSort.CheckedChanged += new System.EventHandler(this.ckbAutoSort_CheckedChanged);
            // 
            // ContractorsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 481);
            this.Controls.Add(this.ckbAutoSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.dgvContractors);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ContractorsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrahenci";
            this.Shown += new System.EventHandler(this.ContractorsView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractors)).EndInit();
            this.menuContractors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvContractors;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.ContextMenuStrip menuContractors;
        private System.Windows.Forms.ToolStripMenuItem menuDgvProductsDeliveryFromContractor;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Button btnSort;
        public System.Windows.Forms.CheckBox ckbAutoSort;
    }
}