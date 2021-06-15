
namespace D2Code {
    partial class AssignProgrammerPage {
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.listBoxProgrammers = new System.Windows.Forms.ListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(64, 339);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(147, 59);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAssign
            // 
            this.buttonAssign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAssign.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssign.Location = new System.Drawing.Point(64, 274);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(147, 59);
            this.buttonAssign.TabIndex = 19;
            this.buttonAssign.TabStop = false;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // listBoxProgrammers
            // 
            this.listBoxProgrammers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProgrammers.FormattingEnabled = true;
            this.listBoxProgrammers.HorizontalScrollbar = true;
            this.listBoxProgrammers.ItemHeight = 20;
            this.listBoxProgrammers.Location = new System.Drawing.Point(12, 104);
            this.listBoxProgrammers.Name = "listBoxProgrammers";
            this.listBoxProgrammers.Size = new System.Drawing.Size(280, 164);
            this.listBoxProgrammers.TabIndex = 20;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(286, 92);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Assign Programmers";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AssignProgrammerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 410);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBoxProgrammers);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.buttonCancel);
            this.Name = "AssignProgrammerPage";
            this.Text = "Assign Programmer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.ListBox listBoxProgrammers;
        private System.Windows.Forms.Label labelTitle;
    }
}