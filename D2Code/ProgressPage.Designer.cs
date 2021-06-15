
namespace D2Code {
    partial class ProgressPage {
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
            this.labelProgress = new System.Windows.Forms.Label();
            this.listBoxProgress = new System.Windows.Forms.ListBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.Location = new System.Drawing.Point(197, 9);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(168, 42);
            this.labelProgress.TabIndex = 7;
            this.labelProgress.Text = "Progress";
            // 
            // listBoxProgress
            // 
            this.listBoxProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProgress.FormattingEnabled = true;
            this.listBoxProgress.ItemHeight = 20;
            this.listBoxProgress.Location = new System.Drawing.Point(12, 63);
            this.listBoxProgress.Name = "listBoxProgress";
            this.listBoxProgress.Size = new System.Drawing.Size(552, 324);
            this.listBoxProgress.TabIndex = 8;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTask.Location = new System.Drawing.Point(66, 393);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(177, 45);
            this.buttonAddTask.TabIndex = 10;
            this.buttonAddTask.Text = "Add";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(309, 393);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(177, 45);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ProgressPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.listBoxProgress);
            this.Controls.Add(this.labelProgress);
            this.Name = "ProgressPage";
            this.Text = "Progress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ListBox listBoxProgress;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonBack;
    }
}