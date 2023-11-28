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
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pbSettings = new System.Windows.Forms.PictureBox();
            lblConnectionStatus = new System.Windows.Forms.Label();
            cbFilters = new System.Windows.Forms.ComboBox();
            lblActiveFilter = new System.Windows.Forms.Label();
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            lblTotalTime = new System.Windows.Forms.Label();
            tbTotalTime = new System.Windows.Forms.TextBox();
            pMain = new System.Windows.Forms.Panel();
            pBottom = new System.Windows.Forms.Panel();
            lblDivider = new System.Windows.Forms.Label();
            pbAddIssue = new System.Windows.Forms.PictureBox();
            ttMain = new System.Windows.Forms.ToolTip(components);
            pbHelp = new System.Windows.Forms.PictureBox();
            pTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pbSettings).BeginInit();
            pBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddIssue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHelp).BeginInit();
            pTop.SuspendLayout();
            SuspendLayout();
            // 
            // pbSettings
            // 
            pbSettings.BackgroundImage = Properties.Resource.settings;
            pbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            pbSettings.Location = new System.Drawing.Point(628, 8);
            pbSettings.Name = "pbSettings";
            pbSettings.Size = new System.Drawing.Size(29, 34);
            pbSettings.TabIndex = 0;
            pbSettings.TabStop = false;
            ttMain.SetToolTip(pbSettings, "Configure Jira Stopwatch");
            pbSettings.Click += pbSettings_Click;
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            lblConnectionStatus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            lblConnectionStatus.Location = new System.Drawing.Point(16, 12);
            lblConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new System.Drawing.Size(156, 32);
            lblConnectionStatus.TabIndex = 3;
            lblConnectionStatus.Text = "x";
            lblConnectionStatus.Click += lblConnectionStatus_Click;
            // 
            // cbFilters
            // 
            cbFilters.DropDownWidth = 422;
            cbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            cbFilters.FormattingEnabled = true;
            cbFilters.Location = new System.Drawing.Point(75, 8);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new System.Drawing.Size(200, 28);
            cbFilters.TabIndex = 4;
            cbFilters.DropDown += cbFilters_DropDown;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // lblActiveFilter
            // 
            lblActiveFilter.AutoSize = true;
            lblActiveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblActiveFilter.ForeColor = System.Drawing.Color.White;
            lblActiveFilter.Location = new System.Drawing.Point(16, 12);
            lblActiveFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblActiveFilter.Name = "lblActiveFilter";
            lblActiveFilter.Size = new System.Drawing.Size(47, 20);
            lblActiveFilter.TabIndex = 5;
            lblActiveFilter.Text = "Filter";
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "JIRA StopWatch";
            notifyIcon.Click += notifyIcon_Click;
            // 
            // lblTotalTime
            // 
            lblTotalTime.AutoSize = true;
            lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblTotalTime.Location = new System.Drawing.Point(284, 12);
            lblTotalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalTime.Name = "lblTotalTime";
            lblTotalTime.Size = new System.Drawing.Size(46, 20);
            lblTotalTime.TabIndex = 6;
            lblTotalTime.Text = "Total";
            lblTotalTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbTotalTime
            // 
            tbTotalTime.BackColor = System.Drawing.SystemColors.Window;
            tbTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbTotalTime.Location = new System.Drawing.Point(345, 6);
            tbTotalTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbTotalTime.Name = "tbTotalTime";
            tbTotalTime.ReadOnly = true;
            tbTotalTime.Size = new System.Drawing.Size(135, 26);
            tbTotalTime.TabIndex = 8;
            tbTotalTime.Text = "2D 45H 34M";
            tbTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pMain
            // 
            pMain.BackColor = System.Drawing.SystemColors.Window;
            pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pMain.Location = new System.Drawing.Point(0, 54);
            pMain.Margin = new System.Windows.Forms.Padding(0);
            pMain.Name = "pMain";
            pMain.Size = new System.Drawing.Size(732, 240);
            pMain.TabIndex = 9;
            // 
            // pBottom
            // 
            pBottom.Controls.Add(lblDivider);
            pBottom.Controls.Add(tbTotalTime);
            pBottom.Controls.Add(pbSettings);
            pBottom.Controls.Add(lblTotalTime);
            pBottom.Controls.Add(lblConnectionStatus);
            pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            pBottom.Location = new System.Drawing.Point(0, 294);
            pBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pBottom.Name = "pBottom";
            pBottom.Size = new System.Drawing.Size(732, 49);
            pBottom.TabIndex = 10;
            // 
            // lblDivider
            // 
            lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblDivider.Location = new System.Drawing.Point(0, 0);
            lblDivider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new System.Drawing.Size(689, 3);
            lblDivider.TabIndex = 9;
            // 
            // pbAddIssue
            // 
            pbAddIssue.BackgroundImage = Properties.Resource.add;
            pbAddIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            pbAddIssue.Location = new System.Drawing.Point(579, 8);
            pbAddIssue.Name = "pbAddIssue";
            pbAddIssue.Size = new System.Drawing.Size(32, 37);
            pbAddIssue.TabIndex = 11;
            pbAddIssue.TabStop = false;
            ttMain.SetToolTip(pbAddIssue, "Add another issue row (CTRL-N)");
            pbAddIssue.Click += pbAddIssue_Clicked;
            // 
            // pbHelp
            // 
            pbHelp.BackgroundImage = Properties.Resource.help;
            pbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            pbHelp.InitialImage = Properties.Resource.help;
            pbHelp.Location = new System.Drawing.Point(628, 8);
            pbHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pbHelp.Name = "pbHelp";
            pbHelp.Size = new System.Drawing.Size(29, 34);
            pbHelp.TabIndex = 12;
            pbHelp.TabStop = false;
            ttMain.SetToolTip(pbHelp, "Open help page in your browser");
            pbHelp.Click += pbHelp_Click;
            // 
            // pTop
            // 
            pTop.BackColor = System.Drawing.Color.SteelBlue;
            pTop.Controls.Add(pbHelp);
            pTop.Controls.Add(lblActiveFilter);
            pTop.Controls.Add(cbFilters);
            pTop.Controls.Add(pbAddIssue);
            pTop.Dock = System.Windows.Forms.DockStyle.Top;
            pTop.Location = new System.Drawing.Point(0, 0);
            pTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pTop.Name = "pTop";
            pTop.Size = new System.Drawing.Size(732, 54);
            pTop.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(732, 343);
            Controls.Add(pMain);
            Controls.Add(pTop);
            Controls.Add(pBottom);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = Properties.Resource.stopwatchicon;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "JIRA StopWatch";
            TopMost = true;
            FormClosed += MainForm_FormClosed;
            Shown += MainForm_Shown;
            Resize += MainForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pbSettings).EndInit();
            pBottom.ResumeLayout(false);
            pBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddIssue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHelp).EndInit();
            pTop.ResumeLayout(false);
            pTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label lblActiveFilter;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.TextBox tbTotalTime;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.PictureBox pbAddIssue;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.PictureBox pbHelp;
    }
}

