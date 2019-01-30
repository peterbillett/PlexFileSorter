namespace PlexFileSorterGUI
{
    partial class LookupGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookupGUI));
            this.lookupDataGridView = new System.Windows.Forms.DataGridView();
            this.lookup_term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LookupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookupTextBox = new System.Windows.Forms.TextBox();
            this.lookupAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.lookupDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lookupDataGridView
            // 
            this.lookupDataGridView.AllowUserToAddRows = false;
            this.lookupDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookupDataGridView.AutoGenerateColumns = false;
            this.lookupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lookupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lookup_term,
            this.update,
            this.delete,
            this.LookupID});
            this.lookupDataGridView.DataSource = this.lookupBindingSource;
            this.lookupDataGridView.Location = new System.Drawing.Point(12, 43);
            this.lookupDataGridView.MultiSelect = false;
            this.lookupDataGridView.Name = "lookupDataGridView";
            this.lookupDataGridView.RowHeadersVisible = false;
            this.lookupDataGridView.Size = new System.Drawing.Size(427, 150);
            this.lookupDataGridView.TabIndex = 0;
            this.lookupDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LookupDataGridView_CellContentClick);
            // 
            // lookup_term
            // 
            this.lookup_term.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lookup_term.DataPropertyName = "lookup_term";
            this.lookup_term.HeaderText = "Lookup term";
            this.lookup_term.Name = "lookup_term";
            // 
            // update
            // 
            this.update.HeaderText = "Update";
            this.update.MinimumWidth = 50;
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Width = 50;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.MinimumWidth = 50;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // LookupID
            // 
            this.LookupID.DataPropertyName = "id";
            this.LookupID.HeaderText = "id";
            this.LookupID.Name = "LookupID";
            this.LookupID.ReadOnly = true;
            this.LookupID.Visible = false;
            // 
            // lookupBindingSource
            // 
            this.lookupBindingSource.Position = 0;
            // 
            // lookupTextBox
            // 
            this.lookupTextBox.Location = new System.Drawing.Point(102, 10);
            this.lookupTextBox.Name = "lookupTextBox";
            this.lookupTextBox.Size = new System.Drawing.Size(250, 20);
            this.lookupTextBox.TabIndex = 1;
            // 
            // lookupAdd
            // 
            this.lookupAdd.Location = new System.Drawing.Point(358, 8);
            this.lookupAdd.Name = "lookupAdd";
            this.lookupAdd.Size = new System.Drawing.Size(62, 23);
            this.lookupAdd.TabIndex = 2;
            this.lookupAdd.Text = "Add";
            this.lookupAdd.UseVisualStyleBackColor = true;
            this.lookupAdd.Click += new System.EventHandler(this.LookupAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New search word";
            // 
            // showIDTextBox
            // 
            this.showIDTextBox.Location = new System.Drawing.Point(48, 16);
            this.showIDTextBox.Name = "showIDTextBox";
            this.showIDTextBox.Size = new System.Drawing.Size(10, 20);
            this.showIDTextBox.TabIndex = 4;
            this.showIDTextBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lookupTextBox);
            this.groupBox1.Controls.Add(this.lookupAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 34);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // LookupGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 204);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showIDTextBox);
            this.Controls.Add(this.lookupDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LookupGUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LookupGUI";
            ((System.ComponentModel.ISupportInitialize)(this.lookupDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lookupDataGridView;
        private System.Windows.Forms.BindingSource lookupBindingSource;
        private System.Windows.Forms.TextBox lookupTextBox;
        private System.Windows.Forms.Button lookupAdd;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn searchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox showIDTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lookup_term;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn LookupID;
    }
}