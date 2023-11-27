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
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    internal class IssueControl : UserControl
    {
        #region public members
        public string IssueKey
        {
            get
            {
                return cbJira.Text;
            }

            set
            {
                cbJira.Text = value;
                UpdateSummary();
            }
        }


        public WatchTimer WatchTimer { get; private set; }

        public bool MarkedForRemoval
        {
            get
            {
                return _MarkedForRemoval;
            }
        }

        public IEnumerable<Issue> AvailableIssues
        {
            set
            {
                cbJira.Items.Clear();
                foreach (var issue in value)
                    cbJira.Items.Add(new CBIssueItem(issue.Key, issue.Fields.Summary));
            }
        }


        public string Comment { get; set; }
        public EstimateUpdateMethods EstimateUpdateMethod { get; set; }
        public string EstimateUpdateValue { get; set; }

        public bool Current
        {
            get
            {
                return Current;
            }
            set
            {
                BackColor = value ? SystemColors.GradientInactiveCaption : SystemColors.Window;
            }
        }

        public event EventHandler RemoveMeTriggered;

        public event EventHandler Selected;

        public event EventHandler TimeEdited;
        #endregion


        #region public events
        public event EventHandler TimerStarted;

        public event EventHandler TimerReset;
        #endregion


        #region public methods
        public IssueControl(JiraClient jiraClient, Settings settings)
            : base()
        {
            InitializeComponent();

            cbJiraTbEvents = new ComboTextBoxEvents(cbJira);
            cbJiraTbEvents.Paste += cbJiraTbEvents_Paste;
            cbJiraTbEvents.MouseDown += CbJiraTbEvents_MouseDown;

            Comment = null;
            EstimateUpdateMethod = EstimateUpdateMethods.Auto;
            EstimateUpdateValue = null;

            this.settings = settings;

            this.jiraClient = jiraClient;
            this.WatchTimer = new WatchTimer();
        }

        private void CbJiraTbEvents_MouseDown(object sender, EventArgs e)
        {
            SetSelected();
        }

        public void ToggleRemoveIssueButton(bool Enable)
        {
            this.btnRemoveIssue.Enabled = Enable;
        }

        public bool focusJiraField()
        {
            return this.cbJira.Focus();
        }

        public void UpdateOutput(bool updateSummary = false)
        {
            tbTime.Text = JiraTimeHelpers.TimeSpanToJiraTime(WatchTimer.TimeElapsed);

            if (WatchTimer.Running)
            {
                btnStartStop.Image = (System.Drawing.Image)(Properties.Resources.pause26);
                tbTime.BackColor = Color.PaleGreen;
            }
            else {
                btnStartStop.Image = (System.Drawing.Image)(Properties.Resources.play26);
                tbTime.BackColor = SystemColors.Control;
            }

            if (string.IsNullOrEmpty(Comment))
                btnPostAndReset.Image = (System.Drawing.Image)Properties.Resources.posttime26;
            else
                btnPostAndReset.Image = (System.Drawing.Image)Properties.Resources.posttimenote26;

            btnOpen.Enabled = cbJira.Text.Trim() != "";
            btnReset.Enabled = WatchTimer.Running || WatchTimer.TimeElapsed.Ticks > 0;
            btnPostAndReset.Enabled = WatchTimer.TimeElapsedNearestMinute.TotalMinutes >= 1;

            if (updateSummary)
                UpdateSummary();
        }


        public void Start()
        {
            WatchTimer.Start();
            UpdateOutput();
        }


        public void Pause()
        {
            WatchTimer.Pause();
            UpdateOutput();
        }

        public void FocusKey()
        {
            cbJira.Focus();
        }
        #endregion


        #region private methods
        public void OpenJira()
        {
            if (cbJira.Text == "")
                return;

            OpenIssueInBrowser(cbJira.Text);
        }


        private void UpdateSummary()
        {

            if (cbJira.Text == "")
            {
                lblSummary.Text = "";
                return;
            }
            if (!jiraClient.SessionValid)
            {
                lblSummary.Text = "";
                return;
            }

            Task.Factory.StartNew(
                () => {
                    string key = "";
                    string summary = "";
                    this.InvokeIfRequired(
                        () => key = cbJira.Text
                    );
                    try
                    {
                        summary = jiraClient.GetIssueSummary(key, settings.IncludeProjectName);
                        this.InvokeIfRequired(
                            () => lblSummary.Text = summary
                        );
                    }
                    catch (RequestDeniedException)
                    {
                        // just leave the existing summary there when fetch fails
                    }
                }
            );
        }

        private void UpdateRemainingEstimate(WorklogForm  worklogForm)
        {
            RemainingEstimate = "";
            RemainingEstimateSeconds = -1;

            if (cbJira.Text == "")
                return;
            if (!jiraClient.SessionValid)
                return;

            Task.Factory.StartNew(
                () =>
                {
                    string key = "";
                    this.InvokeIfRequired(
                        () => key = cbJira.Text
                    );

                    TimetrackingFields timetracking = jiraClient.GetIssueTimetracking(key);
                    if (timetracking == null)
                        return;

                    this.InvokeIfRequired(
                        () => RemainingEstimate = timetracking.RemainingEstimate
                    );
                    this.InvokeIfRequired(
                        () => RemainingEstimateSeconds = timetracking.RemainingEstimateSeconds
                    );
                    if (worklogForm != null)
                    {
                        this.InvokeIfRequired(
                            () => worklogForm.RemainingEstimate = timetracking.RemainingEstimate
                        );
                        this.InvokeIfRequired(
                            () => worklogForm.RemainingEstimateSeconds = timetracking.RemainingEstimateSeconds
                        );                        
                    }
                }
            );
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cbJira = new ComboBox();
            tbTime = new TextBox();
            lblSummary = new Label();
            ttIssue = new ToolTip(components);
            btnRemoveIssue = new Button();
            btnPostAndReset = new Button();
            btnReset = new Button();
            btnStartStop = new Button();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // cbJira
            // 
            cbJira.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbJira.DisplayMember = "Key";
            cbJira.DrawMode = DrawMode.OwnerDrawVariable;
            cbJira.DropDownHeight = 90;
            cbJira.DropDownWidth = 488;
            cbJira.Font = new Font("Microsoft Sans Serif", 13F);
            cbJira.IntegralHeight = false;
            cbJira.Location = new Point(12, 5);
            cbJira.Name = "cbJira";
            cbJira.Size = new Size(155, 33);
            cbJira.TabIndex = 0;
            cbJira.ValueMember = "Key";
            cbJira.DrawItem += cbJira_DrawItem;
            cbJira.DropDown += cbJira_DropDown;
            cbJira.MeasureItem += cbJira_MeasureItem;
            cbJira.SelectionChangeCommitted += cbJira_SelectionChangeCommitted;
            cbJira.KeyDown += cbJira_KeyDown;
            cbJira.Leave += cbJira_Leave;
            // 
            // tbTime
            // 
            tbTime.Font = new Font("Microsoft Sans Serif", 13.3F);
            tbTime.Location = new Point(256, 5);
            tbTime.Name = "tbTime";
            tbTime.ReadOnly = true;
            tbTime.Size = new Size(107, 33);
            tbTime.TabIndex = 3;
            tbTime.TextAlign = HorizontalAlignment.Right;
            tbTime.KeyDown += tbTime_KeyDown;
            tbTime.MouseDoubleClick += tbTime_MouseDoubleClick;
            tbTime.MouseUp += tbTime_MouseUp;
            // 
            // lblSummary
            // 
            lblSummary.AutoEllipsis = true;
            lblSummary.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSummary.Location = new Point(11, 36);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(482, 17);
            lblSummary.TabIndex = 6;
            lblSummary.MouseUp += lblSummary_MouseUp;
            // 
            // btnRemoveIssue
            // 
            btnRemoveIssue.Enabled = false;
            btnRemoveIssue.Image = Properties.Resources.delete24;
            btnRemoveIssue.Location = new Point(465, 3);
            btnRemoveIssue.Name = "btnRemoveIssue";
            btnRemoveIssue.Size = new Size(32, 32);
            btnRemoveIssue.TabIndex = 7;
            ttIssue.SetToolTip(btnRemoveIssue, "Remove issue row (CTRL-DEL)");
            btnRemoveIssue.UseVisualStyleBackColor = true;
            btnRemoveIssue.Click += btnRemoveIssue_Click;
            // 
            // btnPostAndReset
            // 
            btnPostAndReset.Cursor = Cursors.Hand;
            btnPostAndReset.Image = Properties.Resources.posttime26;
            btnPostAndReset.Location = new Point(369, 3);
            btnPostAndReset.Name = "btnPostAndReset";
            btnPostAndReset.Size = new Size(32, 32);
            btnPostAndReset.TabIndex = 4;
            ttIssue.SetToolTip(btnPostAndReset, "Submit worklog to Jira and reset timer (CTRL-L)");
            btnPostAndReset.UseVisualStyleBackColor = true;
            btnPostAndReset.Click += btnPostAndReset_Click;
            btnPostAndReset.MouseUp += btnPostAndReset_MouseUp;
            // 
            // btnReset
            // 
            btnReset.Cursor = Cursors.Hand;
            btnReset.Image = Properties.Resources.reset24;
            btnReset.Location = new Point(429, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(32, 32);
            btnReset.TabIndex = 5;
            ttIssue.SetToolTip(btnReset, "Reset timer (CTRL-R)");
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            btnReset.MouseUp += btnReset_MouseUp;
            // 
            // btnStartStop
            // 
            btnStartStop.Cursor = Cursors.Hand;
            btnStartStop.Image = Properties.Resources.play26;
            btnStartStop.Location = new Point(220, 3);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(32, 32);
            btnStartStop.TabIndex = 2;
            ttIssue.SetToolTip(btnStartStop, "Start/stop timer (CTRL-P)");
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            btnStartStop.MouseUp += btnStartStop_MouseUp;
            // 
            // btnOpen
            // 
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.Image = Properties.Resources.openbrowser26;
            btnOpen.Location = new Point(168, 3);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(32, 32);
            btnOpen.TabIndex = 1;
            ttIssue.SetToolTip(btnOpen, "Open issue in browser (CTRL-O)");
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            btnOpen.MouseUp += btnOpen_MouseUp;
            // 
            // IssueControl
            // 
            BackColor = SystemColors.Window;
            Controls.Add(btnRemoveIssue);
            Controls.Add(btnPostAndReset);
            Controls.Add(lblSummary);
            Controls.Add(btnReset);
            Controls.Add(btnStartStop);
            Controls.Add(tbTime);
            Controls.Add(btnOpen);
            Controls.Add(cbJira);
            Name = "IssueControl";
            Size = new Size(517, 58);
            MouseUp += IssueControl_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        public void Reset()
        {
            Comment = null;
            EstimateUpdateMethod = EstimateUpdateMethods.Auto;
            EstimateUpdateValue = null;
            this.WatchTimer.Reset();
            UpdateOutput();

            if (this.TimerReset != null)
                this.TimerReset(this, new EventArgs());
        }


        public void OpenIssueInBrowser(string key)
        {
            if (string.IsNullOrEmpty(this.settings.JiraBaseUrl))
                return;

            string url = this.settings.JiraBaseUrl;
            if (!url.EndsWith("/"))
                url += "/";
            url += "browse/";
            url += key.Trim();
            System.Diagnostics.Process.Start(url);
        }
        #endregion


        #region private eventhandlers
        void cbJira_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index == 0)
                keyWidth = 0;
            CBIssueItem item = (CBIssueItem)cbJira.Items[e.Index];
            Font font = new Font(cbJira.Font.FontFamily, cbJira.Font.Size * 0.8f, cbJira.Font.Style);
            Size size = TextRenderer.MeasureText(e.Graphics, item.Key, font);
            e.ItemHeight = size.Height;
            if (keyWidth < size.Width)
                keyWidth = size.Width;
        }


        void cbJira_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the default background
            e.DrawBackground();

            CBIssueItem item = (CBIssueItem)cbJira.Items[e.Index];

            // Create rectangles for the columns to display
            Rectangle r1 = e.Bounds;
            Rectangle r2 = e.Bounds;

            r1.Width = keyWidth;

            r2.X = r1.Width + 5;
            r2.Width = 500 - keyWidth;

            Font font = new Font(e.Font.FontFamily, e.Font.Size * 0.8f, e.Font.Style);

            // Draw the text on the first column
            using (SolidBrush sb = new SolidBrush(e.ForeColor))
                e.Graphics.DrawString(item.Key, font, sb, r1);

            // Draw a line to isolate the columns 
            using (Pen p = new Pen(Color.Black))
                e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom);

            // Draw the text on the second column
            using (SolidBrush sb = new SolidBrush(e.ForeColor))
                e.Graphics.DrawString(item.Summary, font, sb, r2);

            // Draw a line to isolate the columns 
            using (Pen p = new Pen(Color.Black))
                e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, 140);

        }


        private void cbJira_DropDown(object sender, EventArgs e)
        {
            LoadIssues();
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenJira();
        }


        private void cbJira_Leave(object sender, EventArgs e)
        {
            UpdateOutput(true);
        }


        private void cbJira_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyCode == Keys.Enter)
                UpdateOutput(true);
        }


        private void cbJiraTbEvents_Paste(object sender, EventArgs e)
        {
            PasteKeyFromClipboard();
        }

        public void PasteKeyFromClipboard()
        {
            if (Clipboard.ContainsText())
            {
                cbJira.Text = JiraKeyHelpers.ParseUrlToKey(Clipboard.GetText());
                UpdateOutput(true);
            }
        }

        public void CopyKeyToClipboard()
        {
            if (string.IsNullOrEmpty(cbJira.Text))
                return;
            Clipboard.SetText(cbJira.Text);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        public void StartStop()
        {
            if (WatchTimer.Running) {
                this.WatchTimer.Pause();
            }
            else {
                this.WatchTimer.Start();

                this.TimerStarted?.Invoke(this, new EventArgs());
            }
            UpdateOutput(true);
        }

        private void btnRemoveIssue_Click(object sender, EventArgs e)
        {
            Remove();
        }

        public void Remove()
        {
            this._MarkedForRemoval = true;
            RemoveMeTriggered?.Invoke(this, new EventArgs());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void btnPostAndReset_Click(object sender, EventArgs e)
        {
            PostAndReset();
        }

        public void PostAndReset()
        {
            using (var worklogForm = new WorklogForm(WatchTimer.GetInitialStartTime(), WatchTimer.TimeElapsedNearestMinute, Comment, EstimateUpdateMethod, EstimateUpdateValue))
            {
                UpdateRemainingEstimate(worklogForm);
                var formResult = worklogForm.ShowDialog(this);
                if (formResult == DialogResult.OK)
                {
                    Comment = worklogForm.Comment.Trim();
                    EstimateUpdateMethod = worklogForm.estimateUpdateMethod;
                    EstimateUpdateValue = worklogForm.EstimateValue;

                    PostAndReset(cbJira.Text, worklogForm.InitialStartTime, WatchTimer.TimeElapsedNearestMinute, Comment, EstimateUpdateMethod, EstimateUpdateValue);
                }
                else if (formResult == DialogResult.Yes)
                {
                    Comment = string.Format("{0}:{1}{2}", DateTime.Now.ToString("g"), Environment.NewLine, worklogForm.Comment.Trim());
                    EstimateUpdateMethod = worklogForm.estimateUpdateMethod;
                    EstimateUpdateValue = worklogForm.EstimateValue;
                    UpdateOutput();
                }
            }
        }

        private void tbTime_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditTime();

        }


        private void tbTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyCode == Keys.Enter)
                EditTime();
        }
        #endregion


        #region private methods
        private void PostAndReset(string key, DateTimeOffset startTime, TimeSpan timeElapsed, string comment, EstimateUpdateMethods estimateUpdateMethod, string estimateUpdateValue)
        {
            Task.Factory.StartNew(
                () =>
                {
                    this.InvokeIfRequired(
                        () => {
                            btnPostAndReset.Enabled = false;
                            Cursor.Current = Cursors.WaitCursor;
                        }
                    );

                    bool postSuccesful = true;

                    // First post comment in Comment-track - and clear the comment string, if it should only be posted here
                    // Only actually post in Comment-track if text is not empty
                    if (settings.PostWorklogComment != WorklogCommentSetting.WorklogOnly && !string.IsNullOrEmpty(comment))
                    {
                        postSuccesful = jiraClient.PostComment(key, comment);
                        if (postSuccesful && settings.PostWorklogComment == WorklogCommentSetting.CommentOnly)
                            comment = "";
                    }

                    // Now post the WorkLog with timeElapsed - and comment unless it was reset
                    if (postSuccesful)
                        postSuccesful = jiraClient.PostWorklog(key, startTime, timeElapsed, comment, estimateUpdateMethod, estimateUpdateValue);

                    if (postSuccesful)
                    {
                        this.InvokeIfRequired(
                            () => Reset()
                        );
                    }

                    this.InvokeIfRequired(
                        () => {
                            btnPostAndReset.Enabled = true;
                            Cursor.Current = DefaultCursor;
                        }
                    );
                }
            );
        }


        private void LoadIssues()
        {
            // TODO: This + the datasource for cbFilters should be moved into a controller layer
            var ctrlList = (Application.OpenForms[0] as MainForm).Controls.Find("cbFilters", true);
            if (ctrlList.Length == 0)
                return;

            var cbFilters = ctrlList[0] as ComboBox;
            if (cbFilters.SelectedIndex < 0)
                return;

            string jql = (cbFilters.SelectedItem as CBFilterItem).Jql;

            Task.Factory.StartNew(
                () =>
                {
                    List<Issue> availableIssues = jiraClient.GetIssuesByJQL(jql).Issues;

                    if (availableIssues == null)
                        return;

                    this.InvokeIfRequired(
                        () =>
                        {
                            AvailableIssues = availableIssues;
                            cbJira.DropDownHeight = 120;
                            cbJira.Invalidate();
                        }
                    );
                }
            );
        }


        public void EditTime()
        {
            using (var editTimeForm = new EditTimeForm(WatchTimer.TimeElapsed))
            {
                if (editTimeForm.ShowDialog(this) == DialogResult.OK)
                {
                    WatchTimer.TimeElapsed = editTimeForm.Time;

                    UpdateOutput();

                    TimeEdited?.Invoke(this, new EventArgs());
                }
            }
        }


        public void OpenCombo()
        {
            cbJira.Focus();
            cbJira.DroppedDown = true;
        }


        private void SetSelected()
        {
            Selected?.Invoke(this, new EventArgs());
        }
        #endregion

        #region private members
        private ComboBox cbJira;
        private Button btnOpen;
        private TextBox tbTime;
        private Button btnStartStop;
        private Button btnReset;
        private Label lblSummary;

        private ToolTip ttIssue;
        private System.ComponentModel.IContainer components;
        private Button btnPostAndReset;

        private JiraClient jiraClient;

        private Settings settings;

        private int keyWidth;
        private string RemainingEstimate;
        private int RemainingEstimateSeconds;
        private Button btnRemoveIssue;
        private bool _MarkedForRemoval = false;

        private ComboTextBoxEvents cbJiraTbEvents;
        #endregion


        #region private classes
        // content item for the combo box
        private class CBIssueItem {
            public string Key { get; set; }
            public string Summary { get; set; }

            public CBIssueItem(string key, string summary) {
                Key = key;
                Summary = summary;
            }
        }
        #endregion

        private void IssueControl_MouseUp(object sender, MouseEventArgs e)
        {
            SetSelected();
        }

        private void btnOpen_MouseUp(object sender, MouseEventArgs e)
        {
            SetSelected();
        }

        private void btnStartStop_MouseUp(object sender, MouseEventArgs e)
        {
            SetSelected();
        }

        private void tbTime_MouseUp(object sender, MouseEventArgs e)
        {
            SetSelected();
        }

        private void btnPostAndReset_MouseUp(object sender, MouseEventArgs e)
        {
            SetSelected();
        }

        private void btnReset_MouseUp(object sender, MouseEventArgs e)
        {
            SetSelected();
        }

        private void lblSummary_MouseUp(object sender, MouseEventArgs e)
        {
            SetSelected();
        }

        private void cbJira_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetSelected();
            UpdateOutput(true);
        }
    }
}
