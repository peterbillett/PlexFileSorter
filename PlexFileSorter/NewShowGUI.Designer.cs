using System.Drawing;

namespace PlexFileSorterGUI
{
    partial class NewShowGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewShowGUI));
            this.submitNewShowButton = new System.Windows.Forms.Button();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.newSeasonTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seasonLabel = new System.Windows.Forms.Label();
            this.episodeOffsetLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newEpisodeOffsetTextBox = new System.Windows.Forms.TextBox();
            this.newStorageDriveTextBox = new System.Windows.Forms.TextBox();
            this.showType = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // submitNewShowButton
            // 
            this.submitNewShowButton.Location = new System.Drawing.Point(154, 90);
            this.submitNewShowButton.Name = "submitNewShowButton";
            this.submitNewShowButton.Size = new System.Drawing.Size(187, 39);
            this.submitNewShowButton.TabIndex = 1;
            this.submitNewShowButton.Text = "Add to database";
            this.submitNewShowButton.UseVisualStyleBackColor = true;
            this.submitNewShowButton.Click += new System.EventHandler(this.SubmitNewShowButton_Click);
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(73, 27);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(410, 20);
            this.newNameTextBox.TabIndex = 0;
            // 
            // newSeasonTextBox
            // 
            this.newSeasonTextBox.Location = new System.Drawing.Point(72, 53);
            this.newSeasonTextBox.Name = "newSeasonTextBox";
            this.newSeasonTextBox.Size = new System.Drawing.Size(46, 20);
            this.newSeasonTextBox.TabIndex = 2;
            this.newSeasonTextBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAME";
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonLabel.Location = new System.Drawing.Point(12, 56);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(57, 13);
            this.seasonLabel.TabIndex = 3;
            this.seasonLabel.Text = "SEASON";
            // 
            // episodeOffsetLabel
            // 
            this.episodeOffsetLabel.AutoSize = true;
            this.episodeOffsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeOffsetLabel.Location = new System.Drawing.Point(139, 56);
            this.episodeOffsetLabel.Name = "episodeOffsetLabel";
            this.episodeOffsetLabel.Size = new System.Drawing.Size(112, 13);
            this.episodeOffsetLabel.TabIndex = 4;
            this.episodeOffsetLabel.Text = "EPISODE OFFSET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "STORAGE DRIVE";
            // 
            // newEpisodeOffsetTextBox
            // 
            this.newEpisodeOffsetTextBox.Location = new System.Drawing.Point(255, 54);
            this.newEpisodeOffsetTextBox.Name = "newEpisodeOffsetTextBox";
            this.newEpisodeOffsetTextBox.Size = new System.Drawing.Size(46, 20);
            this.newEpisodeOffsetTextBox.TabIndex = 6;
            this.newEpisodeOffsetTextBox.Text = "0";
            // 
            // newStorageDriveTextBox
            // 
            this.newStorageDriveTextBox.Location = new System.Drawing.Point(437, 53);
            this.newStorageDriveTextBox.MaxLength = 1;
            this.newStorageDriveTextBox.Name = "newStorageDriveTextBox";
            this.newStorageDriveTextBox.Size = new System.Drawing.Size(46, 20);
            this.newStorageDriveTextBox.TabIndex = 7;
            this.newStorageDriveTextBox.Text = "C";
            // 
            // showType
            // 
            this.showType.Location = new System.Drawing.Point(382, 108);
            this.showType.Name = "showType";
            this.showType.Size = new System.Drawing.Size(100, 20);
            this.showType.TabIndex = 8;
            this.showType.Visible = false;
            // 
            // NewShowGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 152);
            this.Controls.Add(this.showType);
            this.Controls.Add(this.newStorageDriveTextBox);
            this.Controls.Add(this.newEpisodeOffsetTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.episodeOffsetLabel);
            this.Controls.Add(this.seasonLabel);
            this.Controls.Add(this.newSeasonTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newNameTextBox);
            this.Controls.Add(this.submitNewShowButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewShowGUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new show";
            this.Load += new System.EventHandler(this.NewShowGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.TextBox newSeasonTextBox;
        private System.Windows.Forms.Button submitNewShowButton;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label seasonLabel;
        private System.Windows.Forms.Label episodeOffsetLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newEpisodeOffsetTextBox;
        private System.Windows.Forms.TextBox newStorageDriveTextBox;
        private System.Windows.Forms.TextBox showType;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}