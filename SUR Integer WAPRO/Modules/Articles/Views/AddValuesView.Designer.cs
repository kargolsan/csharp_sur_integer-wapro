namespace SUR_Integer_WAPRO.Modules.Articles.Views
{
    partial class AddValuesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddValuesView));
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbColumn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ckbNoDouble = new System.Windows.Forms.CheckBox();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(41, 117);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Anuluj";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbColumn
            // 
            this.cmbColumn.DisplayMember = "1";
            this.cmbColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbColumn.FormattingEnabled = true;
            this.cmbColumn.ItemHeight = 16;
            this.cmbColumn.Location = new System.Drawing.Point(15, 25);
            this.cmbColumn.Name = "cmbColumn";
            this.cmbColumn.Size = new System.Drawing.Size(155, 24);
            this.cmbColumn.TabIndex = 9;
            this.cmbColumn.SelectedIndexChanged += new System.EventHandler(this.cmbColumn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dodaj ciąg znaków do kolumny:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ckbNoDouble
            // 
            this.ckbNoDouble.AutoSize = true;
            this.ckbNoDouble.Checked = true;
            this.ckbNoDouble.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNoDouble.Location = new System.Drawing.Point(15, 94);
            this.ckbNoDouble.Name = "ckbNoDouble";
            this.ckbNoDouble.Size = new System.Drawing.Size(205, 17);
            this.ckbNoDouble.TabIndex = 13;
            this.ckbNoDouble.Text = "Zapobiegaj dublowaniu ciagu znaków";
            this.ckbNoDouble.UseVisualStyleBackColor = true;
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(15, 68);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(205, 20);
            this.txtNewValue.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nowy ciąg znaków:";
            // 
            // AddValuesView
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(238, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewValue);
            this.Controls.Add(this.ckbNoDouble);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbColumn);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(254, 191);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(254, 191);
            this.Name = "AddValuesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj ciąg znaków";
            this.Shown += new System.EventHandler(this.AddValuesView_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ComboBox cmbColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox ckbNoDouble;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.Label label2;
    }
}