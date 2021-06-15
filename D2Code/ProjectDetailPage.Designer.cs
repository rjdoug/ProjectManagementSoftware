
namespace D2Code {
    partial class ProjectDetailPage {
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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelBudget = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDescription.Font = new System.Drawing.Font("Consolas", 14F);
            this.textBoxDescription.Location = new System.Drawing.Point(12, 169);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(359, 114);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.Color.Green;
            this.textBoxStatus.Font = new System.Drawing.Font("Consolas", 18F);
            this.textBoxStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxStatus.Location = new System.Drawing.Point(90, 113);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(194, 36);
            this.textBoxStatus.TabIndex = 3;
            this.textBoxStatus.TabStop = false;
            this.textBoxStatus.Text = "Complete";
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelStartDate.Location = new System.Drawing.Point(66, 314);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(110, 22);
            this.labelStartDate.TabIndex = 4;
            this.labelStartDate.Text = "StartDate:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelEndDate.Location = new System.Drawing.Point(86, 362);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(90, 22);
            this.labelEndDate.TabIndex = 5;
            this.labelEndDate.Text = "EndDate:";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(100, 506);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(147, 59);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelBudget
            // 
            this.labelBudget.AutoSize = true;
            this.labelBudget.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelBudget.Location = new System.Drawing.Point(96, 415);
            this.labelBudget.Name = "labelBudget";
            this.labelBudget.Size = new System.Drawing.Size(100, 22);
            this.labelBudget.TabIndex = 8;
            this.labelBudget.Text = "Budget: $";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelCustomer.Location = new System.Drawing.Point(76, 469);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(100, 22);
            this.labelCustomer.TabIndex = 9;
            this.labelCustomer.Text = "Customer:";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(-4, 9);
            this.labelTitle.MaximumSize = new System.Drawing.Size(400, 100);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(379, 86);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Project sfdhsr dfh dfh sdfh ";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProjectDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 577);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelBudget);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxDescription);
            this.Name = "ProjectDetailPage";
            this.Text = "Project Details";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelBudget;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelTitle;
    }
}