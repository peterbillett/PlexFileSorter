namespace PlexFileSorterGUI
{
    partial class FolderSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderSettings));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.animeCheckBox = new System.Windows.Forms.CheckBox();
            this.updateAnime = new System.Windows.Forms.Button();
            this.animeSaveLocationButton = new System.Windows.Forms.Button();
            this.animeDownloadLocationButton = new System.Windows.Forms.Button();
            this.animeSaveLocation = new System.Windows.Forms.TextBox();
            this.animeDownloadLocation = new System.Windows.Forms.TextBox();
            this.tvshowCheckBox = new System.Windows.Forms.CheckBox();
            this.updateTVShow = new System.Windows.Forms.Button();
            this.tvshowSaveLocationButtom = new System.Windows.Forms.Button();
            this.tvshowDownloadLocationButton = new System.Windows.Forms.Button();
            this.tvshowDownloadLocation = new System.Windows.Forms.TextBox();
            this.tvshowSaveLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.animeCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.updateAnime);
            this.splitContainer1.Panel1.Controls.Add(this.animeSaveLocationButton);
            this.splitContainer1.Panel1.Controls.Add(this.animeDownloadLocationButton);
            this.splitContainer1.Panel1.Controls.Add(this.animeSaveLocation);
            this.splitContainer1.Panel1.Controls.Add(this.animeDownloadLocation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tvshowCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.updateTVShow);
            this.splitContainer1.Panel2.Controls.Add(this.tvshowSaveLocationButtom);
            this.splitContainer1.Panel2.Controls.Add(this.tvshowDownloadLocationButton);
            this.splitContainer1.Panel2.Controls.Add(this.tvshowDownloadLocation);
            this.splitContainer1.Panel2.Controls.Add(this.tvshowSaveLocation);
            this.splitContainer1.Size = new System.Drawing.Size(549, 211);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 0;
            // 
            // animeCheckBox
            // 
            this.animeCheckBox.AutoSize = true;
            this.animeCheckBox.Location = new System.Drawing.Point(13, 69);
            this.animeCheckBox.Name = "animeCheckBox";
            this.animeCheckBox.Size = new System.Drawing.Size(65, 17);
            this.animeCheckBox.TabIndex = 11;
            this.animeCheckBox.Text = "Enabled";
            this.animeCheckBox.UseVisualStyleBackColor = true;
            // 
            // updateAnime
            // 
            this.updateAnime.Location = new System.Drawing.Point(216, 71);
            this.updateAnime.Name = "updateAnime";
            this.updateAnime.Size = new System.Drawing.Size(116, 23);
            this.updateAnime.TabIndex = 10;
            this.updateAnime.Text = "Update Anime";
            this.updateAnime.UseVisualStyleBackColor = true;
            // 
            // animeSaveLocationButton
            // 
            this.animeSaveLocationButton.Location = new System.Drawing.Point(455, 40);
            this.animeSaveLocationButton.Name = "animeSaveLocationButton";
            this.animeSaveLocationButton.Size = new System.Drawing.Size(81, 23);
            this.animeSaveLocationButton.TabIndex = 3;
            this.animeSaveLocationButton.Text = "Browse";
            this.animeSaveLocationButton.UseVisualStyleBackColor = true;
            // 
            // animeDownloadLocationButton
            // 
            this.animeDownloadLocationButton.Location = new System.Drawing.Point(455, 11);
            this.animeDownloadLocationButton.Name = "animeDownloadLocationButton";
            this.animeDownloadLocationButton.Size = new System.Drawing.Size(81, 23);
            this.animeDownloadLocationButton.TabIndex = 2;
            this.animeDownloadLocationButton.Text = "Browse";
            this.animeDownloadLocationButton.UseVisualStyleBackColor = true;
            // 
            // animeSaveLocation
            // 
            this.animeSaveLocation.Location = new System.Drawing.Point(12, 42);
            this.animeSaveLocation.Name = "animeSaveLocation";
            this.animeSaveLocation.Size = new System.Drawing.Size(436, 20);
            this.animeSaveLocation.TabIndex = 1;
            this.animeSaveLocation.Text = "Path to move files to";
            // 
            // animeDownloadLocation
            // 
            this.animeDownloadLocation.Location = new System.Drawing.Point(13, 13);
            this.animeDownloadLocation.Name = "animeDownloadLocation";
            this.animeDownloadLocation.Size = new System.Drawing.Size(436, 20);
            this.animeDownloadLocation.TabIndex = 0;
            this.animeDownloadLocation.Text = "Folder to monitor";
            // 
            // tvshowCheckBox
            // 
            this.tvshowCheckBox.AutoSize = true;
            this.tvshowCheckBox.Location = new System.Drawing.Point(12, 70);
            this.tvshowCheckBox.Name = "tvshowCheckBox";
            this.tvshowCheckBox.Size = new System.Drawing.Size(65, 17);
            this.tvshowCheckBox.TabIndex = 12;
            this.tvshowCheckBox.Text = "Enabled";
            this.tvshowCheckBox.UseVisualStyleBackColor = true;
            // 
            // updateTVShow
            // 
            this.updateTVShow.Location = new System.Drawing.Point(216, 72);
            this.updateTVShow.Name = "updateTVShow";
            this.updateTVShow.Size = new System.Drawing.Size(116, 23);
            this.updateTVShow.TabIndex = 12;
            this.updateTVShow.Text = "Update TV Shows";
            this.updateTVShow.UseVisualStyleBackColor = true;
            // 
            // tvshowSaveLocationButtom
            // 
            this.tvshowSaveLocationButtom.Location = new System.Drawing.Point(455, 42);
            this.tvshowSaveLocationButtom.Name = "tvshowSaveLocationButtom";
            this.tvshowSaveLocationButtom.Size = new System.Drawing.Size(81, 23);
            this.tvshowSaveLocationButtom.TabIndex = 5;
            this.tvshowSaveLocationButtom.Text = "Browse";
            this.tvshowSaveLocationButtom.UseVisualStyleBackColor = true;
            // 
            // tvshowDownloadLocationButton
            // 
            this.tvshowDownloadLocationButton.Location = new System.Drawing.Point(456, 13);
            this.tvshowDownloadLocationButton.Name = "tvshowDownloadLocationButton";
            this.tvshowDownloadLocationButton.Size = new System.Drawing.Size(81, 23);
            this.tvshowDownloadLocationButton.TabIndex = 4;
            this.tvshowDownloadLocationButton.Text = "Browse";
            this.tvshowDownloadLocationButton.UseVisualStyleBackColor = true;
            // 
            // tvshowDownloadLocation
            // 
            this.tvshowDownloadLocation.Location = new System.Drawing.Point(12, 15);
            this.tvshowDownloadLocation.Name = "tvshowDownloadLocation";
            this.tvshowDownloadLocation.Size = new System.Drawing.Size(437, 20);
            this.tvshowDownloadLocation.TabIndex = 3;
            this.tvshowDownloadLocation.Text = "Folder to monitor";
            // 
            // tvshowSaveLocation
            // 
            this.tvshowSaveLocation.Location = new System.Drawing.Point(12, 44);
            this.tvshowSaveLocation.Name = "tvshowSaveLocation";
            this.tvshowSaveLocation.Size = new System.Drawing.Size(437, 20);
            this.tvshowSaveLocation.TabIndex = 4;
            this.tvshowSaveLocation.Text = "Path to move files to";
            // 
            // FolderSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 211);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FolderSettings";
            this.Text = "Monitor Settings";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox animeSaveLocation;
        private System.Windows.Forms.TextBox animeDownloadLocation;
        private System.Windows.Forms.Button animeSaveLocationButton;
        private System.Windows.Forms.Button animeDownloadLocationButton;
        private System.Windows.Forms.Button tvshowSaveLocationButtom;
        private System.Windows.Forms.Button tvshowDownloadLocationButton;
        private System.Windows.Forms.TextBox tvshowDownloadLocation;
        private System.Windows.Forms.TextBox tvshowSaveLocation;
        private System.Windows.Forms.Button updateAnime;
        private System.Windows.Forms.Button updateTVShow;
        private System.Windows.Forms.CheckBox animeCheckBox;
        private System.Windows.Forms.CheckBox tvshowCheckBox;
    }
}