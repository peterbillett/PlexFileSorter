using System.Drawing;
using System.Windows.Forms;

namespace PlexFileSorterGUI
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.DataGrid = new System.Windows.Forms.TableLayoutPanel();
            this.TVShowDataView = new System.Windows.Forms.DataGridView();
            this.TVShowViewSearchTerms = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TVShowNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVShowStorageDrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVShowUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TVShowDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TVShowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AnimeDataView = new System.Windows.Forms.DataGridView();
            this.AnimeViewSearchTerms = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AnimeNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimeSeason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimeEpisodeOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimeStorageDrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimeUpdateData = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AnimeDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AnimeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.AddAnimeButton = new System.Windows.Forms.Button();
            this.AddTVShowButton = new System.Windows.Forms.Button();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TVShowDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimeDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSize = true;
            this.DataGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DataGrid.BackColor = System.Drawing.Color.Transparent;
            this.DataGrid.ColumnCount = 1;
            this.DataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DataGrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.DataGrid.Location = new System.Drawing.Point(26, 97);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowCount = 2;
            this.DataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DataGrid.Size = new System.Drawing.Size(0, 0);
            this.DataGrid.TabIndex = 0;
            // 
            // TVShowDataView
            // 
            this.TVShowDataView.AllowUserToAddRows = false;
            this.TVShowDataView.AllowUserToDeleteRows = false;
            this.TVShowDataView.AllowUserToResizeColumns = false;
            this.TVShowDataView.AllowUserToResizeRows = false;
            this.TVShowDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TVShowDataView.AutoGenerateColumns = false;
            this.TVShowDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TVShowDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TVShowDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TVShowDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TVShowViewSearchTerms,
            this.TVShowNames,
            this.TVShowStorageDrive,
            this.TVShowUpdate,
            this.TVShowDelete,
            this.TVShowID});
            this.TVShowDataView.DataSource = this.database1DataSetBindingSource;
            this.TVShowDataView.Location = new System.Drawing.Point(1, 3);
            this.TVShowDataView.MultiSelect = false;
            this.TVShowDataView.Name = "TVShowDataView";
            this.TVShowDataView.RowHeadersVisible = false;
            this.TVShowDataView.Size = new System.Drawing.Size(562, 348);
            this.TVShowDataView.TabIndex = 1;
            this.TVShowDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TVShowDataView_CellContentClick);
            // 
            // TVShowViewSearchTerms
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.TVShowViewSearchTerms.DefaultCellStyle = dataGridViewCellStyle2;
            this.TVShowViewSearchTerms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TVShowViewSearchTerms.HeaderText = "Search Terms";
            this.TVShowViewSearchTerms.MinimumWidth = 50;
            this.TVShowViewSearchTerms.Name = "TVShowViewSearchTerms";
            this.TVShowViewSearchTerms.ReadOnly = true;
            this.TVShowViewSearchTerms.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TVShowViewSearchTerms.Width = 50;
            // 
            // TVShowNames
            // 
            this.TVShowNames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TVShowNames.DataPropertyName = "name";
            this.TVShowNames.HeaderText = "TV Show Name";
            this.TVShowNames.MinimumWidth = 100;
            this.TVShowNames.Name = "TVShowNames";
            this.TVShowNames.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TVShowStorageDrive
            // 
            this.TVShowStorageDrive.DataPropertyName = "drive_letter";
            this.TVShowStorageDrive.HeaderText = "Storage Drive";
            this.TVShowStorageDrive.MinimumWidth = 50;
            this.TVShowStorageDrive.Name = "TVShowStorageDrive";
            this.TVShowStorageDrive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TVShowStorageDrive.Width = 50;
            // 
            // TVShowUpdate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.TVShowUpdate.DefaultCellStyle = dataGridViewCellStyle3;
            this.TVShowUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TVShowUpdate.HeaderText = "Update";
            this.TVShowUpdate.MinimumWidth = 50;
            this.TVShowUpdate.Name = "TVShowUpdate";
            this.TVShowUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TVShowUpdate.Width = 50;
            // 
            // TVShowDelete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.TVShowDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.TVShowDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TVShowDelete.HeaderText = "Delete";
            this.TVShowDelete.MinimumWidth = 50;
            this.TVShowDelete.Name = "TVShowDelete";
            this.TVShowDelete.ReadOnly = true;
            this.TVShowDelete.Width = 50;
            // 
            // TVShowID
            // 
            this.TVShowID.DataPropertyName = "id";
            this.TVShowID.HeaderText = "id";
            this.TVShowID.Name = "TVShowID";
            this.TVShowID.ReadOnly = true;
            this.TVShowID.Visible = false;
            // 
            // AnimeDataView
            // 
            this.AnimeDataView.AllowUserToAddRows = false;
            this.AnimeDataView.AllowUserToDeleteRows = false;
            this.AnimeDataView.AllowUserToResizeColumns = false;
            this.AnimeDataView.AllowUserToResizeRows = false;
            this.AnimeDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimeDataView.AutoGenerateColumns = false;
            this.AnimeDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AnimeDataView.ColumnHeadersHeight = 34;
            this.AnimeDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AnimeDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimeViewSearchTerms,
            this.AnimeNames,
            this.AnimeSeason,
            this.AnimeEpisodeOffset,
            this.AnimeStorageDrive,
            this.AnimeUpdateData,
            this.AnimeDelete,
            this.AnimeID});
            this.AnimeDataView.DataSource = this.database1DataSetBindingSource;
            this.AnimeDataView.Location = new System.Drawing.Point(1, 3);
            this.AnimeDataView.MultiSelect = false;
            this.AnimeDataView.Name = "AnimeDataView";
            this.AnimeDataView.RowHeadersVisible = false;
            this.AnimeDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AnimeDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AnimeDataView.Size = new System.Drawing.Size(562, 289);
            this.AnimeDataView.TabIndex = 0;
            this.AnimeDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnimeDataView_CellContentClick);
            // 
            // AnimeViewSearchTerms
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.AnimeViewSearchTerms.DefaultCellStyle = dataGridViewCellStyle5;
            this.AnimeViewSearchTerms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AnimeViewSearchTerms.HeaderText = "Search Terms";
            this.AnimeViewSearchTerms.MinimumWidth = 50;
            this.AnimeViewSearchTerms.Name = "AnimeViewSearchTerms";
            this.AnimeViewSearchTerms.ReadOnly = true;
            this.AnimeViewSearchTerms.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AnimeViewSearchTerms.Text = "0";
            this.AnimeViewSearchTerms.ToolTipText = "Open the search term window for an anime";
            this.AnimeViewSearchTerms.Width = 50;
            // 
            // AnimeNames
            // 
            this.AnimeNames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnimeNames.DataPropertyName = "name";
            this.AnimeNames.HeaderText = "Anime Name";
            this.AnimeNames.MinimumWidth = 100;
            this.AnimeNames.Name = "AnimeNames";
            this.AnimeNames.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AnimeSeason
            // 
            this.AnimeSeason.DataPropertyName = "season";
            this.AnimeSeason.HeaderText = "Season";
            this.AnimeSeason.MinimumWidth = 50;
            this.AnimeSeason.Name = "AnimeSeason";
            this.AnimeSeason.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AnimeSeason.Width = 50;
            // 
            // AnimeEpisodeOffset
            // 
            this.AnimeEpisodeOffset.DataPropertyName = "episode_offset";
            this.AnimeEpisodeOffset.HeaderText = "Episode Offset";
            this.AnimeEpisodeOffset.MinimumWidth = 50;
            this.AnimeEpisodeOffset.Name = "AnimeEpisodeOffset";
            this.AnimeEpisodeOffset.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AnimeEpisodeOffset.Width = 50;
            // 
            // AnimeStorageDrive
            // 
            this.AnimeStorageDrive.DataPropertyName = "drive_letter";
            this.AnimeStorageDrive.HeaderText = "Storage Drive";
            this.AnimeStorageDrive.MinimumWidth = 50;
            this.AnimeStorageDrive.Name = "AnimeStorageDrive";
            this.AnimeStorageDrive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AnimeStorageDrive.Width = 50;
            // 
            // AnimeUpdateData
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.AnimeUpdateData.DefaultCellStyle = dataGridViewCellStyle6;
            this.AnimeUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AnimeUpdateData.HeaderText = "Update";
            this.AnimeUpdateData.MinimumWidth = 50;
            this.AnimeUpdateData.Name = "AnimeUpdateData";
            this.AnimeUpdateData.ReadOnly = true;
            this.AnimeUpdateData.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AnimeUpdateData.Text = "0";
            this.AnimeUpdateData.ToolTipText = "Update the database with the current details for an anime";
            this.AnimeUpdateData.Width = 50;
            // 
            // AnimeDelete
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.AnimeDelete.DefaultCellStyle = dataGridViewCellStyle7;
            this.AnimeDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AnimeDelete.HeaderText = "Delete";
            this.AnimeDelete.MinimumWidth = 50;
            this.AnimeDelete.Name = "AnimeDelete";
            this.AnimeDelete.ReadOnly = true;
            this.AnimeDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AnimeDelete.Text = "0";
            this.AnimeDelete.ToolTipText = "Delete an anime from the database";
            this.AnimeDelete.Width = 50;
            // 
            // AnimeID
            // 
            this.AnimeID.DataPropertyName = "id";
            this.AnimeID.HeaderText = "id";
            this.AnimeID.Name = "AnimeID";
            this.AnimeID.ReadOnly = true;
            this.AnimeID.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer1.Location = new System.Drawing.Point(-1, 59);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AnimeDataView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TVShowDataView);
            this.splitContainer1.Size = new System.Drawing.Size(565, 606);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.AddAnimeButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.AddTVShowButton);
            this.splitContainer2.Size = new System.Drawing.Size(561, 36);
            this.splitContainer2.SplitterDistance = 278;
            this.splitContainer2.TabIndex = 3;
            // 
            // AddAnimeButton
            // 
            this.AddAnimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAnimeButton.Location = new System.Drawing.Point(3, 3);
            this.AddAnimeButton.Name = "AddAnimeButton";
            this.AddAnimeButton.Size = new System.Drawing.Size(272, 30);
            this.AddAnimeButton.TabIndex = 0;
            this.AddAnimeButton.Text = "Add New Anime";
            this.AddAnimeButton.UseVisualStyleBackColor = true;
            this.AddAnimeButton.Click += new System.EventHandler(this.AddAnimeButton_Click);
            // 
            // AddTVShowButton
            // 
            this.AddTVShowButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTVShowButton.Location = new System.Drawing.Point(3, 3);
            this.AddTVShowButton.Name = "AddTVShowButton";
            this.AddTVShowButton.Size = new System.Drawing.Size(273, 30);
            this.AddTVShowButton.TabIndex = 0;
            this.AddTVShowButton.Text = "Add New TV Show";
            this.AddTVShowButton.UseVisualStyleBackColor = true;
            this.AddTVShowButton.Click += new System.EventHandler(this.AddTVShowButton_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = -1;
            this.menuItem1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 26);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderMonitoringToolStripMenuItem,
            this.autoModeToolStripMenuItem});
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // folderMonitoringToolStripMenuItem
            // 
            this.folderMonitoringToolStripMenuItem.Name = "folderMonitoringToolStripMenuItem";
            this.folderMonitoringToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.folderMonitoringToolStripMenuItem.Text = "Monitor settings";
            this.folderMonitoringToolStripMenuItem.Click += new System.EventHandler(this.folderSettingsToolStripMenuItem_Click);
            // 
            // autoModeToolStripMenuItem
            // 
            this.autoModeToolStripMenuItem.Enabled = false;
            this.autoModeToolStripMenuItem.Name = "autoModeToolStripMenuItem";
            this.autoModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoModeToolStripMenuItem.Text = "Auto mode";
            this.autoModeToolStripMenuItem.Click += new System.EventHandler(this.autoModeToolStripMenuItem_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 664);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.DataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainGUI";
            this.Text = "Plex File Sorter GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TVShowDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimeDataView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DataGrid;
        private System.Windows.Forms.DataGridView AnimeDataView;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.DataGridView TVShowDataView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button AddAnimeButton;
        private System.Windows.Forms.Button AddTVShowButton;
        private System.Windows.Forms.DataGridViewButtonColumn TVShowViewSearchTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVShowNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVShowStorageDrive;
        private System.Windows.Forms.DataGridViewButtonColumn TVShowUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn TVShowDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVShowID;
        private System.Windows.Forms.DataGridViewButtonColumn AnimeViewSearchTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimeNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimeSeason;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimeEpisodeOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimeStorageDrive;
        private System.Windows.Forms.DataGridViewButtonColumn AnimeUpdateData;
        private System.Windows.Forms.DataGridViewButtonColumn AnimeDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimeID;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem1;
        private ToolStripMenuItem folderMonitoringToolStripMenuItem;
        private ToolStripMenuItem autoModeToolStripMenuItem;
    }
}

