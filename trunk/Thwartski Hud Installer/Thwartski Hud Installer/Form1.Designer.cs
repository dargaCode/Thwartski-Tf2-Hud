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
            this.InstallBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.InstallBrowserInstructLabel = new System.Windows.Forms.Label();
            this.aspectLabel = new System.Windows.Forms.Label();
            this.aspectCombobox = new System.Windows.Forms.ComboBox();
            this.scoreboardMinmodeLabel = new System.Windows.Forms.Label();
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.form1LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.scoreboardMaxmodeLabel = new System.Windows.Forms.Label();
            this.scoreboardMaxmodeCombobox = new System.Windows.Forms.ComboBox();
            this.scoreboardMinmodeCombobox = new System.Windows.Forms.ComboBox();
            this.scoreboardMinmodePicturebox = new System.Windows.Forms.PictureBox();
            this.scoreboardMaxmodePicturebox = new System.Windows.Forms.PictureBox();
            this.aspectPicturebox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InstallBrowserButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InstallBrowserPathLabel = new System.Windows.Forms.Label();
            this.form1LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardMinmodePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardMaxmodePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspectPicturebox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstallBrowserDialog
            // 
            this.InstallBrowserDialog.ShowNewFolderButton = false;
            // 
            // InstallBrowserInstructLabel
            // 
            this.InstallBrowserInstructLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.InstallBrowserInstructLabel, 6);
            this.InstallBrowserInstructLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InstallBrowserInstructLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallBrowserInstructLabel.Location = new System.Drawing.Point(83, 13);
            this.InstallBrowserInstructLabel.Name = "InstallBrowserInstructLabel";
            this.InstallBrowserInstructLabel.Size = new System.Drawing.Size(330, 15);
            this.InstallBrowserInstructLabel.TabIndex = 3;
            this.InstallBrowserInstructLabel.Text = "Please select your Team Fortress 2 folder:";
            this.InstallBrowserInstructLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // aspectCombobox
            // 
            this.aspectCombobox.BackColor = System.Drawing.SystemColors.Window;
            this.form1LayoutPanel.SetColumnSpan(this.aspectCombobox, 2);
            this.aspectCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aspectCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspectCombobox.FormattingEnabled = true;
            this.aspectCombobox.Location = new System.Drawing.Point(195, 259);
            this.aspectCombobox.Name = "aspectCombobox";
            this.aspectCombobox.Size = new System.Drawing.Size(106, 21);
            this.aspectCombobox.TabIndex = 2;
            this.aspectCombobox.SelectedIndexChanged += new System.EventHandler(this.aspectCombobox_SelectedIndexChanged);
            // 
            // scoreboardMinmodeLabel
            // 
            this.scoreboardMinmodeLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMinmodeLabel, 4);
            this.scoreboardMinmodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMinmodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardMinmodeLabel.Location = new System.Drawing.Point(27, 451);
            this.scoreboardMinmodeLabel.Name = "scoreboardMinmodeLabel";
            this.scoreboardMinmodeLabel.Size = new System.Drawing.Size(218, 25);
            this.scoreboardMinmodeLabel.TabIndex = 12;
            this.scoreboardMinmodeLabel.Text = "Competitive Scoreboard:";
            this.scoreboardMinmodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.form1LayoutPanel.Controls.Add(this.scoreboardMaxmodeLabel, 5, 7);
            this.form1LayoutPanel.Controls.Add(this.scoreboardMaxmodeCombobox, 6, 8);
            this.form1LayoutPanel.Controls.Add(this.uninstallButton, 1, 9);
            this.form1LayoutPanel.Controls.Add(this.scoreboardMinmodeCombobox, 2, 8);
            this.form1LayoutPanel.Controls.Add(this.installButton, 5, 9);
            this.form1LayoutPanel.Controls.Add(this.scoreboardMinmodePicturebox, 1, 6);
            this.form1LayoutPanel.Controls.Add(this.scoreboardMaxmodePicturebox, 4, 6);
            this.form1LayoutPanel.Controls.Add(this.aspectPicturebox, 2, 3);
            this.form1LayoutPanel.Controls.Add(this.scoreboardMinmodeLabel, 1, 7);
            this.form1LayoutPanel.Controls.Add(this.aspectCombobox, 4, 5);
            this.form1LayoutPanel.Controls.Add(this.aspectLabel, 3, 4);
            this.form1LayoutPanel.Controls.Add(this.InstallBrowserInstructLabel, 2, 0);
            this.form1LayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
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
            // scoreboardMaxmodeLabel
            // 
            this.scoreboardMaxmodeLabel.AutoSize = true;
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMaxmodeLabel, 4);
            this.scoreboardMaxmodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMaxmodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardMaxmodeLabel.Location = new System.Drawing.Point(251, 451);
            this.scoreboardMaxmodeLabel.Name = "scoreboardMaxmodeLabel";
            this.scoreboardMaxmodeLabel.Size = new System.Drawing.Size(218, 25);
            this.scoreboardMaxmodeLabel.TabIndex = 28;
            this.scoreboardMaxmodeLabel.Text = "Pub Server Scoreboard:";
            this.scoreboardMaxmodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreboardMaxmodeCombobox
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMaxmodeCombobox, 2);
            this.scoreboardMaxmodeCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMaxmodeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardMaxmodeCombobox.FormattingEnabled = true;
            this.scoreboardMaxmodeCombobox.Location = new System.Drawing.Point(307, 479);
            this.scoreboardMaxmodeCombobox.Name = "scoreboardMaxmodeCombobox";
            this.scoreboardMaxmodeCombobox.Size = new System.Drawing.Size(106, 21);
            this.scoreboardMaxmodeCombobox.TabIndex = 4;
            this.scoreboardMaxmodeCombobox.SelectedIndexChanged += new System.EventHandler(this.scoreboardMaxmodeCombobox_SelectedIndexChanged);
            // 
            // scoreboardMinmodeCombobox
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMinmodeCombobox, 2);
            this.scoreboardMinmodeCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMinmodeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardMinmodeCombobox.FormattingEnabled = true;
            this.scoreboardMinmodeCombobox.Location = new System.Drawing.Point(83, 479);
            this.scoreboardMinmodeCombobox.Name = "scoreboardMinmodeCombobox";
            this.scoreboardMinmodeCombobox.Size = new System.Drawing.Size(106, 21);
            this.scoreboardMinmodeCombobox.TabIndex = 3;
            this.scoreboardMinmodeCombobox.SelectedIndexChanged += new System.EventHandler(this.scoreboardMinmodeCombobox_SelectedIndexChanged);
            // 
            // scoreboardMinmodePicturebox
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMinmodePicturebox, 4);
            this.scoreboardMinmodePicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMinmodePicturebox.Location = new System.Drawing.Point(27, 303);
            this.scoreboardMinmodePicturebox.Name = "scoreboardMinmodePicturebox";
            this.scoreboardMinmodePicturebox.Size = new System.Drawing.Size(218, 145);
            this.scoreboardMinmodePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scoreboardMinmodePicturebox.TabIndex = 19;
            this.scoreboardMinmodePicturebox.TabStop = false;
            // 
            // scoreboardMaxmodePicturebox
            // 
            this.form1LayoutPanel.SetColumnSpan(this.scoreboardMaxmodePicturebox, 4);
            this.scoreboardMaxmodePicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardMaxmodePicturebox.Location = new System.Drawing.Point(251, 303);
            this.scoreboardMaxmodePicturebox.Name = "scoreboardMaxmodePicturebox";
            this.scoreboardMaxmodePicturebox.Size = new System.Drawing.Size(218, 145);
            this.scoreboardMaxmodePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scoreboardMaxmodePicturebox.TabIndex = 26;
            this.scoreboardMaxmodePicturebox.TabStop = false;
            // 
            // aspectPicturebox
            // 
            this.form1LayoutPanel.SetColumnSpan(this.aspectPicturebox, 6);
            this.aspectPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectPicturebox.Location = new System.Drawing.Point(83, 83);
            this.aspectPicturebox.Name = "aspectPicturebox";
            this.aspectPicturebox.Size = new System.Drawing.Size(330, 145);
            this.aspectPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aspectPicturebox.TabIndex = 10;
            this.aspectPicturebox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.form1LayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 10);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Controls.Add(this.InstallBrowserButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 29);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // InstallBrowserButton
            // 
            this.InstallBrowserButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InstallBrowserButton.Location = new System.Drawing.Point(403, 3);
            this.InstallBrowserButton.Name = "InstallBrowserButton";
            this.InstallBrowserButton.Size = new System.Drawing.Size(72, 23);
            this.InstallBrowserButton.TabIndex = 29;
            this.InstallBrowserButton.Text = "Browse";
            this.InstallBrowserButton.UseVisualStyleBackColor = true;
            this.InstallBrowserButton.Click += new System.EventHandler(this.InstallBrowserButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InstallBrowserPathLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(18, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 23);
            this.panel1.TabIndex = 30;
            // 
            // InstallBrowserPathLabel
            // 
            this.InstallBrowserPathLabel.BackColor = System.Drawing.Color.LightPink;
            this.InstallBrowserPathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstallBrowserPathLabel.Location = new System.Drawing.Point(0, 0);
            this.InstallBrowserPathLabel.Name = "InstallBrowserPathLabel";
            this.InstallBrowserPathLabel.Size = new System.Drawing.Size(379, 23);
            this.InstallBrowserPathLabel.TabIndex = 32;
            this.InstallBrowserPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardMinmodePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardMaxmodePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspectPicturebox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel form1LayoutPanel;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.PictureBox scoreboardMinmodePicturebox;
        private System.Windows.Forms.PictureBox aspectPicturebox;
        private System.Windows.Forms.Label scoreboardMinmodeLabel;
        private System.Windows.Forms.Label aspectLabel;
        private System.Windows.Forms.Label InstallBrowserInstructLabel;
        private System.Windows.Forms.PictureBox scoreboardMaxmodePicturebox;
        private System.Windows.Forms.Label scoreboardMaxmodeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button InstallBrowserButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FolderBrowserDialog InstallBrowserDialog;
        public System.Windows.Forms.Label InstallBrowserPathLabel;
        public System.Windows.Forms.ComboBox aspectCombobox;
        public System.Windows.Forms.ComboBox scoreboardMinmodeCombobox;
        public System.Windows.Forms.ComboBox scoreboardMaxmodeCombobox;
    }
}

