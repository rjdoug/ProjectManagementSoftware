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
    public partial class IssueDetailsPage : Form {
        Data.IssueInfo issue;
        public IssueDetailsPage(Data.IssueInfo issueInfo, String projectName, Data.UserInfo userInfo) {
            InitializeComponent();
            issue = issueInfo;
            this.StartPosition = FormStartPosition.CenterParent;
            labelTitle.Text += issue.issueid;
            labelReportDate.Text += FormHelper.getDateFromDT(issue.reportDate);
            labelProject.Text += projectName;
            fillMaluableData();
            // stop focus of textbox
            textBoxDescription.GotFocus += textBox_GotFocus;
            textBoxStatus.GotFocus += textBox_GotFocus;
            textBoxUrgency.GotFocus += textBox_GotFocus;

            FormHelper.centerControlHalf(this, labelTitle);
            FormHelper.centerControlHalf(this, textBoxUrgency);
            FormHelper.centerControlHalf(this, textBoxStatus);
            FormHelper.centerControlHalf(this, textBoxDescription);
            FormHelper.centerControlHalf(this, labelReportDate);
            FormHelper.centerControlHalf(this, labelProject);

           if (userInfo.role == Data.UserInfo.PROGRAMMER_ROLE) {
                buttonUpdate.Hide();
                buttonUpdate.Enabled = false;
                FormHelper.centerControlHalf(this, buttonBack);
            }
        }

        private void reloadIssue() {
            SQL.getIssueOnID(issue.issueid);
            try {
                if (SQL.read.HasRows) {
                    SQL.read.Read();
                    issue = new Data.IssueInfo(SQL.read[0].ToString(), SQL.read[1].ToString(), SQL.read[3].ToString(), SQL.read[4].ToString(),
                        SQL.read[2].ToString(), int.Parse(SQL.read[5].ToString()));

                }
            } catch (Exception ex) {
            Console.WriteLine(ex);
            Console.WriteLine(ex.StackTrace);
            }fillMaluableData();
            
        }

        private void fillMaluableData() {
            textBoxUrgency.Text = issue.urgency;
            textBoxStatus.Text = issue.status;
            textBoxDescription.Text = issue.description;
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox_GotFocus(object send, EventArgs e) {
            labelTitle.Focus();
        }

        private void buttonUpdate_Click(object sender, EventArgs e) {
            if (issue.status.Equals("Completed")) {
                MessageBox.Show("Cannot update a closed issue");
                return;
            }
            IssueUpdatePage page = new IssueUpdatePage(issue);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }

        private void Page_FormClosed(object sender, FormClosedEventArgs e) {
            reloadIssue();
            this.Show();
        }
    }
}
