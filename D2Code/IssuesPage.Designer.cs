
namespace D2Code {
    partial class IssuesPage {
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
            this.listBoxIssues = new System.Windows.Forms.ListBox();
            this.labelIssues = new System.Windows.Forms.Label();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.buttonAddIssue = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxIssues
            // 
            this.listBoxIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIssues.FormattingEnabled = true;
            this.listBoxIssues.ItemHeight = 20;
            this.listBoxIssues.Location = new System.Drawing.Point(12, 63);
            this.listBoxIssues.Name = "listBoxIssues";
            this.listBoxIssues.Size = new System.Drawing.Size(552, 324);
            this.listBoxIssues.TabIndex = 2;
            // 
            // labelIssues
            // 
            this.labelIssues.AutoSize = true;
            this.labelIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssues.Location = new System.Drawing.Point(209, 9);
            this.labelIssues.Name = "labelIssues";
            this.labelIssues.Size = new System.Drawing.Size(126, 42);
            this.labelIssues.TabIndex = 3;
            this.labelIssues.Text = "Issues";
            // 
            // buttonDetails
            // 
            this.buttonDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails.Location = new System.Drawing.Point(21, 393);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(113, 45);
            this.buttonDetails.TabIndex = 4;
            this.buttonDetails.Text = "Details";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // buttonAddIssue
            // 
            this.buttonAddIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddIssue.Location = new System.Drawing.Point(174, 393);
            this.buttonAddIssue.Name = "buttonAddIssue";
            this.buttonAddIssue.Size = new System.Drawing.Size(191, 45);
            this.buttonAddIssue.TabIndex = 5;
            this.buttonAddIssue.Text = "Add Issue";
            this.buttonAddIssue.UseVisualStyleBackColor = true;
            this.buttonAddIssue.Click += new System.EventHandler(this.buttonAddIssue_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(411, 393);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 45);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // IssuesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddIssue);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.labelIssues);
            this.Controls.Add(this.listBoxIssues);
            this.Name = "IssuesPage";
            this.Text = "Issues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIssues;
        private System.Windows.Forms.Label labelIssues;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Button buttonAddIssue;
        private System.Windows.Forms.Button buttonBack;
    }
}