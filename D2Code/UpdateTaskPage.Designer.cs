
namespace D2Code {
    partial class UpdateTaskPage {
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
            this.labelCompleteDate = new System.Windows.Forms.Label();
            this.dtpCompleteDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
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
            this.labelTitle.Location = new System.Drawing.Point(69, 9);
            this.labelTitle.MaximumSize = new System.Drawing.Size(400, 100);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(239, 43);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Update Task";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCompleteDate
            // 
            this.labelCompleteDate.AutoSize = true;
            this.labelCompleteDate.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelCompleteDate.Location = new System.Drawing.Point(28, 99);
            this.labelCompleteDate.Name = "labelCompleteDate";
            this.labelCompleteDate.Size = new System.Drawing.Size(150, 22);
            this.labelCompleteDate.TabIndex = 15;
            this.labelCompleteDate.Text = "Complete Date:";
            // 
            // dtpCompleteDate
            // 
            this.dtpCompleteDate.Font = new System.Drawing.Font("Consolas", 14F);
            this.dtpCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCompleteDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpCompleteDate.Location = new System.Drawing.Point(222, 99);
            this.dtpCompleteDate.Name = "dtpCompleteDate";
            this.dtpCompleteDate.ShowCheckBox = true;
            this.dtpCompleteDate.Size = new System.Drawing.Size(154, 29);
            this.dtpCompleteDate.TabIndex = 16;
            this.dtpCompleteDate.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Consolas", 14F);
            this.textBoxDescription.Location = new System.Drawing.Point(32, 279);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(344, 169);
            this.textBoxDescription.TabIndex = 19;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelDescription.Location = new System.Drawing.Point(28, 254);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(130, 22);
            this.labelDescription.TabIndex = 20;
            this.labelDescription.Text = "Description:";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Consolas", 14F);
            this.labelPriority.Location = new System.Drawing.Point(28, 178);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(100, 22);
            this.labelPriority.TabIndex = 21;
            this.labelPriority.Text = "Priority:";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.Font = new System.Drawing.Font("Consolas", 14F);
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Low",
            "Moderate",
            "High",
            "Urgent"});
            this.comboBoxPriority.Location = new System.Drawing.Point(222, 178);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(154, 30);
            this.comboBoxPriority.TabIndex = 22;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirm.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(32, 467);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(147, 59);
            this.buttonConfirm.TabIndex = 23;
            this.buttonConfirm.TabStop = false;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(229, 467);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(147, 59);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // UpdateTaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 537);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dtpCompleteDate);
            this.Controls.Add(this.labelCompleteDate);
            this.Controls.Add(this.labelTitle);
            this.Name = "UpdateTaskPage";
            this.Text = "Update Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCompleteDate;
        private System.Windows.Forms.DateTimePicker dtpCompleteDate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}