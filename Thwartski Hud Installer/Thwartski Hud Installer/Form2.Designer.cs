namespace Thwartski_Hud_Installer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.aspectImageBox = new System.Windows.Forms.PictureBox();
            this.releaseNotesButton = new System.Windows.Forms.Button();
            this.readmeButton = new System.Windows.Forms.Button();
            this.faqButton = new System.Windows.Forms.Button();
            this.form2LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).BeginInit();
            this.form2LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aspectImageBox
            // 
            this.form2LayoutPanel.SetColumnSpan(this.aspectImageBox, 3);
            this.aspectImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectImageBox.Image = global::Thwartski_Hud_Installer.Properties.Resources.mainMenuImage;
            this.aspectImageBox.Location = new System.Drawing.Point(15, 16);
            this.aspectImageBox.Name = "aspectImageBox";
            this.aspectImageBox.Size = new System.Drawing.Size(441, 257);
            this.aspectImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aspectImageBox.TabIndex = 11;
            this.aspectImageBox.TabStop = false;
            // 
            // releaseNotesButton
            // 
            this.releaseNotesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.releaseNotesButton.Location = new System.Drawing.Point(15, 315);
            this.releaseNotesButton.Name = "releaseNotesButton";
            this.releaseNotesButton.Size = new System.Drawing.Size(143, 45);
            this.releaseNotesButton.TabIndex = 1;
            this.releaseNotesButton.Text = "Release Notes";
            this.releaseNotesButton.UseVisualStyleBackColor = true;
            this.releaseNotesButton.Click += new System.EventHandler(this.releaseNotesButton_Click);
            // 
            // readmeButton
            // 
            this.readmeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readmeButton.Location = new System.Drawing.Point(164, 315);
            this.readmeButton.Name = "readmeButton";
            this.readmeButton.Size = new System.Drawing.Size(143, 45);
            this.readmeButton.TabIndex = 2;
            this.readmeButton.Text = "Readme";
            this.readmeButton.UseVisualStyleBackColor = true;
            this.readmeButton.Click += new System.EventHandler(this.readmeButton_Click);
            // 
            // faqButton
            // 
            this.faqButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faqButton.Location = new System.Drawing.Point(313, 315);
            this.faqButton.Name = "faqButton";
            this.faqButton.Size = new System.Drawing.Size(143, 45);
            this.faqButton.TabIndex = 3;
            this.faqButton.Text = "Frequently Asked Questions";
            this.faqButton.UseVisualStyleBackColor = true;
            this.faqButton.Click += new System.EventHandler(this.faqButton_Click);
            // 
            // form2LayoutPanel
            // 
            this.form2LayoutPanel.ColumnCount = 5;
            this.form2LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.form2LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.form2LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.form2LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.form2LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.form2LayoutPanel.Controls.Add(this.aspectImageBox, 1, 1);
            this.form2LayoutPanel.Controls.Add(this.releaseNotesButton, 1, 4);
            this.form2LayoutPanel.Controls.Add(this.readmeButton, 2, 4);
            this.form2LayoutPanel.Controls.Add(this.faqButton, 3, 4);
            this.form2LayoutPanel.Controls.Add(this.okButton, 3, 6);
            this.form2LayoutPanel.Controls.Add(this.label1, 1, 3);
            this.form2LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form2LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.form2LayoutPanel.Name = "form2LayoutPanel";
            this.form2LayoutPanel.RowCount = 8;
            this.form2LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.form2LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.79984F));
            this.form2LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.092771F));
            this.form2LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.516947F));
            this.form2LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.42312F));
            this.form2LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.form2LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.167318F));
            this.form2LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.form2LayoutPanel.Size = new System.Drawing.Size(474, 406);
            this.form2LayoutPanel.TabIndex = 16;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.okButton.Location = new System.Drawing.Point(366, 370);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(90, 25);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.form2LayoutPanel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thwartski Hud has been successfully installed!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(474, 406);
            this.Controls.Add(this.form2LayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Success";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).EndInit();
            this.form2LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox aspectImageBox;
        private System.Windows.Forms.Button releaseNotesButton;
        private System.Windows.Forms.Button readmeButton;
        private System.Windows.Forms.Button faqButton;
        private System.Windows.Forms.TableLayoutPanel form2LayoutPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
    }
}