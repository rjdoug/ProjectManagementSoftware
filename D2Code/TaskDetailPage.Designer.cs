
namespace D2Code {
    partial class TaskDetailPage {
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
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelCompleteDate = new System.Windows.Forms.Label();
            this.labelProject = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBoxProgress = new System.Windows.Forms.ListBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.listBoxProgrammers = new System.Windows.Forms.ListBox();
            this.labelProgrammers = new System.Windows.Forms.Label();
            this.buttonAddProgrammer = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(232, 9);
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
            this.textBoxPriority.Location = new System.Drawing.Point(91, 360);
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
            this.textBoxDescription.Location = new System.Drawing.Point(12, 169);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(359, 168);
            this.textBoxDescription.TabIndex = 13;
            this.textBoxDescription.TabStop = false;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelStartDate.Location = new System.Drawing.Point(19, 484);
            this.labelStartDate.MaximumSize = new System.Drawing.Size(357, 50);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(120, 22);
            this.labelStartDate.TabIndex = 14;
            this.labelStartDate.Text = "StartDate: ";
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCompleteDate
            // 
            this.labelCompleteDate.AutoSize = true;
            this.labelCompleteDate.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelCompleteDate.Location = new System.Drawing.Point(19, 543);
            this.labelCompleteDate.MinimumSize = new System.Drawing.Size(357, 50);
            this.labelCompleteDate.Name = "labelCompleteDate";
            this.labelCompleteDate.Size = new System.Drawing.Size(357, 50);
            this.labelCompleteDate.TabIndex = 15;
            this.labelCompleteDate.Text = "CompleteDate: ";
            this.labelCompleteDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelProject.Location = new System.Drawing.Point(15, 430);
            this.labelProject.MaximumSize = new System.Drawing.Size(357, 50);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(100, 22);
            this.labelProject.TabIndex = 16;
            this.labelProject.Text = "Project: ";
            this.labelProject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(408, 625);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(147, 59);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxProgress
            // 
            this.listBoxProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProgress.FormattingEnabled = true;
            this.listBoxProgress.HorizontalScrollbar = true;
            this.listBoxProgress.ItemHeight = 20;
            this.listBoxProgress.Location = new System.Drawing.Point(423, 169);
            this.listBoxProgress.Name = "listBoxProgress";
            this.listBoxProgress.Size = new System.Drawing.Size(380, 164);
            this.listBoxProgress.TabIndex = 18;
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Consolas", 24F);
            this.labelProgress.Location = new System.Drawing.Point(535, 109);
            this.labelProgress.MaximumSize = new System.Drawing.Size(400, 100);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(161, 37);
            this.labelProgress.TabIndex = 19;
            this.labelProgress.Text = "Progress";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxProgrammers
            // 
            this.listBoxProgrammers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProgrammers.FormattingEnabled = true;
            this.listBoxProgrammers.HorizontalScrollbar = true;
            this.listBoxProgrammers.ItemHeight = 20;
            this.listBoxProgrammers.Location = new System.Drawing.Point(423, 398);
            this.listBoxProgrammers.Name = "listBoxProgrammers";
            this.listBoxProgrammers.Size = new System.Drawing.Size(380, 164);
            this.listBoxProgrammers.TabIndex = 20;
            // 
            // labelProgrammers
            // 
            this.labelProgrammers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProgrammers.AutoSize = true;
            this.labelProgrammers.Font = new System.Drawing.Font("Consolas", 24F);
            this.labelProgrammers.Location = new System.Drawing.Point(426, 356);
            this.labelProgrammers.MaximumSize = new System.Drawing.Size(400, 100);
            this.labelProgrammers.Name = "labelProgrammers";
            this.labelProgrammers.Size = new System.Drawing.Size(377, 37);
            this.labelProgrammers.TabIndex = 21;
            this.labelProgrammers.Text = "Assigned Programmers";
            this.labelProgrammers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAddProgrammer
            // 
            this.buttonAddProgrammer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddProgrammer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProgrammer.Location = new System.Drawing.Point(527, 571);
            this.buttonAddProgrammer.Name = "buttonAddProgrammer";
            this.buttonAddProgrammer.Size = new System.Drawing.Size(147, 43);
            this.buttonAddProgrammer.TabIndex = 23;
            this.buttonAddProgrammer.TabStop = false;
            this.buttonAddProgrammer.Text = "Add";
            this.buttonAddProgrammer.UseVisualStyleBackColor = true;
            this.buttonAddProgrammer.Click += new System.EventHandler(this.buttonAddProgrammer_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Consolas", 24F);
            this.labelDescription.Location = new System.Drawing.Point(84, 109);
            this.labelDescription.MaximumSize = new System.Drawing.Size(400, 100);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(215, 37);
            this.labelDescription.TabIndex = 24;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(224, 625);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(147, 59);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // TaskDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 696);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonAddProgrammer);
            this.Controls.Add(this.labelProgrammers);
            this.Controls.Add(this.listBoxProgrammers);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.listBoxProgress);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.labelCompleteDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPriority);
            this.Controls.Add(this.labelTitle);
            this.Name = "TaskDetailPage";
            this.Text = "Task Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelCompleteDate;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxProgress;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ListBox listBoxProgrammers;
        private System.Windows.Forms.Label labelProgrammers;
        private System.Windows.Forms.Button buttonAddProgrammer;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonUpdate;
    }
}