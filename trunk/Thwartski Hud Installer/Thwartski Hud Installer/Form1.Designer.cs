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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backupsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.browseFolderInstructionsLabel = new System.Windows.Forms.Label();
            this.aspectLabel = new System.Windows.Forms.Label();
            this.aspectSelector = new System.Windows.Forms.ComboBox();
            this.scoreboardMaxmodeLabel = new System.Windows.Forms.Label();
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.form1LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.scoreboardMinmodeLabel = new System.Windows.Forms.Label();
            this.scoreboardSelectorMinmode = new System.Windows.Forms.ComboBox();
            this.scoreboardSelectorMaxmode = new System.Windows.Forms.ComboBox();
            this.scoreboardPictureboxMaxmode = new System.Windows.Forms.PictureBox();
            this.scoreboardPictureboxMinmode = new System.Windows.Forms.PictureBox();
            this.aspectImageBox = new System.Windows.Forms.PictureBox();
            this.browserLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.folderBrowserBoxLabel = new System.Windows.Forms.Label();
            this.form1LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMaxmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMinmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).BeginInit();
            this.browserLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // backupsLayoutPanel
            // 
            this.backupsLayoutPanel.ColumnCount = 3;
            this.form1LayoutPanel.SetColumnSpan(this.backupsLayoutPanel, 4);
            this.backupsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.67397F));
            this.backupsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.backupsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.32603F));
            this.backupsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupsLayoutPanel.Location = new System.Drawing.Point(165, 574);
            this.backupsLayoutPanel.Name = "backupsLayoutPanel";
            this.backupsLayoutPanel.RowCount = 1;
            this.backupsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backupsLayoutPanel.Size = new System.Drawing.Size(210, 25);
            this.backupsLayoutPanel.TabIndex = 4;
            // 
            // folderBrowserButton
            // 
            this.form1LayoutPanel.SetColumnSpan(this.folderBrowserButton, 2);
            this.folderBrowserButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserButton.Location = new System.Drawing.Point(435, 43);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(82, 21);
            this.folderBrowserButton.TabIndex = 1;
            this.folderBrowserButton.Text = "Browse";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.folderBrowserButton_Click);
            // 
            // browseFolderInstructionsLabel
            // 
            this.browseFolderInstructionsLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.browseFolderInstructionsLabel, 6);
            this.browseFolderInstructionsLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.browseFolderInstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseFolderInstructionsLabel.Location = new System.Drawing.Point(111, 17);
            this.browseFolderInstructionsLabel.Name = "browseFolderInstructionsLabel";
            this.browseFolderInstructionsLabel.Size = new System.Drawing.Size(318, 15);
            this.browseFolderInstructionsLabel.TabIndex = 3;
            this.browseFolderInstructionsLabel.Text = "Please select your Team Fortress 2 folder:";
            this.browseFolderInstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aspectLabel
            // 
            this.aspectLabel.AutoSize = true;
            this.aspectLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.form1LayoutPanel.SetColumnSpan(this.aspectLabel, 4);
            this.aspectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspectLabel.Location = new System.Drawing.Point(165, 229);
            this.aspectLabel.Name = "aspectLabel";
            this.aspectLabel.Size = new System.Drawing.Size(210, 25);
            this.aspectLabel.TabIndex = 6;
            this.aspectLabel.Text = "What shape is your monitor?";
            this.aspectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aspectSelector
            // 
            this.aspectSelector.BackColor = System.Drawing.SystemColors.Window;
            this.form1LayoutPanel.SetColumnSpan(this.aspectSelector, 2);
            this.aspectSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aspectSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspectSelector.FormattingEnabled = true;
            this.aspectSelector.Location = new System.Drawing.Point(219, 257);
            this.aspectSelector.Name = "aspectSelector";
            this.aspectSelector.Size = new System.Drawing.Size(102, 21);
            this.aspectSelector.TabIndex = 2;
            this.aspectSelector.SelectedIndexChanged += new System.EventHandler(this.aspectSelector_SelectedIndexChanged);
            // 
            // scoreboardMaxmodeLabel
            // 
            this.scoreboardMaxmodeLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMaxmodeLabel, 4);
            this.scoreboardMaxmodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMaxmodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardMaxmodeLabel.Location = new System.Drawing.Point(57, 449);
            this.scoreboardMaxmodeLabel.Name = "scoreboardMaxmodeLabel";
            this.scoreboardMaxmodeLabel.Size = new System.Drawing.Size(210, 21);
            this.scoreboardMaxmodeLabel.TabIndex = 12;
            this.scoreboardMaxmodeLabel.Text = "Pub Server Scoreboard:";
            this.scoreboardMaxmodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // installButton
            // 
            this.form1LayoutPanel.SetColumnSpan(this.installButton, 4);
            this.installButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installButton.Enabled = false;
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Location = new System.Drawing.Point(273, 517);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(210, 51);
            this.installButton.TabIndex = 15;
            this.installButton.Text = "Install Hud";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_InstallClick);
            // 
            // uninstallButton
            // 
            this.form1LayoutPanel.SetColumnSpan(this.uninstallButton, 4);
            this.uninstallButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uninstallButton.Enabled = false;
            this.uninstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallButton.Location = new System.Drawing.Point(57, 517);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(210, 51);
            this.uninstallButton.TabIndex = 18;
            this.uninstallButton.TabStop = false;
            this.uninstallButton.Text = "Uninstall Hud";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // form1LayoutPanel
            // 
            this.form1LayoutPanel.ColumnCount = 12;
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.865629F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.78266F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.78452F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.78453F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.78266F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.78266F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.78453F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.78452F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.78266F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.865629F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.form1LayoutPanel.Controls.Add(this.scoreboardMinmodeLabel, 6, 7);
            this.form1LayoutPanel.Controls.Add(this.scoreboardSelectorMinmode, 7, 8);
            this.form1LayoutPanel.Controls.Add(this.uninstallButton, 2, 9);
            this.form1LayoutPanel.Controls.Add(this.scoreboardSelectorMaxmode, 3, 8);
            this.form1LayoutPanel.Controls.Add(this.installButton, 6, 9);
            this.form1LayoutPanel.Controls.Add(this.scoreboardPictureboxMaxmode, 2, 6);
            this.form1LayoutPanel.Controls.Add(this.scoreboardPictureboxMinmode, 5, 6);
            this.form1LayoutPanel.Controls.Add(this.aspectImageBox, 3, 3);
            this.form1LayoutPanel.Controls.Add(this.scoreboardMaxmodeLabel, 2, 7);
            this.form1LayoutPanel.Controls.Add(this.aspectSelector, 5, 5);
            this.form1LayoutPanel.Controls.Add(this.aspectLabel, 4, 4);
            this.form1LayoutPanel.Controls.Add(this.browseFolderInstructionsLabel, 3, 0);
            this.form1LayoutPanel.Controls.Add(this.folderBrowserButton, 9, 1);
            this.form1LayoutPanel.Controls.Add(this.browserLayoutPanel, 1, 1);
            this.form1LayoutPanel.Controls.Add(this.backupsLayoutPanel, 4, 10);
            this.form1LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form1LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.form1LayoutPanel.Name = "form1LayoutPanel";
            this.form1LayoutPanel.RowCount = 12;
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.245085F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.938705F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.4256F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.388669F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.719901F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.4256F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.686482F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.729898F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.97004F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.47002F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.form1LayoutPanel.Size = new System.Drawing.Size(547, 614);
            this.form1LayoutPanel.TabIndex = 21;
            // 
            // scoreboardMinmodeLabel
            // 
            this.scoreboardMinmodeLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMinmodeLabel, 4);
            this.scoreboardMinmodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMinmodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardMinmodeLabel.Location = new System.Drawing.Point(273, 449);
            this.scoreboardMinmodeLabel.Name = "scoreboardMinmodeLabel";
            this.scoreboardMinmodeLabel.Size = new System.Drawing.Size(210, 21);
            this.scoreboardMinmodeLabel.TabIndex = 28;
            this.scoreboardMinmodeLabel.Text = "Competitive Scoreboard:";
            this.scoreboardMinmodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreboardSelectorMinmode
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardSelectorMinmode, 2);
            this.scoreboardSelectorMinmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardSelectorMinmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardSelectorMinmode.FormattingEnabled = true;
            this.scoreboardSelectorMinmode.Location = new System.Drawing.Point(327, 473);
            this.scoreboardSelectorMinmode.Name = "scoreboardSelectorMinmode";
            this.scoreboardSelectorMinmode.Size = new System.Drawing.Size(102, 21);
            this.scoreboardSelectorMinmode.TabIndex = 27;
            this.scoreboardSelectorMinmode.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelectorMinmode_SelectedIndexChanged);
            // 
            // scoreboardSelectorMaxmode
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardSelectorMaxmode, 2);
            this.scoreboardSelectorMaxmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardSelectorMaxmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardSelectorMaxmode.FormattingEnabled = true;
            this.scoreboardSelectorMaxmode.Location = new System.Drawing.Point(111, 473);
            this.scoreboardSelectorMaxmode.Name = "scoreboardSelectorMaxmode";
            this.scoreboardSelectorMaxmode.Size = new System.Drawing.Size(102, 21);
            this.scoreboardSelectorMaxmode.TabIndex = 3;
            this.scoreboardSelectorMaxmode.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelectorMaxmode_SelectedIndexChanged);
            // 
            // scoreboardPictureboxMaxmode
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardPictureboxMaxmode, 4);
            this.scoreboardPictureboxMaxmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardPictureboxMaxmode.Location = new System.Drawing.Point(57, 301);
            this.scoreboardPictureboxMaxmode.Name = "scoreboardPictureboxMaxmode";
            this.scoreboardPictureboxMaxmode.Size = new System.Drawing.Size(210, 145);
            this.scoreboardPictureboxMaxmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scoreboardPictureboxMaxmode.TabIndex = 19;
            this.scoreboardPictureboxMaxmode.TabStop = false;
            // 
            // scoreboardPictureboxMinmode
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardPictureboxMinmode, 4);
            this.scoreboardPictureboxMinmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardPictureboxMinmode.Location = new System.Drawing.Point(273, 301);
            this.scoreboardPictureboxMinmode.Name = "scoreboardPictureboxMinmode";
            this.scoreboardPictureboxMinmode.Size = new System.Drawing.Size(210, 145);
            this.scoreboardPictureboxMinmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scoreboardPictureboxMinmode.TabIndex = 26;
            this.scoreboardPictureboxMinmode.TabStop = false;
            // 
            // aspectImageBox
            // 
            this.form1LayoutPanel.SetColumnSpan(this.aspectImageBox, 6);
            this.aspectImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectImageBox.Location = new System.Drawing.Point(111, 81);
            this.aspectImageBox.Name = "aspectImageBox";
            this.aspectImageBox.Size = new System.Drawing.Size(318, 145);
            this.aspectImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aspectImageBox.TabIndex = 10;
            this.aspectImageBox.TabStop = false;
            // 
            // browserLayoutPanel
            // 
            this.browserLayoutPanel.ColumnCount = 2;
            this.form1LayoutPanel.SetColumnSpan(this.browserLayoutPanel, 8);
            this.browserLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.005013F));
            this.browserLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.99499F));
            this.browserLayoutPanel.Controls.Add(this.folderBrowserBoxLabel, 1, 0);
            this.browserLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserLayoutPanel.Location = new System.Drawing.Point(23, 35);
            this.browserLayoutPanel.Name = "browserLayoutPanel";
            this.browserLayoutPanel.RowCount = 1;
            this.browserLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.browserLayoutPanel.Size = new System.Drawing.Size(406, 29);
            this.browserLayoutPanel.TabIndex = 25;
            // 
            // folderBrowserBoxLabel
            // 
            this.folderBrowserBoxLabel.BackColor = System.Drawing.Color.LightPink;
            this.folderBrowserBoxLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserBoxLabel.Location = new System.Drawing.Point(11, 8);
            this.folderBrowserBoxLabel.Name = "folderBrowserBoxLabel";
            this.folderBrowserBoxLabel.Size = new System.Drawing.Size(392, 21);
            this.folderBrowserBoxLabel.TabIndex = 25;
            this.folderBrowserBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(547, 614);
            this.Controls.Add(this.form1LayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thwartski Hud Installer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.form1LayoutPanel.ResumeLayout(false);
            this.form1LayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMaxmode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMinmode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).EndInit();
            this.browserLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel backupsLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel form1LayoutPanel;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.PictureBox scoreboardPictureboxMaxmode;
        private System.Windows.Forms.PictureBox aspectImageBox;
        private System.Windows.Forms.Label scoreboardMaxmodeLabel;
        private System.Windows.Forms.ComboBox aspectSelector;
        private System.Windows.Forms.Label aspectLabel;
        private System.Windows.Forms.Label browseFolderInstructionsLabel;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.TableLayoutPanel browserLayoutPanel;
        private System.Windows.Forms.Label folderBrowserBoxLabel;
        private System.Windows.Forms.ComboBox scoreboardSelectorMaxmode;
        private System.Windows.Forms.PictureBox scoreboardPictureboxMinmode;
        private System.Windows.Forms.ComboBox scoreboardSelectorMinmode;
        private System.Windows.Forms.Label scoreboardMinmodeLabel;
    }
}

