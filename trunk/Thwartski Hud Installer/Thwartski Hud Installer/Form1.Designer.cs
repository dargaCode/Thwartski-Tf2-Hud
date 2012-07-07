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
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserBoxLabel = new System.Windows.Forms.Label();
            this.form1LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMaxmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMinmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // folderBrowserButton
            // 
            this.form1LayoutPanel.SetColumnSpan(this.folderBrowserButton, 2);
            this.folderBrowserButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserButton.Location = new System.Drawing.Point(443, 39);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(76, 21);
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
            this.browseFolderInstructionsLabel.Location = new System.Drawing.Point(101, 13);
            this.browseFolderInstructionsLabel.Name = "browseFolderInstructionsLabel";
            this.browseFolderInstructionsLabel.Size = new System.Drawing.Size(336, 15);
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
            this.aspectLabel.Location = new System.Drawing.Point(158, 231);
            this.aspectLabel.Name = "aspectLabel";
            this.aspectLabel.Size = new System.Drawing.Size(222, 25);
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
            this.aspectSelector.Location = new System.Drawing.Point(215, 259);
            this.aspectSelector.Name = "aspectSelector";
            this.aspectSelector.Size = new System.Drawing.Size(108, 21);
            this.aspectSelector.TabIndex = 2;
            this.aspectSelector.SelectedIndexChanged += new System.EventHandler(this.aspectSelector_SelectedIndexChanged);
            // 
            // scoreboardMaxmodeLabel
            // 
            this.scoreboardMaxmodeLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMaxmodeLabel, 4);
            this.scoreboardMaxmodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMaxmodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardMaxmodeLabel.Location = new System.Drawing.Point(44, 451);
            this.scoreboardMaxmodeLabel.Name = "scoreboardMaxmodeLabel";
            this.scoreboardMaxmodeLabel.Size = new System.Drawing.Size(222, 25);
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
            this.installButton.Location = new System.Drawing.Point(272, 523);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(222, 42);
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
            this.uninstallButton.Location = new System.Drawing.Point(44, 523);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(222, 42);
            this.uninstallButton.TabIndex = 5;
            this.uninstallButton.Text = "Uninstall Hud";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // form1LayoutPanel
            // 
            this.form1LayoutPanel.ColumnCount = 12;
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.form1LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
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
            this.form1LayoutPanel.Controls.Add(this.panel1, 1, 1);
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
            this.form1LayoutPanel.Size = new System.Drawing.Size(538, 578);
            this.form1LayoutPanel.TabIndex = 21;
            // 
            // scoreboardMinmodeLabel
            // 
            this.scoreboardMinmodeLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMinmodeLabel, 4);
            this.scoreboardMinmodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMinmodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardMinmodeLabel.Location = new System.Drawing.Point(272, 451);
            this.scoreboardMinmodeLabel.Name = "scoreboardMinmodeLabel";
            this.scoreboardMinmodeLabel.Size = new System.Drawing.Size(222, 25);
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
            this.scoreboardSelectorMinmode.Location = new System.Drawing.Point(329, 479);
            this.scoreboardSelectorMinmode.Name = "scoreboardSelectorMinmode";
            this.scoreboardSelectorMinmode.Size = new System.Drawing.Size(108, 21);
            this.scoreboardSelectorMinmode.TabIndex = 4;
            this.scoreboardSelectorMinmode.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelectorMinmode_SelectedIndexChanged);
            // 
            // scoreboardSelectorMaxmode
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardSelectorMaxmode, 2);
            this.scoreboardSelectorMaxmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardSelectorMaxmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardSelectorMaxmode.FormattingEnabled = true;
            this.scoreboardSelectorMaxmode.Location = new System.Drawing.Point(101, 479);
            this.scoreboardSelectorMaxmode.Name = "scoreboardSelectorMaxmode";
            this.scoreboardSelectorMaxmode.Size = new System.Drawing.Size(108, 21);
            this.scoreboardSelectorMaxmode.TabIndex = 3;
            this.scoreboardSelectorMaxmode.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelectorMaxmode_SelectedIndexChanged);
            // 
            // scoreboardPictureboxMaxmode
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardPictureboxMaxmode, 4);
            this.scoreboardPictureboxMaxmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardPictureboxMaxmode.Location = new System.Drawing.Point(44, 303);
            this.scoreboardPictureboxMaxmode.Name = "scoreboardPictureboxMaxmode";
            this.scoreboardPictureboxMaxmode.Size = new System.Drawing.Size(222, 145);
            this.scoreboardPictureboxMaxmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scoreboardPictureboxMaxmode.TabIndex = 19;
            this.scoreboardPictureboxMaxmode.TabStop = false;
            // 
            // scoreboardPictureboxMinmode
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardPictureboxMinmode, 4);
            this.scoreboardPictureboxMinmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardPictureboxMinmode.Location = new System.Drawing.Point(272, 303);
            this.scoreboardPictureboxMinmode.Name = "scoreboardPictureboxMinmode";
            this.scoreboardPictureboxMinmode.Size = new System.Drawing.Size(222, 145);
            this.scoreboardPictureboxMinmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scoreboardPictureboxMinmode.TabIndex = 26;
            this.scoreboardPictureboxMinmode.TabStop = false;
            // 
            // aspectImageBox
            // 
            this.form1LayoutPanel.SetColumnSpan(this.aspectImageBox, 6);
            this.aspectImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectImageBox.Location = new System.Drawing.Point(101, 83);
            this.aspectImageBox.Name = "aspectImageBox";
            this.aspectImageBox.Size = new System.Drawing.Size(336, 145);
            this.aspectImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aspectImageBox.TabIndex = 10;
            this.aspectImageBox.TabStop = false;
            // 
            // panel1
            // 
            this.form1LayoutPanel.SetColumnSpan(this.panel1, 8);
            this.panel1.Controls.Add(this.folderBrowserBoxLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(19, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 29);
            this.panel1.TabIndex = 29;
            // 
            // folderBrowserBoxLabel
            // 
            this.folderBrowserBoxLabel.BackColor = System.Drawing.Color.LightPink;
            this.folderBrowserBoxLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserBoxLabel.Location = new System.Drawing.Point(0, 9);
            this.folderBrowserBoxLabel.Name = "folderBrowserBoxLabel";
            this.folderBrowserBoxLabel.Size = new System.Drawing.Size(418, 20);
            this.folderBrowserBoxLabel.TabIndex = 26;
            this.folderBrowserBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(538, 578);
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
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
        private System.Windows.Forms.ComboBox scoreboardSelectorMaxmode;
        private System.Windows.Forms.PictureBox scoreboardPictureboxMinmode;
        private System.Windows.Forms.ComboBox scoreboardSelectorMinmode;
        private System.Windows.Forms.Label scoreboardMinmodeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label folderBrowserBoxLabel;
    }
}

