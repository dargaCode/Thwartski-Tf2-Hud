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
            this.label1 = new System.Windows.Forms.Label();
            this.releaseNotesButton = new System.Windows.Forms.Button();
            this.readmeButton = new System.Windows.Forms.Button();
            this.faqButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aspectImageBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.aspectImageBox, 3);
            this.aspectImageBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aspectImageBox.Image = global::Thwartski_Hud_Installer.Properties.Resources.mainMenuImage;
            this.aspectImageBox.Location = new System.Drawing.Point(28, 16);
            this.aspectImageBox.Name = "aspectImageBox";
            this.aspectImageBox.Size = new System.Drawing.Size(408, 235);
            this.aspectImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aspectImageBox.TabIndex = 11;
            this.aspectImageBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thwartski Hud is now installed!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // releaseNotesButton
            // 
            this.releaseNotesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.releaseNotesButton.Location = new System.Drawing.Point(28, 296);
            this.releaseNotesButton.Name = "releaseNotesButton";
            this.releaseNotesButton.Size = new System.Drawing.Size(132, 44);
            this.releaseNotesButton.TabIndex = 13;
            this.releaseNotesButton.Text = "Release Notes";
            this.releaseNotesButton.UseVisualStyleBackColor = true;
            this.releaseNotesButton.Click += new System.EventHandler(this.releaseNotesButton_Click);
            // 
            // readmeButton
            // 
            this.readmeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readmeButton.Location = new System.Drawing.Point(166, 296);
            this.readmeButton.Name = "readmeButton";
            this.readmeButton.Size = new System.Drawing.Size(132, 44);
            this.readmeButton.TabIndex = 14;
            this.readmeButton.Text = "Readme";
            this.readmeButton.UseVisualStyleBackColor = true;
            this.readmeButton.Click += new System.EventHandler(this.readmeButton_Click);
            // 
            // faqButton
            // 
            this.faqButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faqButton.Location = new System.Drawing.Point(304, 296);
            this.faqButton.Name = "faqButton";
            this.faqButton.Size = new System.Drawing.Size(132, 44);
            this.faqButton.TabIndex = 15;
            this.faqButton.Text = "Frequently Asked Questions";
            this.faqButton.UseVisualStyleBackColor = true;
            this.faqButton.Click += new System.EventHandler(this.faqButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.229299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.84713F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.84713F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.84713F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.229299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.aspectImageBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.releaseNotesButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.readmeButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.faqButton, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.67001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.206997F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.485F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 356);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Success!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.aspectImageBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox aspectImageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button releaseNotesButton;
        private System.Windows.Forms.Button readmeButton;
        private System.Windows.Forms.Button faqButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}