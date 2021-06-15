using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2Code {
    public partial class IssuesPage : Form {

        ArrayList issues;
        Data.UserInfo userInfo;
        String projectName;
        public IssuesPage(Data.UserInfo userInfo) {
            InitializeComponent();
            this.userInfo = userInfo;

            this.StartPosition = FormStartPosition.CenterParent;
            listBoxIssues.HorizontalScrollbar = true;

            FormHelper.centerControlHalf(this, labelIssues);

            handleUserRole();
            

        }

        private void handleUserRole() {
            listBoxIssues.Items.Clear();
            issues = new ArrayList();
            switch (userInfo.role) {
                case Data.UserInfo.MANAGER_ROLE:
                    processManagerIssues();
                    break;
                case Data.UserInfo.PROGRAMMER_ROLE:
                    processProgrammerIssues();
                    break;
            }
        }

        // gets all issues for manager and populates listBox
        private void processManagerIssues() {
            SQL.getManagerIssues(userInfo.username);
            try {

                if (SQL.read.HasRows) {

                    while (SQL.read.Read()) {
                        // Create projectInfo object and add to arrayList
                        Data.IssueInfo issue = new Data.IssueInfo(SQL.read[10].ToString(), SQL.read[11].ToString(), SQL.read[13].ToString(), SQL.read[14].ToString(),
                            SQL.read[12].ToString(), int.Parse(SQL.read[15].ToString()));
                        issues.Add(issue);

                        projectName = SQL.read[1].ToString();
                        // add to list box
                        listBoxIssues.Items.Add(String.Format("Project: {0} | Description: {1} | Status: {2}",
                        projectName, issue.description, issue.status));


                    }

                } else {
                    listBoxIssues.Items.Add(String.Format("No issues found for {0}", userInfo.username));
                }

            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void processProgrammerIssues() {
            SQL.getProgrammersIssues(userInfo.username);
            try {
                if (SQL.read.HasRows) {
                    while (SQL.read.Read()) {
                        // Create projectInfo object and add to arrayList
                        Data.IssueInfo issue = new Data.IssueInfo(SQL.read[0].ToString(), SQL.read[3].ToString(), SQL.read[5].ToString(), SQL.read[6].ToString(),
                            SQL.read[4].ToString(), int.Parse(SQL.read[1].ToString()));
                        issues.Add(issue);

                        projectName = SQL.read[2].ToString();
                        // add to list box
                        listBoxIssues.Items.Add(String.Format("Project: {0} | Description: {1} | Status: {2}",
                        projectName, issue.description, issue.status));
                    }

                } else {
                    listBoxIssues.Items.Add(String.Format("No issues found for {0}", userInfo.username));
                }

            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private ArrayList getProjectAssc() {
            // can either be tasks or projects depending on whether user is programmer or manager
            ArrayList associationList = null;
            switch (userInfo.role) {
                case Data.UserInfo.MANAGER_ROLE:
                    
                    associationList = getManagerProjectAssc();
                    break;
                case Data.UserInfo.PROGRAMMER_ROLE:
                    associationList = getProgrammerTaskAssc();
                    break;
            }
            return associationList;
        }

        // returns a list of projects that the logged in manager is associated with
        private ArrayList getManagerProjectAssc() {
            ArrayList projects = new ArrayList();
            SQL.getManagerProjectAssc(userInfo.username);

            try {
                if (SQL.read.HasRows) {
                    while (SQL.read.Read()) {
                        // Create taskInfo object and add to arrayList
                        Data.ProjectInfo project = new Data.ProjectInfo(SQL.read[2].ToString(), SQL.read[3].ToString(), SQL.read[4].ToString(),
                            SQL.read[5].ToString(), SQL.read[6].ToString(), SQL.read[7].ToString(), SQL.read[8].ToString(), SQL.read[9].ToString());
                        projects.Add(project);
                    }
                } 
                } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
                return null;
                }
            return projects;

        }

        private ArrayList getProgrammerTaskAssc() {
            ArrayList tasks = new ArrayList();
            SQL.getProgrammersTasks(userInfo.username);

            try {
                if (SQL.read.HasRows) {
                    while (SQL.read.Read()) {
                        // Add task to association list to be passed to a
                        Data.TaskInfo task = new Data.TaskInfo(SQL.read[0].ToString(), SQL.read[1].ToString(), SQL.read[2].ToString(), SQL.read[3].ToString(),
                            SQL.read[4].ToString(), SQL.read[5].ToString(), int.Parse(SQL.read[6].ToString()));
                        tasks.Add(task);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
                return null;
            }
            return tasks;
        }

        private String getProjectName(Data.IssueInfo issue) {
            SQL.getProjectFromIssueID(issue.issueid);
            String projectName = null;
            try {
                if (SQL.read.HasRows) {
                    SQL.read.Read();
                    projectName = SQL.read[1].ToString();
                } else throw new Exception("No issue id");

            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
                return null;
            }
            return projectName;
        }

        private void buttonDetails_Click(object sender, EventArgs e) {
            int issueIndex = listBoxIssues.SelectedIndex;

            if (issueIndex == -1) {
                MessageBox.Show("Please select an issue");
                return;
            }

            Data.IssueInfo issue = (Data.IssueInfo)issues[issueIndex];
            IssueDetailsPage page = new IssueDetailsPage(issue, getProjectName(issue), userInfo);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }

        private void Page_FormClosed(object sender, FormClosedEventArgs e) {
            handleUserRole();
            this.Show();
        }

        private void buttonAddIssue_Click(object sender, EventArgs e) {

            AddIssuePage page = new AddIssuePage(getProjectAssc(), userInfo);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

