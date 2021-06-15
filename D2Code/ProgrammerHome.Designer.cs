
namespace D2Code {
    partial class ProgrammerHome {
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonIssues = new System.Windows.Forms.Button();
            this.buttonTask = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(25, 20);
            this.labelWelcome.MaximumSize = new System.Drawing.Size(400, 100);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(339, 86);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Welcome UserName Placeholder";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonIssues
            // 
            this.buttonIssues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIssues.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIssues.Location = new System.Drawing.Point(120, 128);
            this.buttonIssues.Name = "buttonIssues";
            this.buttonIssues.Size = new System.Drawing.Size(147, 59);
            this.buttonIssues.TabIndex = 5;
            this.buttonIssues.Text = "Issues";
            this.buttonIssues.UseVisualStyleBackColor = true;
            this.buttonIssues.Click += new System.EventHandler(this.buttonIssues_Click);
            // 
            // buttonTask
            // 
            this.buttonTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTask.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTask.Location = new System.Drawing.Point(120, 203);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(147, 59);
            this.buttonTask.TabIndex = 6;
            this.buttonTask.Text = "Tasks";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTasks_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogout.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.buttonLogout.Location = new System.Drawing.Point(119, 351);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(148, 59);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReport.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.Location = new System.Drawing.Point(120, 277);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(147, 59);
            this.buttonReport.TabIndex = 10;
            this.buttonReport.Text = "Reports";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // ProgrammerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 437);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.buttonIssues);
            this.Controls.Add(this.labelWelcome);
            this.Name = "ProgrammerHome";
            this.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonIssues;
        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonReport;
    }
}