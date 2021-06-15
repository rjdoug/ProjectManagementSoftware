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
    public partial class ReportDetailPage : Form {
        public ReportDetailPage(Data.ProjectInfo project) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            int projectid = int.Parse(project.projectid);
            labelTitle.Text = project.title;
            FormHelper.centerControlHalf(this, labelTitle);

            labelTaskCompleteCount.Text += getCompletedTasks(projectid);
            FormHelper.centerControlHalf(this, labelTaskCompleteCount);

            labelTaskIncompleteCount.Text += getIncompleteTasks(projectid);
            FormHelper.centerControlHalf(this, labelTaskIncompleteCount);

            labelTaskCount.Text += getTotalTasks(projectid);
            FormHelper.centerControlHalf(this, labelTaskCount);

            labelProgrammerCount.Text += getTotalProgrammers(projectid);
            FormHelper.centerControlHalf(this, labelProgrammerCount);

            labelIssueCount.Text += getTotalIssues(projectid);
            FormHelper.centerControlHalf(this, labelIssueCount);

            labelClosedIssues.Text += getTotalClosedIssues(projectid);
            FormHelper.centerControlHalf(this, labelClosedIssues);

            labelOpenIssues.Text += getTotalOpenIssues(projectid);
            FormHelper.centerControlHalf(this, labelOpenIssues);

            FormHelper.centerControlHalf(this, buttonBack);
        }

        // ------------------------------------------------
        // --                 QUERIES                    --
        //-------------------------------------------------
        private String getCompletedTasks(int projectid) {
            SQL.getProjectsCompletedTasks(projectid);
            return readColumn1Line1();

        }

        private String getIncompleteTasks(int projectid) {
            SQL.getProjectsIncompleteTasks(projectid);
            return readColumn1Line1();
        }

        private String getTotalTasks(int projectid) {
            SQL.getProjectsTotalTasks(projectid);
            return readColumn1Line1();
        }

        private String getTotalProgrammers(int projectid) {
            SQL.getProjectsTotalProgrammers(projectid);
            return readColumn1Line1();
        }

        private String getTotalIssues(int projectid) {
            SQL.getProjectsTotalIssues(projectid);
            return readColumn1Line1();
        }

        private String getTotalClosedIssues(int projectid) {
            SQL.getProjectsTotalClosedIssues(projectid);
            return readColumn1Line1();
        }

        private String getTotalOpenIssues(int projectid) {
            SQL.getProjectsTotalOpenIssues(projectid);
            return readColumn1Line1();
        }

        private String readColumn1Line1() {
            try {
                if (SQL.read.HasRows) {

                    SQL.read.Read();
                    return SQL.read[0].ToString();
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
            return "";
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
