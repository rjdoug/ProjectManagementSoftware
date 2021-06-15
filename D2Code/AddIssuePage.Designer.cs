
namespace D2Code {
    partial class AddIssuePage {
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelUrgency = new System.Windows.Forms.Label();
            this.comboBoxUrgency = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.labelProjectTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(104, 9);
            this.labelTitle.MaximumSize = new System.Drawing.Size(400, 100);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(199, 43);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Add Issue";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirm.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(28, 511);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(147, 59);
            this.buttonConfirm.TabIndex = 22;
            this.buttonConfirm.TabStop = false;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(225, 511);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(147, 59);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelUrgency
            // 
            this.labelUrgency.AutoSize = true;
            this.labelUrgency.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelUrgency.Location = new System.Drawing.Point(24, 226);
            this.labelUrgency.Name = "labelUrgency";
            this.labelUrgency.Size = new System.Drawing.Size(90, 22);
            this.labelUrgency.TabIndex = 24;
            this.labelUrgency.Text = "Urgency:";
            // 
            // comboBoxUrgency
            // 
            this.comboBoxUrgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUrgency.Font = new System.Drawing.Font("Consolas", 14F);
            this.comboBoxUrgency.FormattingEnabled = true;
            this.comboBoxUrgency.Items.AddRange(new object[] {
            "Low",
            "Moderate",
            "High",
            "Urgent"});
            this.comboBoxUrgency.Location = new System.Drawing.Point(218, 223);
            this.comboBoxUrgency.Name = "comboBoxUrgency";
            this.comboBoxUrgency.Size = new System.Drawing.Size(154, 30);
            this.comboBoxUrgency.TabIndex = 25;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelStatus.Location = new System.Drawing.Point(24, 281);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(80, 22);
            this.labelStatus.TabIndex = 27;
            this.labelStatus.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Consolas", 14F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Completed",
            "Development",
            "Postponed"});
            this.comboBoxStatus.Location = new System.Drawing.Point(218, 278);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(154, 30);
            this.comboBoxStatus.TabIndex = 28;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Consolas", 14F);
            this.textBoxDescription.Location = new System.Drawing.Point(28, 358);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(344, 135);
            this.textBoxDescription.TabIndex = 29;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelDescription.Location = new System.Drawing.Point(24, 333);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(130, 22);
            this.labelDescription.TabIndex = 30;
            this.labelDescription.Text = "Description:";
            // 
            // listBoxContent
            // 
            this.listBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.ItemHeight = 20;
            this.listBoxContent.Location = new System.Drawing.Point(28, 100);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(344, 104);
            this.listBoxContent.TabIndex = 31;
            // 
            // labelProjectTask
            // 
            this.labelProjectTask.AutoSize = true;
            this.labelProjectTask.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelProjectTask.Location = new System.Drawing.Point(24, 75);
            this.labelProjectTask.Name = "labelProjectTask";
            this.labelProjectTask.Size = new System.Drawing.Size(90, 22);
            this.labelProjectTask.TabIndex = 32;
            this.labelProjectTask.Text = "Project:";
            // 
            // AddIssuePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 582);
            this.Controls.Add(this.labelProjectTask);
            this.Controls.Add(this.listBoxContent);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxUrgency);
            this.Controls.Add(this.labelUrgency);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddIssuePage";
            this.Text = "Add Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelUrgency;
        private System.Windows.Forms.ComboBox comboBoxUrgency;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ListBox listBoxContent;
        private System.Windows.Forms.Label labelProjectTask;
    }
}