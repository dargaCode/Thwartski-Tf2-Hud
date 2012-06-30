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
            this.scoreboardImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scoreboardSelector = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.aspectRatioImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.SetColumnSpan(this.folderBrowserTextBox, 6);
            this.folderBrowserTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserTextBox.Location = new System.Drawing.Point(23, 40);
            this.folderBrowserTextBox.Name = "folderBrowserTextBox";
            this.folderBrowserTextBox.Size = new System.Drawing.Size(393, 20);
            this.folderBrowserTextBox.TabIndex = 0;
            this.folderBrowserTextBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\YOUR_USERNAME\\team fortress 2";
            // 
            // folderBrowserButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.folderBrowserButton, 2);
            this.folderBrowserButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserButton.Location = new System.Drawing.Point(422, 39);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(99, 21);
            this.folderBrowserButton.TabIndex = 1;
            this.folderBrowserButton.Text = "Browse";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.folderBrowserButton_Click);
            // 
            // installButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.installButton, 3);
            this.installButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Location = new System.Drawing.Point(275, 497);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(211, 44);
            this.installButton.TabIndex = 2;
            this.installButton.Text = "INSTALL";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 10);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select your Team Fortress 2 folder:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 10);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "What shape is your monitor?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aspectRatioImage
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.aspectRatioImage, 4);
            this.aspectRatioImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectRatioImage.Location = new System.Drawing.Point(128, 106);
            this.aspectRatioImage.Name = "aspectRatioImage";
            this.aspectRatioImage.Size = new System.Drawing.Size(288, 117);
            this.aspectRatioImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aspectRatioImage.TabIndex = 10;
            this.aspectRatioImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 10);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(541, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Which scoreboard do you prefer?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aspectRatioSelector
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.aspectRatioSelector, 2);
            this.aspectRatioSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectRatioSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aspectRatioSelector.FormattingEnabled = true;
            this.aspectRatioSelector.Items.AddRange(new object[] {
            "Blonde",
            "Brunette"});
            this.aspectRatioSelector.Location = new System.Drawing.Point(208, 229);
            this.aspectRatioSelector.Name = "aspectRatioSelector";
            this.aspectRatioSelector.Size = new System.Drawing.Size(128, 21);
            this.aspectRatioSelector.TabIndex = 14;
            this.aspectRatioSelector.SelectedIndexChanged += new System.EventHandler(this.aspectRatioSelector_SelectedIndexChanged);
            // 
            // backupCheckbox
            // 
            this.backupCheckbox.AutoSize = true;
            this.backupCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupCheckbox.Location = new System.Drawing.Point(185, 3);
            this.backupCheckbox.Name = "backupCheckbox";
            this.backupCheckbox.Size = new System.Drawing.Size(171, 17);
            this.backupCheckbox.TabIndex = 17;
            this.backupCheckbox.Text = "Back up existing hud files";
            this.backupCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backupCheckbox.UseVisualStyleBackColor = true;
            this.backupCheckbox.CheckedChanged += new System.EventHandler(this.backupCheckbox_CheckedChanged);
            // 
            // uninstallButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.uninstallButton, 3);
            this.uninstallButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uninstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallButton.Location = new System.Drawing.Point(58, 497);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(211, 44);
            this.uninstallButton.TabIndex = 18;
            this.uninstallButton.Text = "Uninstall";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // scoreboardImage
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.scoreboardImage, 4);
            this.scoreboardImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardImage.Location = new System.Drawing.Point(128, 300);
            this.scoreboardImage.Name = "scoreboardImage";
            this.scoreboardImage.Size = new System.Drawing.Size(288, 117);
            this.scoreboardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scoreboardImage.TabIndex = 19;
            this.scoreboardImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.008677F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.84727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.89568F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.24639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.24639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.89568F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.84727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.012651F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.uninstallButton, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.scoreboardSelector, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.installButton, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.scoreboardImage, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.aspectRatioImage, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.aspectRatioSelector, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.folderBrowserTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.folderBrowserButton, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.150279F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.989037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.920223F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.88865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.967109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.920223F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.88865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.789886F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.664594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.821346F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 558);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // scoreboardSelector
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.scoreboardSelector, 2);
            this.scoreboardSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardSelector.FormattingEnabled = true;
            this.scoreboardSelector.Items.AddRange(new object[] {
            "Jeep",
            "Royal",
            "Swanson",
            "Zissou"});
            this.scoreboardSelector.Location = new System.Drawing.Point(208, 423);
            this.scoreboardSelector.Name = "scoreboardSelector";
            this.scoreboardSelector.Size = new System.Drawing.Size(128, 21);
            this.scoreboardSelector.TabIndex = 20;
            this.scoreboardSelector.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelector_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 10);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.6414F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.71719F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.45656F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.backupCheckbox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 468);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(541, 23);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(547, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thwartski Hud Installer";
            ((System.ComponentModel.ISupportInitialize)(this.aspectRatioImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox scoreboardImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox scoreboardSelector;
    }
}

