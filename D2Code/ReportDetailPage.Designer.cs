
namespace D2Code {
    partial class ReportDetailPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTaskCount = new System.Windows.Forms.Label();
            this.labelTaskCompleteCount = new System.Windows.Forms.Label();
            this.labelTaskIncompleteCount = new System.Windows.Forms.Label();
            this.labelProgrammerCount = new System.Windows.Forms.Label();
            this.labelIssueCount = new System.Windows.Forms.Label();
            this.labelOpenIssues = new System.Windows.Forms.Label();
            this.labelClosedIssues = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(16, 9);
            this.labelTitle.MaximumSize = new System.Drawing.Size(400, 100);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(379, 86);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Project wit hextra long name";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTaskCount
            // 
            this.labelTaskCount.AutoSize = true;
            this.labelTaskCount.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelTaskCount.Location = new System.Drawing.Point(61, 121);
            this.labelTaskCount.Name = "labelTaskCount";
            this.labelTaskCount.Size = new System.Drawing.Size(80, 22);
            this.labelTaskCount.TabIndex = 25;
            this.labelTaskCount.Text = "Tasks: ";
            // 
            // labelTaskCompleteCount
            // 
            this.labelTaskCompleteCount.AutoSize = true;
            this.labelTaskCompleteCount.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelTaskCompleteCount.Location = new System.Drawing.Point(61, 168);
            this.labelTaskCompleteCount.Name = "labelTaskCompleteCount";
            this.labelTaskCompleteCount.Size = new System.Drawing.Size(170, 22);
            this.labelTaskCompleteCount.TabIndex = 26;
            this.labelTaskCompleteCount.Text = "Tasks Complete: ";
            // 
            // labelTaskIncompleteCount
            // 
            this.labelTaskIncompleteCount.AutoSize = true;
            this.labelTaskIncompleteCount.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelTaskIncompleteCount.Location = new System.Drawing.Point(61, 215);
            this.labelTaskIncompleteCount.Name = "labelTaskIncompleteCount";
            this.labelTaskIncompleteCount.Size = new System.Drawing.Size(190, 22);
            this.labelTaskIncompleteCount.TabIndex = 27;
            this.labelTaskIncompleteCount.Text = "Tasks Incomplete: ";
            // 
            // labelProgrammerCount
            // 
            this.labelProgrammerCount.AutoSize = true;
            this.labelProgrammerCount.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelProgrammerCount.Location = new System.Drawing.Point(61, 258);
            this.labelProgrammerCount.Name = "labelProgrammerCount";
            this.labelProgrammerCount.Size = new System.Drawing.Size(140, 22);
            this.labelProgrammerCount.TabIndex = 28;
            this.labelProgrammerCount.Text = "Programmers: ";
            // 
            // labelIssueCount
            // 
            this.labelIssueCount.AutoSize = true;
            this.labelIssueCount.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelIssueCount.Location = new System.Drawing.Point(61, 305);
            this.labelIssueCount.Name = "labelIssueCount";
            this.labelIssueCount.Size = new System.Drawing.Size(90, 22);
            this.labelIssueCount.TabIndex = 29;
            this.labelIssueCount.Text = "Issues: ";
            // 
            // labelOpenIssues
            // 
            this.labelOpenIssues.AutoSize = true;
            this.labelOpenIssues.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelOpenIssues.Location = new System.Drawing.Point(61, 348);
            this.labelOpenIssues.Name = "labelOpenIssues";
            this.labelOpenIssues.Size = new System.Drawing.Size(140, 22);
            this.labelOpenIssues.TabIndex = 30;
            this.labelOpenIssues.Text = "Issues Open: ";
            // 
            // labelClosedIssues
            // 
            this.labelClosedIssues.AutoSize = true;
            this.labelClosedIssues.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelClosedIssues.Location = new System.Drawing.Point(61, 393);
            this.labelClosedIssues.Name = "labelClosedIssues";
            this.labelClosedIssues.Size = new System.Drawing.Size(160, 22);
            this.labelClosedIssues.TabIndex = 31;
            this.labelClosedIssues.Text = "Issues Closed: ";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(104, 453);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(147, 59);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ReportDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 524);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelClosedIssues);
            this.Controls.Add(this.labelOpenIssues);
            this.Controls.Add(this.labelIssueCount);
            this.Controls.Add(this.labelProgrammerCount);
            this.Controls.Add(this.labelTaskIncompleteCount);
            this.Controls.Add(this.labelTaskCompleteCount);
            this.Controls.Add(this.labelTaskCount);
            this.Controls.Add(this.labelTitle);
            this.Name = "ReportDetailPage";
            this.Text = "Summary Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTaskCount;
        private System.Windows.Forms.Label labelTaskCompleteCount;
        private System.Windows.Forms.Label labelTaskIncompleteCount;
        private System.Windows.Forms.Label labelProgrammerCount;
        private System.Windows.Forms.Label labelIssueCount;
        private System.Windows.Forms.Label labelOpenIssues;
        private System.Windows.Forms.Label labelClosedIssues;
        private System.Windows.Forms.Button buttonBack;
    }
}