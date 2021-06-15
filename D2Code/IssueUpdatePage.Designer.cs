
namespace D2Code {
    partial class IssueUpdatePage {
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
            this.labelUrgency = new System.Windows.Forms.Label();
            this.comboBoxUrgency = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(60, 9);
            this.labelTitle.MaximumSize = new System.Drawing.Size(400, 100);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(259, 43);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Update Issue";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelUrgency
            // 
            this.labelUrgency.AutoSize = true;
            this.labelUrgency.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelUrgency.Location = new System.Drawing.Point(16, 102);
            this.labelUrgency.Name = "labelUrgency";
            this.labelUrgency.Size = new System.Drawing.Size(90, 22);
            this.labelUrgency.TabIndex = 25;
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
            this.comboBoxUrgency.Location = new System.Drawing.Point(210, 99);
            this.comboBoxUrgency.Name = "comboBoxUrgency";
            this.comboBoxUrgency.Size = new System.Drawing.Size(154, 30);
            this.comboBoxUrgency.TabIndex = 26;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelStatus.Location = new System.Drawing.Point(25, 196);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(80, 22);
            this.labelStatus.TabIndex = 28;
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
            this.comboBoxStatus.Location = new System.Drawing.Point(210, 193);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(154, 30);
            this.comboBoxStatus.TabIndex = 29;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelDescription.Location = new System.Drawing.Point(25, 286);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(130, 22);
            this.labelDescription.TabIndex = 31;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Consolas", 14F);
            this.textBoxDescription.Location = new System.Drawing.Point(20, 311);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(344, 135);
            this.textBoxDescription.TabIndex = 32;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirm.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(20, 466);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(147, 59);
            this.buttonConfirm.TabIndex = 33;
            this.buttonConfirm.TabStop = false;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(217, 466);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(147, 59);
            this.buttonCancel.TabIndex = 34;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // IssueUpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 537);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxUrgency);
            this.Controls.Add(this.labelUrgency);
            this.Controls.Add(this.labelTitle);
            this.Name = "IssueUpdatePage";
            this.Text = "Update Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUrgency;
        private System.Windows.Forms.ComboBox comboBoxUrgency;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}