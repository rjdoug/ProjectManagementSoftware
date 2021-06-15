
namespace D2Code {
    partial class IssueDetailsPage {
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
            this.textBoxUrgency = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelReportDate = new System.Windows.Forms.Label();
            this.labelProject = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.MaximumSize = new System.Drawing.Size(400, 100);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(159, 43);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Issue #";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUrgency
            // 
            this.textBoxUrgency.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxUrgency.Font = new System.Drawing.Font("Consolas", 18F);
            this.textBoxUrgency.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxUrgency.Location = new System.Drawing.Point(96, 107);
            this.textBoxUrgency.Name = "textBoxUrgency";
            this.textBoxUrgency.Size = new System.Drawing.Size(194, 36);
            this.textBoxUrgency.TabIndex = 11;
            this.textBoxUrgency.TabStop = false;
            this.textBoxUrgency.Text = "Urgent";
            this.textBoxUrgency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.Color.Green;
            this.textBoxStatus.Font = new System.Drawing.Font("Consolas", 18F);
            this.textBoxStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxStatus.Location = new System.Drawing.Point(96, 178);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(194, 36);
            this.textBoxStatus.TabIndex = 12;
            this.textBoxStatus.TabStop = false;
            this.textBoxStatus.Text = "Complete";
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDescription.Font = new System.Drawing.Font("Consolas", 14F);
            this.textBoxDescription.Location = new System.Drawing.Point(20, 234);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(359, 114);
            this.textBoxDescription.TabIndex = 13;
            this.textBoxDescription.TabStop = false;
            // 
            // labelReportDate
            // 
            this.labelReportDate.AutoSize = true;
            this.labelReportDate.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelReportDate.Location = new System.Drawing.Point(101, 366);
            this.labelReportDate.Name = "labelReportDate";
            this.labelReportDate.Size = new System.Drawing.Size(130, 22);
            this.labelReportDate.TabIndex = 14;
            this.labelReportDate.Text = "ReportDate: ";
            // 
            // labelProject
            // 
            this.labelProject.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelProject.Location = new System.Drawing.Point(20, 444);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(359, 47);
            this.labelProject.TabIndex = 15;
            this.labelProject.Text = "Project: ";
            this.labelProject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(232, 506);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(147, 59);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(20, 506);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(147, 59);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // IssueDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 577);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.labelReportDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxUrgency);
            this.Controls.Add(this.labelTitle);
            this.Name = "IssueDetailsPage";
            this.Text = "Issue Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxUrgency;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelReportDate;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonUpdate;
    }
}