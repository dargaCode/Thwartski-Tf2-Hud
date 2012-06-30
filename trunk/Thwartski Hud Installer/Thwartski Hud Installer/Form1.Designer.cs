namespace Thwartski_Hud_Installer
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aspectRatioImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aspectRatioSelector = new System.Windows.Forms.ComboBox();
            this.backupCheckbox = new System.Windows.Forms.CheckBox();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.scoreboardSelector = new System.Windows.Forms.ComboBox();
            this.scoreboardImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aspectRatioImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select the \\Team Fortress 2\\ folder from your \\Steam\\Steamapps\\USERNAME\\ folder.";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // folderBrowserTextBox
            // 
            this.folderBrowserTextBox.BackColor = System.Drawing.Color.LightPink;
            this.folderBrowserTextBox.Location = new System.Drawing.Point(15, 35);
            this.folderBrowserTextBox.Name = "folderBrowserTextBox";
            this.folderBrowserTextBox.Size = new System.Drawing.Size(439, 20);
            this.folderBrowserTextBox.TabIndex = 0;
            this.folderBrowserTextBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\YOUR_USERNAME\\team fortress 2";
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Location = new System.Drawing.Point(460, 33);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.folderBrowserButton.TabIndex = 1;
            this.folderBrowserButton.Text = "Browse";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.folderBrowserButton_Click);
            // 
            // installButton
            // 
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Location = new System.Drawing.Point(264, 486);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(132, 49);
            this.installButton.TabIndex = 2;
            this.installButton.Text = "INSTALL";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select your Team Fortress 2 folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "What shape is your monitor?";
            // 
            // aspectRatioImage
            // 
            this.aspectRatioImage.Location = new System.Drawing.Point(178, 109);
            this.aspectRatioImage.Name = "aspectRatioImage";
            this.aspectRatioImage.Size = new System.Drawing.Size(166, 93);
            this.aspectRatioImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aspectRatioImage.TabIndex = 10;
            this.aspectRatioImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Which scoreboard do you prefer?";
            // 
            // aspectRatioSelector
            // 
            this.aspectRatioSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aspectRatioSelector.FormattingEnabled = true;
            this.aspectRatioSelector.Items.AddRange(new object[] {
            "Blonde",
            "Brunette"});
            this.aspectRatioSelector.Location = new System.Drawing.Point(198, 208);
            this.aspectRatioSelector.Name = "aspectRatioSelector";
            this.aspectRatioSelector.Size = new System.Drawing.Size(121, 21);
            this.aspectRatioSelector.TabIndex = 14;
            this.aspectRatioSelector.SelectedIndexChanged += new System.EventHandler(this.aspectRatioSelector_SelectedIndexChanged);
            // 
            // backupCheckbox
            // 
            this.backupCheckbox.AutoSize = true;
            this.backupCheckbox.Location = new System.Drawing.Point(178, 452);
            this.backupCheckbox.Name = "backupCheckbox";
            this.backupCheckbox.Size = new System.Drawing.Size(146, 17);
            this.backupCheckbox.TabIndex = 17;
            this.backupCheckbox.Text = "Back up existing hud files";
            this.backupCheckbox.UseVisualStyleBackColor = true;
            this.backupCheckbox.CheckedChanged += new System.EventHandler(this.backupCheckbox_CheckedChanged);
            // 
            // uninstallButton
            // 
            this.uninstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallButton.Location = new System.Drawing.Point(126, 486);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(132, 49);
            this.uninstallButton.TabIndex = 18;
            this.uninstallButton.Text = "Uninstall";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // scoreboardSelector
            // 
            this.scoreboardSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardSelector.FormattingEnabled = true;
            this.scoreboardSelector.Items.AddRange(new object[] {
            "Jeep",
            "Royal",
            "Swanson",
            "Zissou"});
            this.scoreboardSelector.Location = new System.Drawing.Point(198, 405);
            this.scoreboardSelector.Name = "scoreboardSelector";
            this.scoreboardSelector.Size = new System.Drawing.Size(121, 21);
            this.scoreboardSelector.TabIndex = 20;
            this.scoreboardSelector.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelector_SelectedIndexChanged);
            // 
            // scoreboardImage
            // 
            this.scoreboardImage.Location = new System.Drawing.Point(178, 306);
            this.scoreboardImage.Name = "scoreboardImage";
            this.scoreboardImage.Size = new System.Drawing.Size(166, 93);
            this.scoreboardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scoreboardImage.TabIndex = 19;
            this.scoreboardImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(547, 558);
            this.Controls.Add(this.scoreboardSelector);
            this.Controls.Add(this.scoreboardImage);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.backupCheckbox);
            this.Controls.Add(this.aspectRatioSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aspectRatioImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.folderBrowserButton);
            this.Controls.Add(this.folderBrowserTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thwartski Hud Installer";
            ((System.ComponentModel.ISupportInitialize)(this.aspectRatioImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox folderBrowserTextBox;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox aspectRatioImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox aspectRatioSelector;
        private System.Windows.Forms.CheckBox backupCheckbox;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.ComboBox scoreboardSelector;
        private System.Windows.Forms.PictureBox scoreboardImage;
    }
}

