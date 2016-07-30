namespace SUR_Integer_WAPRO.Modules.Articles.Views
{
    partial class ArticlesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticlesView));
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.menuArticles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDgvSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDgvAddValues = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDgvEditValues = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDgvUpdateDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ckbAutoSort = new System.Windows.Forms.CheckBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelSave = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WaitIcon = new System.Windows.Forms.PictureBox();
            this.PleaseWait = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.menuArticles.SuspendLayout();
            this.panelSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitIcon)).BeginInit();
            this.PleaseWait.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.AllowUserToResizeRows = false;
            this.dgvArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvArticles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.ContextMenuStrip = this.menuArticles;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticles.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticles.Location = new System.Drawing.Point(12, 60);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.RowHeadersVisible = false;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(1126, 427);
            this.dgvArticles.TabIndex = 1;
            this.dgvArticles.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvArticles_CellBeginEdit);
            this.dgvArticles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticles_CellEndEdit);
            // 
            // menuArticles
            // 
            this.menuArticles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDgvSelectAll,
            this.menuDgvAddValues,
            this.menuDgvEditValues,
            this.menuDgvUpdateDatabase});
            this.menuArticles.Name = "menuContractors";
            this.menuArticles.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuArticles.Size = new System.Drawing.Size(321, 92);
            // 
            // menuDgvSelectAll
            // 
            this.menuDgvSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("menuDgvSelectAll.Image")));
            this.menuDgvSelectAll.Name = "menuDgvSelectAll";
            this.menuDgvSelectAll.Size = new System.Drawing.Size(320, 22);
            this.menuDgvSelectAll.Text = "Zaznacz wszystkie";
            this.menuDgvSelectAll.Click += new System.EventHandler(this.menuDgvSelectAll_Click);
            // 
            // menuDgvAddValues
            // 
            this.menuDgvAddValues.Image = ((System.Drawing.Image)(resources.GetObject("menuDgvAddValues.Image")));
            this.menuDgvAddValues.Name = "menuDgvAddValues";
            this.menuDgvAddValues.Size = new System.Drawing.Size(320, 22);
            this.menuDgvAddValues.Text = "Dodaj ciąg znaków do zaznaczonych wierszów";
            this.menuDgvAddValues.Click += new System.EventHandler(this.menuDgvAddValues_Click);
            // 
            // menuDgvEditValues
            // 
            this.menuDgvEditValues.Image = ((System.Drawing.Image)(resources.GetObject("menuDgvEditValues.Image")));
            this.menuDgvEditValues.Name = "menuDgvEditValues";
            this.menuDgvEditValues.Size = new System.Drawing.Size(320, 22);
            this.menuDgvEditValues.Text = "Edytuj ciąg znaków do zaznaczonych wierszów";
            this.menuDgvEditValues.Click += new System.EventHandler(this.menuDgvEditValues_Click);
            // 
            // menuDgvUpdateDatabase
            // 
            this.menuDgvUpdateDatabase.Image = ((System.Drawing.Image)(resources.GetObject("menuDgvUpdateDatabase.Image")));
            this.menuDgvUpdateDatabase.Name = "menuDgvUpdateDatabase";
            this.menuDgvUpdateDatabase.Size = new System.Drawing.Size(320, 22);
            this.menuDgvUpdateDatabase.Text = "Aktualizuj zaznaczone artykuły do bazy danych";
            this.menuDgvUpdateDatabase.Click += new System.EventHandler(this.menuDgvUpdateDatabase_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1063, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshTable.BackgroundImage")));
            this.btnRefreshTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshTable.Location = new System.Drawing.Point(1114, 30);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(24, 24);
            this.btnRefreshTable.TabIndex = 5;
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 18);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Wszystkie artykuły";
            // 
            // ckbAutoSort
            // 
            this.ckbAutoSort.AutoSize = true;
            this.ckbAutoSort.Location = new System.Drawing.Point(369, 34);
            this.ckbAutoSort.Name = "ckbAutoSort";
            this.ckbAutoSort.Size = new System.Drawing.Size(147, 17);
            this.ckbAutoSort.TabIndex = 11;
            this.ckbAutoSort.Text = "Automatyczne sortowanie";
            this.ckbAutoSort.UseVisualStyleBackColor = true;
            this.ckbAutoSort.CheckedChanged += new System.EventHandler(this.ckbAutoSort_CheckedChanged);
            // 
            // btnSort
            // 
            this.btnSort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSort.BackgroundImage")));
            this.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSort.Location = new System.Drawing.Point(341, 30);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(22, 23);
            this.btnSort.TabIndex = 10;
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtSort
            // 
            this.txtSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSort.Location = new System.Drawing.Point(183, 30);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(152, 23);
            this.txtSort.TabIndex = 9;
            this.txtSort.TextChanged += new System.EventHandler(this.txtSort_TextChanged);
            this.txtSort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSort_KeyPress);
            // 
            // cmbSort
            // 
            this.cmbSort.DisplayMember = "1";
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.ItemHeight = 16;
            this.cmbSort.Location = new System.Drawing.Point(12, 30);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(165, 24);
            this.cmbSort.TabIndex = 8;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(6, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(320, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Zapisz zmodyfikowane artykuły do bazy danych";
            // 
            // panelSave
            // 
            this.panelSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSave.Controls.Add(this.label5);
            this.panelSave.Controls.Add(this.label6);
            this.panelSave.Controls.Add(this.label3);
            this.panelSave.Controls.Add(this.label4);
            this.panelSave.Controls.Add(this.label2);
            this.panelSave.Controls.Add(this.label1);
            this.panelSave.Controls.Add(this.label12);
            this.panelSave.Location = new System.Drawing.Point(3, 490);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(832, 38);
            this.panelSave.TabIndex = 14;
            this.panelSave.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pomyślnie zmieniono";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(348, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Przekroczony limit długości";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(484, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Wymagana wartość lub błąd";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(651, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 14;
            // 
            // WaitIcon
            // 
            this.WaitIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WaitIcon.Image = ((System.Drawing.Image)(resources.GetObject("WaitIcon.Image")));
            this.WaitIcon.Location = new System.Drawing.Point(87, 44);
            this.WaitIcon.Name = "WaitIcon";
            this.WaitIcon.Size = new System.Drawing.Size(24, 23);
            this.WaitIcon.TabIndex = 15;
            this.WaitIcon.TabStop = false;
            // 
            // PleaseWait
            // 
            this.PleaseWait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PleaseWait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PleaseWait.Controls.Add(this.label7);
            this.PleaseWait.Controls.Add(this.WaitIcon);
            this.PleaseWait.Location = new System.Drawing.Point(460, 212);
            this.PleaseWait.Name = "PleaseWait";
            this.PleaseWait.Size = new System.Drawing.Size(200, 87);
            this.PleaseWait.TabIndex = 16;
            this.PleaseWait.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(50, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Proszę czekać";
            // 
            // ArticlesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 528);
            this.Controls.Add(this.PleaseWait);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.ckbAutoSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvArticles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 551);
            this.Name = "ArticlesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artykuły";
            this.Shown += new System.EventHandler(this.ArticlesView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.menuArticles.ResumeLayout(false);
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitIcon)).EndInit();
            this.PleaseWait.ResumeLayout(false);
            this.PleaseWait.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvArticles;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.CheckBox ckbAutoSort;
        public System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.ContextMenuStrip menuArticles;
        private System.Windows.Forms.ToolStripMenuItem menuDgvSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuDgvAddValues;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuDgvUpdateDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuDgvEditValues;
        public System.Windows.Forms.PictureBox WaitIcon;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel PleaseWait;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnRefreshTable;
        public System.Windows.Forms.Button btnSort;
        public System.Windows.Forms.TextBox txtSort;
    }
}