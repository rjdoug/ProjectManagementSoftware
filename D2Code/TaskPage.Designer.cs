
namespace D2Code {
    partial class TaskPage {
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
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTasks = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 20;
            this.listBoxTasks.Location = new System.Drawing.Point(12, 63);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(552, 324);
            this.listBoxTasks.TabIndex = 2;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.Location = new System.Drawing.Point(44, 393);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(113, 45);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(402, 393);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 45);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTasks
            // 
            this.labelTasks.AutoSize = true;
            this.labelTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTasks.Location = new System.Drawing.Point(221, 9);
            this.labelTasks.Name = "labelTasks";
            this.labelTasks.Size = new System.Drawing.Size(119, 42);
            this.labelTasks.TabIndex = 6;
            this.labelTasks.Text = "Tasks";
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTask.Location = new System.Drawing.Point(188, 393);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(177, 45);
            this.buttonAddTask.TabIndex = 7;
            this.buttonAddTask.Text = "Add";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonMiddle_Click);
            // 
            // TaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.labelTasks);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.listBoxTasks);
            this.Name = "TaskPage";
            this.Text = "Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTasks;
        private System.Windows.Forms.Button buttonAddTask;
    }
}