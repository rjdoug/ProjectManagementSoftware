
namespace D2Code {
    partial class ProjectPage {
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
            this.labelProjects = new System.Windows.Forms.Label();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.buttonViewTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProjects
            // 
            this.labelProjects.AutoSize = true;
            this.labelProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjects.Location = new System.Drawing.Point(211, 9);
            this.labelProjects.Name = "labelProjects";
            this.labelProjects.Size = new System.Drawing.Size(153, 42);
            this.labelProjects.TabIndex = 0;
            this.labelProjects.Text = "Projects";
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 20;
            this.listBoxProjects.Location = new System.Drawing.Point(12, 61);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(552, 324);
            this.listBoxProjects.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(399, 393);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 45);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails.Location = new System.Drawing.Point(31, 393);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(113, 45);
            this.buttonDetails.TabIndex = 3;
            this.buttonDetails.Text = "Details";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonViewTasks
            // 
            this.buttonViewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewTasks.Location = new System.Drawing.Point(173, 393);
            this.buttonViewTasks.Name = "buttonViewTasks";
            this.buttonViewTasks.Size = new System.Drawing.Size(191, 45);
            this.buttonViewTasks.TabIndex = 4;
            this.buttonViewTasks.Text = "View Task";
            this.buttonViewTasks.UseVisualStyleBackColor = true;
            this.buttonViewTasks.Click += new System.EventHandler(this.buttonViewTasks_Click);
            // 
            // ProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.buttonViewTasks);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxProjects);
            this.Controls.Add(this.labelProjects);
            this.Name = "ProjectPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjects;
        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Button buttonViewTasks;
    }
}