
namespace D2Code {
    partial class ProgrammerTaskDetailPage {
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
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelProject = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelCompleteDate = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
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
            this.labelTitle.Size = new System.Drawing.Size(379, 86);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Project sfdhsr dfh dfh sdfh ";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.BackColor = System.Drawing.Color.Green;
            this.textBoxPriority.Font = new System.Drawing.Font("Consolas", 18F);
            this.textBoxPriority.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxPriority.Location = new System.Drawing.Point(95, 120);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(194, 36);
            this.textBoxPriority.TabIndex = 12;
            this.textBoxPriority.TabStop = false;
            this.textBoxPriority.Text = "Complete";
            this.textBoxPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDescription.Font = new System.Drawing.Font("Consolas", 14F);
            this.textBoxDescription.Location = new System.Drawing.Point(20, 179);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(359, 114);
            this.textBoxDescription.TabIndex = 13;
            this.textBoxDescription.TabStop = false;
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelProject.Location = new System.Drawing.Point(91, 322);
            this.labelProject.MaximumSize = new System.Drawing.Size(357, 50);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(100, 22);
            this.labelProject.TabIndex = 17;
            this.labelProject.Text = "Project: ";
            this.labelProject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelStartDate.Location = new System.Drawing.Point(91, 383);
            this.labelStartDate.MaximumSize = new System.Drawing.Size(357, 50);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(120, 22);
            this.labelStartDate.TabIndex = 18;
            this.labelStartDate.Text = "StartDate: ";
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCompleteDate
            // 
            this.labelCompleteDate.AutoSize = true;
            this.labelCompleteDate.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelCompleteDate.Location = new System.Drawing.Point(12, 447);
            this.labelCompleteDate.MinimumSize = new System.Drawing.Size(357, 50);
            this.labelCompleteDate.Name = "labelCompleteDate";
            this.labelCompleteDate.Size = new System.Drawing.Size(357, 50);
            this.labelCompleteDate.TabIndex = 19;
            this.labelCompleteDate.Text = "CompleteDate: ";
            this.labelCompleteDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(122, 500);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(147, 59);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ProgrammerTaskDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 577);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelCompleteDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPriority);
            this.Controls.Add(this.labelTitle);
            this.Name = "ProgrammerTaskDetailPage";
            this.Text = "Task Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelCompleteDate;
        private System.Windows.Forms.Button buttonBack;
    }
}