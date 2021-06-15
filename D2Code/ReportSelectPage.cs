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
    public partial class ReportSelectPage : Form {
        ArrayList projects;
        public ReportSelectPage(Data.UserInfo userInfo) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            listBoxProjects.HorizontalScrollbar = true;

            FormHelper.centerControlHalf(this, listBoxProjects);
            FormHelper.centerControlHalf(this, labelTitle);


            projects = new ArrayList();
            switch (userInfo.role) {
                case Data.UserInfo.MANAGER_ROLE:
                    SQL.getManagerProjectAssc(userInfo.username);
                    fillProjectListManager(userInfo);
                    break;

                case Data.UserInfo.PROGRAMMER_ROLE:
                    SQL.getProjectsForProgrammer(userInfo.username);
                    fillProjectListProgrammer(userInfo);
                    break;
            }

        }

        private void fillProjectListManager(Data.UserInfo userInfo) {
            try {
                if (SQL.read.HasRows) {

                    while (SQL.read.Read()) {
                        // Create projectInfo object and add to arrayList
                        Data.ProjectInfo project = new Data.ProjectInfo(SQL.read[2].ToString(), SQL.read[3].ToString(), SQL.read[4].ToString(),
                            SQL.read[5].ToString(), SQL.read[6].ToString(), SQL.read[7].ToString(), SQL.read[8].ToString(),
                            SQL.read[9].ToString());
                        projects.Add(project);

                        // add to list box
                        listBoxProjects.Items.Add(String.Format("Title: {0}",
                        project.title));
                    }

                } else {
                    listBoxProjects.Items.Add(String.Format("No projects found for {0}", userInfo.username));
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        private void fillProjectListProgrammer(Data.UserInfo userInfo) {
            try {
                if (SQL.read.HasRows) {

                    while (SQL.read.Read()) {
                        // Create projectInfo object and add to arrayList
                        Data.ProjectInfo project = new Data.ProjectInfo(SQL.read[0].ToString(), SQL.read[1].ToString(), SQL.read[2].ToString(),
                            SQL.read[3].ToString(), SQL.read[4].ToString(), SQL.read[5].ToString(), SQL.read[6].ToString(),
                            SQL.read[7].ToString());
                        projects.Add(project);

                        // add to list box
                        listBoxProjects.Items.Add(String.Format("Title: {0}",
                        project.title));
                    }

                } else {
                    listBoxProjects.Items.Add(String.Format("No projects found for {0}", userInfo.username));
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
            int projectIndex = listBoxProjects.SelectedIndex;

            if (projectIndex == -1) {
                MessageBox.Show("Please select a project");
                return;
            }

            Data.ProjectInfo project = (Data.ProjectInfo)projects[projectIndex];
            ReportDetailPage page = new ReportDetailPage(project);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }

        private void Page_FormClosed(object sender, FormClosedEventArgs e) {
            this.Show();
        }
    }
    
}
