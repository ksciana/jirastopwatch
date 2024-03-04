/**************************************************************************
Copyright 2016 Carsten Gehling

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
**************************************************************************/
namespace StopWatch
{
    partial class AboutForm
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
            lblNameVersion = new System.Windows.Forms.Label();
            lblLicense = new System.Windows.Forms.LinkLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblHomepage = new System.Windows.Forms.LinkLabel();
            btnClose = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNameVersion
            // 
            lblNameVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNameVersion.Location = new System.Drawing.Point(73, 34);
            lblNameVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNameVersion.Name = "lblNameVersion";
            lblNameVersion.Size = new System.Drawing.Size(289, 45);
            lblNameVersion.TabIndex = 0;
            lblNameVersion.Text = "Jira StopWatch";
            // 
            // lblLicense
            // 
            lblLicense.Location = new System.Drawing.Point(16, 248);
            lblLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new System.Drawing.Size(347, 26);
            lblLicense.TabIndex = 1;
            lblLicense.TabStop = true;
            lblLicense.Text = "Read License here";
            lblLicense.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblLicense.LinkClicked += lblLicense_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resource.timer_48;
            pictureBox1.Location = new System.Drawing.Point(11, 18);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(60, 60);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblHomepage
            // 
            lblHomepage.Location = new System.Drawing.Point(16, 294);
            lblHomepage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHomepage.Name = "lblHomepage";
            lblHomepage.Size = new System.Drawing.Size(347, 26);
            lblHomepage.TabIndex = 4;
            lblHomepage.TabStop = true;
            lblHomepage.Text = "Visit product homepage";
            lblHomepage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblHomepage.LinkClicked += lblHomepage_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.Location = new System.Drawing.Point(141, 349);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(100, 35);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.Control;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Location = new System.Drawing.Point(16, 83);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(347, 154);
            textBox1.TabIndex = 6;
            textBox1.Text = "Copyright 2015 Carsten Gehling\r\n\r\nContact me at: carsten@sarum.dk\r\n\r\nLicensed under the Apache License, Version 2.0. This software is free to use under the terms specified in the license.";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(379, 403);
            Controls.Add(textBox1);
            Controls.Add(btnClose);
            Controls.Add(lblHomepage);
            Controls.Add(pictureBox1);
            Controls.Add(lblLicense);
            Controls.Add(lblNameVersion);
            Icon = Properties.Resource.stopwatchicon;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "AboutForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "About Jira StopWatch";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNameVersion;
        private System.Windows.Forms.LinkLabel lblLicense;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblHomepage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBox1;
    }
}
