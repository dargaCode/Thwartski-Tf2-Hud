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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.backupCheckbox = new System.Windows.Forms.CheckBox();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.folderBrowserTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aspectSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aspectImageBox = new System.Windows.Forms.PictureBox();
            this.scoreboardImage = new System.Windows.Forms.PictureBox();
            this.installButton = new System.Windows.Forms.Button();
            this.scoreboardSelector = new System.Windows.Forms.ComboBox();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 10);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.48983F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.86876F));
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 520);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(541, 23);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // backupCheckbox
            // 
            this.backupCheckbox.AutoSize = true;
            this.backupCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupCheckbox.Location = new System.Drawing.Point(195, 3);
            this.backupCheckbox.Name = "backupCheckbox";
            this.backupCheckbox.Size = new System.Drawing.Size(161, 17);
            this.backupCheckbox.TabIndex = 17;
            this.backupCheckbox.Text = "Back up existing hud files";
            this.backupCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backupCheckbox.UseVisualStyleBackColor = true;
            this.backupCheckbox.CheckedChanged += new System.EventHandler(this.backupCheckbox_CheckedChanged);
            // 
            // folderBrowserButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.folderBrowserButton, 2);
            this.folderBrowserButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserButton.Location = new System.Drawing.Point(428, 43);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(89, 21);
            this.folderBrowserButton.TabIndex = 1;
            this.folderBrowserButton.Text = "Browse";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.folderBrowserButton_Click);
            // 
            // folderBrowserTextBox
            // 
            this.folderBrowserTextBox.BackColor = System.Drawing.Color.LightPink;
            this.tableLayoutPanel1.SetColumnSpan(this.folderBrowserTextBox, 6);
            this.folderBrowserTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserTextBox.Location = new System.Drawing.Point(23, 44);
            this.folderBrowserTextBox.Name = "folderBrowserTextBox";
            this.folderBrowserTextBox.Size = new System.Drawing.Size(399, 20);
            this.folderBrowserTextBox.TabIndex = 0;
            this.folderBrowserTextBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\YOUR_USERNAME\\team fortress 2";
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
            this.label2.Size = new System.Drawing.Size(541, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "What shape is your monitor?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aspectSelector
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.aspectSelector, 2);
            this.aspectSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aspectSelector.FormattingEnabled = true;
            this.aspectSelector.Location = new System.Drawing.Point(218, 256);
            this.aspectSelector.Name = "aspectSelector";
            this.aspectSelector.Size = new System.Drawing.Size(104, 21);
            this.aspectSelector.TabIndex = 14;
            this.aspectSelector.SelectedIndexChanged += new System.EventHandler(this.aspectSelector_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 10);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(541, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Which scoreboard do you prefer?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aspectImageBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.aspectImageBox, 4);
            this.aspectImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectImageBox.Location = new System.Drawing.Point(118, 105);
            this.aspectImageBox.Name = "aspectImageBox";
            this.aspectImageBox.Size = new System.Drawing.Size(304, 145);
            this.aspectImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aspectImageBox.TabIndex = 10;
            this.aspectImageBox.TabStop = false;
            // 
            // scoreboardImage
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.scoreboardImage, 4);
            this.scoreboardImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardImage.Location = new System.Drawing.Point(118, 321);
            this.scoreboardImage.Name = "scoreboardImage";
            this.scoreboardImage.Size = new System.Drawing.Size(304, 145);
            this.scoreboardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scoreboardImage.TabIndex = 19;
            this.scoreboardImage.TabStop = false;
            // 
            // installButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.installButton, 3);
            this.installButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installButton.Enabled = false;
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Location = new System.Drawing.Point(273, 549);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(209, 50);
            this.installButton.TabIndex = 2;
            this.installButton.Text = "INSTALL";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // scoreboardSelector
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.scoreboardSelector, 2);
            this.scoreboardSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardSelector.FormattingEnabled = true;
            this.scoreboardSelector.Location = new System.Drawing.Point(218, 472);
            this.scoreboardSelector.Name = "scoreboardSelector";
            this.scoreboardSelector.Size = new System.Drawing.Size(104, 21);
            this.scoreboardSelector.TabIndex = 20;
            this.scoreboardSelector.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelector_SelectedIndexChanged);
            // 
            // uninstallButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.uninstallButton, 3);
            this.uninstallButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uninstallButton.Enabled = false;
            this.uninstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallButton.Location = new System.Drawing.Point(58, 549);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(209, 50);
            this.uninstallButton.TabIndex = 18;
            this.uninstallButton.Text = "Uninstall";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.uninstallButton, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.scoreboardSelector, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.installButton, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.scoreboardImage, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.aspectImageBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.aspectSelector, 4, 5);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.211861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.941594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.236204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.33707F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.413358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.059696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.33707F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.442681F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.100787F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.919685F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 614);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(547, 614);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thwartski Hud Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.ComboBox scoreboardSelector;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.PictureBox scoreboardImage;
        private System.Windows.Forms.PictureBox aspectImageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox aspectSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderBrowserTextBox;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.CheckBox backupCheckbox;
    }
}

