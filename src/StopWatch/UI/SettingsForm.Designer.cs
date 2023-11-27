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
    partial class SettingsForm
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
            lblJiraBaseUrl = new System.Windows.Forms.Label();
            tbJiraBaseUrl = new System.Windows.Forms.TextBox();
            cbAlwaysOnTop = new System.Windows.Forms.CheckBox();
            btnOk = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblSaveTimerState = new System.Windows.Forms.Label();
            btnAbout = new System.Windows.Forms.Button();
            cbMinimizeToTray = new System.Windows.Forms.CheckBox();
            cbSaveTimerState = new System.Windows.Forms.ComboBox();
            lblPauseOnSessionLock = new System.Windows.Forms.Label();
            cbPauseOnSessionLock = new System.Windows.Forms.ComboBox();
            splitter3 = new System.Windows.Forms.Label();
            splitter2 = new System.Windows.Forms.Label();
            splitter1 = new System.Windows.Forms.Label();
            cbAllowMultipleTimers = new System.Windows.Forms.CheckBox();
            cbPostWorklogComment = new System.Windows.Forms.ComboBox();
            lblPostWorklogComment = new System.Windows.Forms.Label();
            lblDisplayOptions = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblStartTransitions = new System.Windows.Forms.Label();
            tbStartTransitions = new System.Windows.Forms.TextBox();
            cbLoggingEnabbled = new System.Windows.Forms.CheckBox();
            lblOpenLogFolder = new System.Windows.Forms.LinkLabel();
            cbCheckForUpdate = new System.Windows.Forms.CheckBox();
            tbApiToken = new System.Windows.Forms.TextBox();
            lblApiToken = new System.Windows.Forms.Label();
            tbUsername = new System.Windows.Forms.TextBox();
            lblUsername = new System.Windows.Forms.Label();
            cbIncludeProjectName = new System.Windows.Forms.CheckBox();
            lblOpenAPITokensPage = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // lblJiraBaseUrl
            // 
            lblJiraBaseUrl.AutoSize = true;
            lblJiraBaseUrl.Location = new System.Drawing.Point(12, 11);
            lblJiraBaseUrl.Name = "lblJiraBaseUrl";
            lblJiraBaseUrl.Size = new System.Drawing.Size(93, 20);
            lblJiraBaseUrl.TabIndex = 0;
            lblJiraBaseUrl.Text = "JIRA base url";
            // 
            // tbJiraBaseUrl
            // 
            tbJiraBaseUrl.Location = new System.Drawing.Point(163, 8);
            tbJiraBaseUrl.Name = "tbJiraBaseUrl";
            tbJiraBaseUrl.Size = new System.Drawing.Size(344, 27);
            tbJiraBaseUrl.TabIndex = 1;
            // 
            // cbAlwaysOnTop
            // 
            cbAlwaysOnTop.AutoSize = true;
            cbAlwaysOnTop.Location = new System.Drawing.Point(163, 192);
            cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            cbAlwaysOnTop.Size = new System.Drawing.Size(217, 24);
            cbAlwaysOnTop.TabIndex = 10;
            cbAlwaysOnTop.Text = "Always keep window on top";
            cbAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnOk.Location = new System.Drawing.Point(351, 714);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(75, 34);
            btnOk.TabIndex = 27;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(432, 714);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 34);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSaveTimerState
            // 
            lblSaveTimerState.Location = new System.Drawing.Point(12, 349);
            lblSaveTimerState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSaveTimerState.Name = "lblSaveTimerState";
            lblSaveTimerState.Size = new System.Drawing.Size(131, 58);
            lblSaveTimerState.TabIndex = 14;
            lblSaveTimerState.Text = "Save timer states on program exit";
            // 
            // btnAbout
            // 
            btnAbout.Location = new System.Drawing.Point(15, 714);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new System.Drawing.Size(75, 34);
            btnAbout.TabIndex = 26;
            btnAbout.Text = "About...";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // cbMinimizeToTray
            // 
            cbMinimizeToTray.AutoSize = true;
            cbMinimizeToTray.Location = new System.Drawing.Point(163, 225);
            cbMinimizeToTray.Name = "cbMinimizeToTray";
            cbMinimizeToTray.Size = new System.Drawing.Size(139, 24);
            cbMinimizeToTray.TabIndex = 11;
            cbMinimizeToTray.Text = "Minimize to tray";
            cbMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // cbSaveTimerState
            // 
            cbSaveTimerState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbSaveTimerState.FormattingEnabled = true;
            cbSaveTimerState.Location = new System.Drawing.Point(163, 352);
            cbSaveTimerState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbSaveTimerState.Name = "cbSaveTimerState";
            cbSaveTimerState.Size = new System.Drawing.Size(343, 28);
            cbSaveTimerState.TabIndex = 15;
            // 
            // lblPauseOnSessionLock
            // 
            lblPauseOnSessionLock.Location = new System.Drawing.Point(12, 408);
            lblPauseOnSessionLock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPauseOnSessionLock.Name = "lblPauseOnSessionLock";
            lblPauseOnSessionLock.Size = new System.Drawing.Size(131, 58);
            lblPauseOnSessionLock.TabIndex = 16;
            lblPauseOnSessionLock.Text = "Pause timer on session lock";
            // 
            // cbPauseOnSessionLock
            // 
            cbPauseOnSessionLock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbPauseOnSessionLock.FormattingEnabled = true;
            cbPauseOnSessionLock.Location = new System.Drawing.Point(163, 411);
            cbPauseOnSessionLock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbPauseOnSessionLock.Name = "cbPauseOnSessionLock";
            cbPauseOnSessionLock.Size = new System.Drawing.Size(233, 28);
            cbPauseOnSessionLock.TabIndex = 17;
            // 
            // splitter3
            // 
            splitter3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            splitter3.Location = new System.Drawing.Point(16, 697);
            splitter3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            splitter3.Name = "splitter3";
            splitter3.Size = new System.Drawing.Size(493, 3);
            splitter3.TabIndex = 25;
            // 
            // splitter2
            // 
            splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            splitter2.Location = new System.Drawing.Point(16, 331);
            splitter2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new System.Drawing.Size(493, 3);
            splitter2.TabIndex = 13;
            // 
            // splitter1
            // 
            splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            splitter1.Location = new System.Drawing.Point(16, 178);
            splitter1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(493, 3);
            splitter1.TabIndex = 8;
            // 
            // cbAllowMultipleTimers
            // 
            cbAllowMultipleTimers.AutoSize = true;
            cbAllowMultipleTimers.Location = new System.Drawing.Point(163, 469);
            cbAllowMultipleTimers.Name = "cbAllowMultipleTimers";
            cbAllowMultipleTimers.Size = new System.Drawing.Size(329, 24);
            cbAllowMultipleTimers.TabIndex = 18;
            cbAllowMultipleTimers.Text = "Allow running multiple timers simultaneously";
            cbAllowMultipleTimers.UseVisualStyleBackColor = true;
            // 
            // cbPostWorklogComment
            // 
            cbPostWorklogComment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbPostWorklogComment.FormattingEnabled = true;
            cbPostWorklogComment.Location = new System.Drawing.Point(163, 514);
            cbPostWorklogComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbPostWorklogComment.Name = "cbPostWorklogComment";
            cbPostWorklogComment.Size = new System.Drawing.Size(263, 28);
            cbPostWorklogComment.TabIndex = 20;
            // 
            // lblPostWorklogComment
            // 
            lblPostWorklogComment.Location = new System.Drawing.Point(12, 511);
            lblPostWorklogComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPostWorklogComment.Name = "lblPostWorklogComment";
            lblPostWorklogComment.Size = new System.Drawing.Size(131, 58);
            lblPostWorklogComment.TabIndex = 19;
            lblPostWorklogComment.Text = "How to post the worklog comment";
            // 
            // lblDisplayOptions
            // 
            lblDisplayOptions.Location = new System.Drawing.Point(12, 195);
            lblDisplayOptions.Name = "lblDisplayOptions";
            lblDisplayOptions.Size = new System.Drawing.Size(143, 52);
            lblDisplayOptions.TabIndex = 9;
            lblDisplayOptions.Text = "General options";
            // 
            // label1
            // 
            label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label1.Location = new System.Drawing.Point(15, 572);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(493, 3);
            label1.TabIndex = 22;
            // 
            // lblStartTransitions
            // 
            lblStartTransitions.Location = new System.Drawing.Point(12, 594);
            lblStartTransitions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStartTransitions.Name = "lblStartTransitions";
            lblStartTransitions.Size = new System.Drawing.Size(143, 80);
            lblStartTransitions.TabIndex = 23;
            lblStartTransitions.Text = "Possible state changes when pressing play (seperate by newline)";
            // 
            // tbStartTransitions
            // 
            tbStartTransitions.AcceptsReturn = true;
            tbStartTransitions.Location = new System.Drawing.Point(163, 594);
            tbStartTransitions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbStartTransitions.Multiline = true;
            tbStartTransitions.Name = "tbStartTransitions";
            tbStartTransitions.Size = new System.Drawing.Size(265, 78);
            tbStartTransitions.TabIndex = 24;
            // 
            // cbLoggingEnabbled
            // 
            cbLoggingEnabbled.AutoSize = true;
            cbLoggingEnabbled.Location = new System.Drawing.Point(163, 137);
            cbLoggingEnabbled.Name = "cbLoggingEnabbled";
            cbLoggingEnabbled.Size = new System.Drawing.Size(183, 24);
            cbLoggingEnabbled.TabIndex = 6;
            cbLoggingEnabbled.Text = "Enable debug logging ";
            cbLoggingEnabbled.UseVisualStyleBackColor = true;
            // 
            // lblOpenLogFolder
            // 
            lblOpenLogFolder.AutoSize = true;
            lblOpenLogFolder.Location = new System.Drawing.Point(352, 138);
            lblOpenLogFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOpenLogFolder.Name = "lblOpenLogFolder";
            lblOpenLogFolder.Size = new System.Drawing.Size(115, 20);
            lblOpenLogFolder.TabIndex = 7;
            lblOpenLogFolder.TabStop = true;
            lblOpenLogFolder.Text = "Open log folder";
            lblOpenLogFolder.LinkClicked += lblOpenLogFolder_LinkClicked;
            // 
            // cbCheckForUpdate
            // 
            cbCheckForUpdate.AutoSize = true;
            cbCheckForUpdate.Location = new System.Drawing.Point(163, 257);
            cbCheckForUpdate.Name = "cbCheckForUpdate";
            cbCheckForUpdate.Size = new System.Drawing.Size(283, 24);
            cbCheckForUpdate.TabIndex = 12;
            cbCheckForUpdate.Text = "Check for updates on application start";
            cbCheckForUpdate.UseVisualStyleBackColor = true;
            // 
            // tbApiToken
            // 
            tbApiToken.Location = new System.Drawing.Point(163, 86);
            tbApiToken.Name = "tbApiToken";
            tbApiToken.PasswordChar = '*';
            tbApiToken.Size = new System.Drawing.Size(171, 27);
            tbApiToken.TabIndex = 5;
            // 
            // lblApiToken
            // 
            lblApiToken.AutoSize = true;
            lblApiToken.Location = new System.Drawing.Point(12, 91);
            lblApiToken.Name = "lblApiToken";
            lblApiToken.Size = new System.Drawing.Size(70, 20);
            lblApiToken.TabIndex = 4;
            lblApiToken.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new System.Drawing.Point(163, 48);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new System.Drawing.Size(171, 27);
            tbUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(12, 52);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(75, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // cbIncludeProjectName
            // 
            cbIncludeProjectName.AutoSize = true;
            cbIncludeProjectName.Location = new System.Drawing.Point(163, 289);
            cbIncludeProjectName.Name = "cbIncludeProjectName";
            cbIncludeProjectName.Size = new System.Drawing.Size(287, 24);
            cbIncludeProjectName.TabIndex = 13;
            cbIncludeProjectName.Text = "Include project name in issue summary";
            cbIncludeProjectName.UseVisualStyleBackColor = true;
            // 
            // lblOpenAPITokensPage
            // 
            lblOpenAPITokensPage.AutoSize = true;
            lblOpenAPITokensPage.Location = new System.Drawing.Point(343, 95);
            lblOpenAPITokensPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOpenAPITokensPage.Name = "lblOpenAPITokensPage";
            lblOpenAPITokensPage.Size = new System.Drawing.Size(121, 20);
            lblOpenAPITokensPage.TabIndex = 6;
            lblOpenAPITokensPage.TabStop = true;
            lblOpenAPITokensPage.Text = "Get an API Token";
            lblOpenAPITokensPage.LinkClicked += lblOpenAPITokensPage_LinkClicked;
            // 
            // SettingsForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(521, 760);
            Controls.Add(lblOpenAPITokensPage);
            Controls.Add(cbIncludeProjectName);
            Controls.Add(tbApiToken);
            Controls.Add(lblApiToken);
            Controls.Add(tbUsername);
            Controls.Add(lblUsername);
            Controls.Add(cbCheckForUpdate);
            Controls.Add(lblOpenLogFolder);
            Controls.Add(cbLoggingEnabbled);
            Controls.Add(tbStartTransitions);
            Controls.Add(lblStartTransitions);
            Controls.Add(label1);
            Controls.Add(cbPostWorklogComment);
            Controls.Add(lblPostWorklogComment);
            Controls.Add(cbAllowMultipleTimers);
            Controls.Add(cbPauseOnSessionLock);
            Controls.Add(splitter3);
            Controls.Add(cbSaveTimerState);
            Controls.Add(splitter2);
            Controls.Add(splitter1);
            Controls.Add(lblPauseOnSessionLock);
            Controls.Add(cbMinimizeToTray);
            Controls.Add(btnAbout);
            Controls.Add(lblSaveTimerState);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(cbAlwaysOnTop);
            Controls.Add(lblDisplayOptions);
            Controls.Add(tbJiraBaseUrl);
            Controls.Add(lblJiraBaseUrl);
            Icon = Properties.Resources.stopwatchicon;
            Name = "SettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "StopWatch Settings";
            FormClosed += SettingsForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJiraBaseUrl;
        private System.Windows.Forms.TextBox tbJiraBaseUrl;
        private System.Windows.Forms.CheckBox cbAlwaysOnTop;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSaveTimerState;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.CheckBox cbMinimizeToTray;
        private System.Windows.Forms.ComboBox cbSaveTimerState;
        private System.Windows.Forms.ComboBox cbPauseOnSessionLock;
        private System.Windows.Forms.Label lblPauseOnSessionLock;
        private System.Windows.Forms.Label splitter3;
        private System.Windows.Forms.Label splitter2;
        private System.Windows.Forms.Label splitter1;
        private System.Windows.Forms.CheckBox cbAllowMultipleTimers;
        private System.Windows.Forms.ComboBox cbPostWorklogComment;
        private System.Windows.Forms.Label lblPostWorklogComment;
        private System.Windows.Forms.Label lblDisplayOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStartTransitions;
        private System.Windows.Forms.TextBox tbStartTransitions;
        private System.Windows.Forms.CheckBox cbLoggingEnabbled;
        private System.Windows.Forms.LinkLabel lblOpenLogFolder;
        private System.Windows.Forms.CheckBox cbCheckForUpdate;
        private System.Windows.Forms.TextBox tbApiToken;
        private System.Windows.Forms.Label lblApiToken;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox cbIncludeProjectName;
        private System.Windows.Forms.LinkLabel lblOpenAPITokensPage;
    }
}
