using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2Code {
    public partial class IssueUpdatePage : Form {
        Data.IssueInfo issue;
        public IssueUpdatePage(Data.IssueInfo issue) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            comboBoxUrgency.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
            this.issue = issue;
            
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e) {
            String urgency = comboBoxUrgency.SelectedItem.ToString();
            String status = comboBoxStatus.SelectedItem.ToString();
            String description = textBoxDescription.Text;

            SQL.updateIssue(description, urgency, status, issue.issueid);

            this.Close();

        }
    }
}
