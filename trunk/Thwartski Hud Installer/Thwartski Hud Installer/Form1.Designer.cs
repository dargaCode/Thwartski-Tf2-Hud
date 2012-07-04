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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.backupCheckbox = new System.Windows.Forms.CheckBox();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aspectSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.scoreboardSelectorMinmode = new System.Windows.Forms.ComboBox();
            this.scoreboardSelectorMaxmode = new System.Windows.Forms.ComboBox();
            this.scoreboardPictureboxMaxmode = new System.Windows.Forms.PictureBox();
            this.scoreboardPictureboxMinmode = new System.Windows.Forms.PictureBox();
            this.aspectImageBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.folderBrowserLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMaxmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMinmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 518);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(541, 25);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // backupCheckbox
            // 
            this.backupCheckbox.AutoSize = true;
            this.backupCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupCheckbox.Location = new System.Drawing.Point(195, 3);
            this.backupCheckbox.Name = "backupCheckbox";
            this.backupCheckbox.Size = new System.Drawing.Size(161, 19);
            this.backupCheckbox.TabIndex = 4;
            this.backupCheckbox.Text = "Back up existing hud files";
            this.backupCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backupCheckbox.UseVisualStyleBackColor = true;
            this.backupCheckbox.CheckedChanged += new System.EventHandler(this.backupCheckbox_CheckedChanged);
            // 
            // folderBrowserButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.folderBrowserButton, 2);
            this.folderBrowserButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserButton.Location = new System.Drawing.Point(430, 43);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(85, 21);
            this.folderBrowserButton.TabIndex = 1;
            this.folderBrowserButton.Text = "Browse";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.folderBrowserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 10);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select your Team Fortress 2 folder:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 10);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.aspectSelector.Location = new System.Drawing.Point(216, 256);
            this.aspectSelector.Name = "aspectSelector";
            this.aspectSelector.Size = new System.Drawing.Size(106, 21);
            this.aspectSelector.TabIndex = 2;
            this.aspectSelector.SelectedIndexChanged += new System.EventHandler(this.aspectSelector_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Default Scoreboard";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // installButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.installButton, 3);
            this.installButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installButton.Enabled = false;
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Location = new System.Drawing.Point(272, 549);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(208, 50);
            this.installButton.TabIndex = 15;
            this.installButton.Text = "INSTALL";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // uninstallButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.uninstallButton, 3);
            this.uninstallButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uninstallButton.Enabled = false;
            this.uninstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallButton.Location = new System.Drawing.Point(58, 549);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(208, 50);
            this.uninstallButton.TabIndex = 18;
            this.uninstallButton.TabStop = false;
            this.uninstallButton.Text = "Uninstall";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.22449F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.22449F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.22449F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.22449F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.scoreboardSelectorMinmode, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.uninstallButton, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.scoreboardSelectorMaxmode, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.installButton, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.scoreboardPictureboxMaxmode, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.scoreboardPictureboxMinmode, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.aspectImageBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.aspectSelector, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.folderBrowserButton, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.216629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.929871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.35728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.419048F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.062812F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.35728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.076369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.442771F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.927299F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 614);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Minmode Scoreboard";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreboardSelectorMinmode
            // 
            this.scoreboardSelectorMinmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardSelectorMinmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardSelectorMinmode.FormattingEnabled = true;
            this.scoreboardSelectorMinmode.Location = new System.Drawing.Point(328, 472);
            this.scoreboardSelectorMinmode.Name = "scoreboardSelectorMinmode";
            this.scoreboardSelectorMinmode.Size = new System.Drawing.Size(96, 21);
            this.scoreboardSelectorMinmode.TabIndex = 27;
            this.scoreboardSelectorMinmode.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelectorMinmode_SelectedIndexChanged);
            // 
            // scoreboardSelectorMaxmode
            // 
            this.scoreboardSelectorMaxmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardSelectorMaxmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreboardSelectorMaxmode.FormattingEnabled = true;
            this.scoreboardSelectorMaxmode.Location = new System.Drawing.Point(114, 472);
            this.scoreboardSelectorMaxmode.Name = "scoreboardSelectorMaxmode";
            this.scoreboardSelectorMaxmode.Size = new System.Drawing.Size(96, 21);
            this.scoreboardSelectorMaxmode.TabIndex = 3;
            this.scoreboardSelectorMaxmode.SelectedIndexChanged += new System.EventHandler(this.scoreboardSelectorMaxmode_SelectedIndexChanged);
            // 
            // scoreboardPictureboxMaxmode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.scoreboardPictureboxMaxmode, 3);
            this.scoreboardPictureboxMaxmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardPictureboxMaxmode.Location = new System.Drawing.Point(58, 321);
            this.scoreboardPictureboxMaxmode.Name = "scoreboardPictureboxMaxmode";
            this.scoreboardPictureboxMaxmode.Size = new System.Drawing.Size(208, 145);
            this.scoreboardPictureboxMaxmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scoreboardPictureboxMaxmode.TabIndex = 19;
            this.scoreboardPictureboxMaxmode.TabStop = false;
            // 
            // scoreboardPictureboxMinmode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.scoreboardPictureboxMinmode, 3);
            this.scoreboardPictureboxMinmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreboardPictureboxMinmode.Location = new System.Drawing.Point(272, 321);
            this.scoreboardPictureboxMinmode.Name = "scoreboardPictureboxMinmode";
            this.scoreboardPictureboxMinmode.Size = new System.Drawing.Size(208, 145);
            this.scoreboardPictureboxMinmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scoreboardPictureboxMinmode.TabIndex = 26;
            this.scoreboardPictureboxMinmode.TabStop = false;
            // 
            // aspectImageBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.aspectImageBox, 4);
            this.aspectImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectImageBox.Location = new System.Drawing.Point(114, 105);
            this.aspectImageBox.Name = "aspectImageBox";
            this.aspectImageBox.Size = new System.Drawing.Size(310, 145);
            this.aspectImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aspectImageBox.TabIndex = 10;
            this.aspectImageBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 7);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.966587F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.03341F));
            this.tableLayoutPanel3.Controls.Add(this.folderBrowserLabel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(421, 29);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // folderBrowserLabel
            // 
            this.folderBrowserLabel.BackColor = System.Drawing.Color.LightPink;
            this.folderBrowserLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderBrowserLabel.Location = new System.Drawing.Point(28, 8);
            this.folderBrowserLabel.Name = "folderBrowserLabel";
            this.folderBrowserLabel.Size = new System.Drawing.Size(390, 21);
            this.folderBrowserLabel.TabIndex = 25;
            this.folderBrowserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(547, 614);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thwartski Hud Installer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_ReenabledByForm2);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMaxmode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardPictureboxMinmode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.PictureBox scoreboardPictureboxMaxmode;
        private System.Windows.Forms.PictureBox aspectImageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox aspectSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.CheckBox backupCheckbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label folderBrowserLabel;
        private System.Windows.Forms.ComboBox scoreboardSelectorMaxmode;
        private System.Windows.Forms.PictureBox scoreboardPictureboxMinmode;
        private System.Windows.Forms.ComboBox scoreboardSelectorMinmode;
        private System.Windows.Forms.Label label4;
    }
}

