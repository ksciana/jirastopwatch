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
    partial class EditTimeForm
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
            tbTime = new System.Windows.Forms.TextBox();
            btnOk = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblHeader = new System.Windows.Forms.Label();
            lblHint = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // tbTime
            // 
            tbTime.BackColor = System.Drawing.SystemColors.Window;
            tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F);
            tbTime.Location = new System.Drawing.Point(19, 38);
            tbTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbTime.Name = "tbTime";
            tbTime.Size = new System.Drawing.Size(176, 33);
            tbTime.TabIndex = 4;
            tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            tbTime.TextChanged += tbTime_TextChanged;
            // 
            // btnOk
            // 
            btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnOk.Location = new System.Drawing.Point(40, 158);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(75, 35);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(121, 158);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new System.Drawing.Point(15, 14);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(74, 20);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "Edit timer";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Location = new System.Drawing.Point(15, 86);
            lblHint.Name = "lblHint";
            lblHint.Size = new System.Drawing.Size(137, 40);
            lblHint.TabIndex = 8;
            lblHint.Text = "Supported formats:\r\n2h 15m and 2.25h";
            // 
            // EditTimeForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(212, 211);
            Controls.Add(lblHint);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(lblHeader);
            Controls.Add(tbTime);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditTimeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edit Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblHint;
    }
}
