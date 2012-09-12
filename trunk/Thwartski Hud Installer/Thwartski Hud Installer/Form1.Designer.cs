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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserBoxLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.form1LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMaxmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMinmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // browseFolderInstructionsLabel
            // 
            this.browseFolderInstructionsLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.browseFolderInstructionsLabel, 6);
            this.browseFolderInstructionsLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.browseFolderInstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseFolderInstructionsLabel.Location = new System.Drawing.Point(83, 13);
            this.browseFolderInstructionsLabel.Name = "browseFolderInstructionsLabel";
            this.browseFolderInstructionsLabel.Size = new System.Drawing.Size(330, 15);
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
            this.aspectLabel.Location = new System.Drawing.Point(139, 231);
            this.aspectLabel.Name = "aspectLabel";
            this.aspectLabel.Size = new System.Drawing.Size(218, 25);
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
            this.aspectSelector.Location = new System.Drawing.Point(195, 259);
            this.aspectSelector.Name = "aspectSelector";
            this.aspectSelector.Size = new System.Drawing.Size(106, 21);
            this.aspectSelector.TabIndex = 2;
            this.aspectSelector.SelectedIndexChanged += new System.EventHandler(this.aspectSelector_SelectedIndexChanged);
            // 
            // scoreboardMaxmodeLabel
            // 
            this.scoreboardMaxmodeLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMaxmodeLabel, 4);
            this.scoreboardMaxmodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMaxmodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardMaxmodeLabel.Location = new System.Drawing.Point(27, 451);
            this.scoreboardMaxmodeLabel.Name = "scoreboardMaxmodeLabel";
            this.scoreboardMaxmodeLabel.Size = new System.Drawing.Size(218, 25);
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
            this.installButton.Location = new System.Drawing.Point(251, 523);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(218, 42);
            this.installButton.TabIndex = 0;
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
            this.uninstallButton.Location = new System.Drawing.Point(27, 523);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(218, 42);
            this.uninstallButton.TabIndex = 5;
            this.uninstallButton.Text = "Uninstall Hud";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // form1LayoutPanel
            // 
            this.form1LayoutPanel.ColumnCount = 10;
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.form1LayoutPanel.Controls.Add(this.scoreboardMinmodeLabel, 5, 7);
            this.form1LayoutPanel.Controls.Add(this.scoreboardSelectorMinmode, 6, 8);
            this.form1LayoutPanel.Controls.Add(this.uninstallButton, 1, 9);
            this.form1LayoutPanel.Controls.Add(this.scoreboardSelectorMaxmode, 2, 8);
            this.form1LayoutPanel.Controls.Add(this.installButton, 5, 9);
            this.form1LayoutPanel.Controls.Add(this.scoreboardPictureboxMaxmode, 1, 6);
            this.form1LayoutPanel.Controls.Add(this.scoreboardPictureboxMinmode, 4, 6);
            this.form1LayoutPanel.Controls.Add(this.aspectImageBox, 2, 3);
            this.form1LayoutPanel.Controls.Add(this.scoreboardMaxmodeLabel, 1, 7);
            this.form1LayoutPanel.Controls.Add(this.aspectSelector, 4, 5);
            this.form1LayoutPanel.Controls.Add(this.aspectLabel, 3, 4);
            this.form1LayoutPanel.Controls.Add(this.browseFolderInstructionsLabel, 2, 0);
            this.form1LayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.form1LayoutPanel.Controls.Add(this.downloadButton, 4, 8);
            this.form1LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form1LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.form1LayoutPanel.Name = "form1LayoutPanel";
            this.form1LayoutPanel.RowCount = 11;
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.form1LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.form1LayoutPanel.Size = new System.Drawing.Size(498, 578);
            this.form1LayoutPanel.TabIndex = 21;
            // 
            // scoreboardMinmodeLabel
            // 
            this.scoreboardMinmodeLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMinmodeLabel, 4);
            this.scoreboardMinmodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMinmodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardMinmodeLabel.Location = new System.Drawing.Point(251, 451);
            this.scoreboardMinmodeLabel.Name = "scoreboardMinmodeLabel";
            this.scoreboardMinmodeLabel.Size = new System.Drawing.Size(218, 25);
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
            this.scoreboardSelectorMinmode.Location = new System.Drawing.Point(307, 479);
            this.scoreboardSelectorMinmode.Name = "scoreboardSelectorMinmode";
            this.scoreboardSelectorMinmode.Size = new System.Drawing.Size(106, 21);
            this.scoreboardSelectorMinmode.TabIndex = 4;
            this.scoreboardSelectorMinmode.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelectorMinmode_SelectedIndexChanged);
            // 
            // scoreboardSelectorMaxmode
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardSelectorMaxmode, 2);
            this.scoreboardSelectorMaxmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardSelectorMaxmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardSelectorMaxmode.FormattingEnabled = true;
            this.scoreboardSelectorMaxmode.Location = new System.Drawing.Point(83, 479);
            this.scoreboardSelectorMaxmode.Name = "scoreboardSelectorMaxmode";
            this.scoreboardSelectorMaxmode.Size = new System.Drawing.Size(106, 21);
            this.scoreboardSelectorMaxmode.TabIndex = 3;
            this.scoreboardSelectorMaxmode.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelectorMaxmode_SelectedIndexChanged);
            // 
            // scoreboardPictureboxMaxmode
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardPictureboxMaxmode, 4);
            this.scoreboardPictureboxMaxmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardPictureboxMaxmode.Location = new System.Drawing.Point(27, 303);
            this.scoreboardPictureboxMaxmode.Name = "scoreboardPictureboxMaxmode";
            this.scoreboardPictureboxMaxmode.Size = new System.Drawing.Size(218, 145);
            this.scoreboardPictureboxMaxmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scoreboardPictureboxMaxmode.TabIndex = 19;
            this.scoreboardPictureboxMaxmode.TabStop = false;
            // 
            // scoreboardPictureboxMinmode
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardPictureboxMinmode, 4);
            this.scoreboardPictureboxMinmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardPictureboxMinmode.Location = new System.Drawing.Point(251, 303);
            this.scoreboardPictureboxMinmode.Name = "scoreboardPictureboxMinmode";
            this.scoreboardPictureboxMinmode.Size = new System.Drawing.Size(218, 145);
            this.scoreboardPictureboxMinmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scoreboardPictureboxMinmode.TabIndex = 26;
            this.scoreboardPictureboxMinmode.TabStop = false;
            // 
            // aspectImageBox
            // 
            this.form1LayoutPanel.SetColumnSpan(this.aspectImageBox, 6);
            this.aspectImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectImageBox.Location = new System.Drawing.Point(83, 83);
            this.aspectImageBox.Name = "aspectImageBox";
            this.aspectImageBox.Size = new System.Drawing.Size(330, 145);
            this.aspectImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aspectImageBox.TabIndex = 10;
            this.aspectImageBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.form1LayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 10);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Controls.Add(this.folderBrowserButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 29);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserButton.Location = new System.Drawing.Point(403, 3);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(72, 23);
            this.folderBrowserButton.TabIndex = 29;
            this.folderBrowserButton.Text = "Browse";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.folderBrowserButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.folderBrowserBoxLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(18, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 23);
            this.panel1.TabIndex = 30;
            // 
            // folderBrowserBoxLabel
            // 
            this.folderBrowserBoxLabel.BackColor = System.Drawing.Color.LightPink;
            this.folderBrowserBoxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderBrowserBoxLabel.Location = new System.Drawing.Point(0, 0);
            this.folderBrowserBoxLabel.Name = "folderBrowserBoxLabel";
            this.folderBrowserBoxLabel.Size = new System.Drawing.Size(379, 23);
            this.folderBrowserBoxLabel.TabIndex = 32;
            this.folderBrowserBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // downloadButton
            // 
            this.form1LayoutPanel.SetColumnSpan(this.downloadButton, 2);
            this.downloadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadButton.Location = new System.Drawing.Point(195, 479);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(106, 38);
            this.downloadButton.TabIndex = 31;
            this.downloadButton.Text = "Download Test";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(498, 578);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel form1LayoutPanel;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.PictureBox scoreboardPictureboxMaxmode;
        private System.Windows.Forms.PictureBox aspectImageBox;
        private System.Windows.Forms.Label scoreboardMaxmodeLabel;
        private System.Windows.Forms.ComboBox aspectSelector;
        private System.Windows.Forms.Label aspectLabel;
        private System.Windows.Forms.Label browseFolderInstructionsLabel;
        private System.Windows.Forms.ComboBox scoreboardSelectorMaxmode;
        private System.Windows.Forms.PictureBox scoreboardPictureboxMinmode;
        private System.Windows.Forms.ComboBox scoreboardSelectorMinmode;
        private System.Windows.Forms.Label scoreboardMinmodeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button downloadButton;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.Label folderBrowserBoxLabel;
    }
}

