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
    public partial class AddIssuePage : Form {
        ArrayList listContent;
        Data.UserInfo userInfo;
        public AddIssuePage(ArrayList listContent, Data.UserInfo userInfo) {           
            InitializeComponent();
            this.userInfo = userInfo;
            this.StartPosition = FormStartPosition.CenterParent;
            this.listContent = listContent;
            comboBoxStatus.SelectedIndex = 0;
            comboBoxUrgency.SelectedIndex = 0;

            fillListBox(listContent, userInfo);


        }

        // Fills projectComboBox with projects associated with issues and
        // returns list of those projects
        private void fillListBox(ArrayList content, Data.UserInfo userInfo) {
            switch (userInfo.role) {
                case Data.UserInfo.MANAGER_ROLE:
                    foreach (Data.ProjectInfo project in content) {
                        listBoxContent.Items.Add(project.title);
                    }
                    break;
                case Data.UserInfo.PROGRAMMER_ROLE:
                    labelProjectTask.Text = "Task:";
                    foreach (Data.TaskInfo task in content) {
                        listBoxContent.Items.Add(task.name);
                    }
                    break;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e) {



            // if no project selected
            if (listBoxContent.SelectedIndex == -1) {
                if (userInfo.role == Data.UserInfo.PROGRAMMER_ROLE) {
                    MessageBox.Show("Please select a task");
                } else {
                    MessageBox.Show("Please select a project");
                }
                return;
            }
            Data.IssueInfo issue = null;
            switch (userInfo.role) {

                case Data.UserInfo.MANAGER_ROLE:
                    // get selected project and create issue object
                    Data.ProjectInfo project = (Data.ProjectInfo)listContent[listBoxContent.SelectedIndex];
                    issue = new Data.IssueInfo(null, textBoxDescription.Text, comboBoxUrgency.SelectedItem.ToString(),
                        comboBoxStatus.SelectedItem.ToString(), null, int.Parse(project.projectid));
                 
                    break;

                case Data.UserInfo.PROGRAMMER_ROLE:
                    Data.TaskInfo task = (Data.TaskInfo) listContent[listBoxContent.SelectedIndex];
                    issue = new Data.IssueInfo(null, textBoxDescription.Text, comboBoxUrgency.SelectedItem.ToString(),
                        comboBoxStatus.SelectedItem.ToString(), null, int.Parse(task.projectid.ToString()));
                    break;
            }
            // add issue to database
            try {
                SQL.insertIssue(issue);
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
                MessageBox.Show("Error adding issue");
                return;
            }

            this.Close();
        }
    }
}
