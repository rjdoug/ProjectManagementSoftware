using System;
using System.Collections;
using System.Windows.Forms;

namespace D2Code {

    public partial class ProjectPage : Form {

        ArrayList projects;
        Data.UserInfo userInfo;

        public ProjectPage(Data.UserInfo userInfo) {
            InitializeComponent();
            this.userInfo = userInfo;
            this.StartPosition = FormStartPosition.CenterParent;
            listBoxProjects.HorizontalScrollbar = true;

            FormHelper.centerControlHalf(this, labelProjects);




            // Get managers projects
            String query = String.Format("SELECT * FROM project JOIN manage " +
                "ON project.projectid = manage.projectid WHERE managerUsername = '{0}' ORDER BY status desc", userInfo.username);
            SQL.selectQuery(query);



            projects = new ArrayList();
            try {
                if (SQL.read.HasRows) {

                    while (SQL.read.Read()) {
                        // Create projectInfo object and add to arrayList
                        Data.ProjectInfo project = new Data.ProjectInfo(SQL.read[0].ToString(), SQL.read[1].ToString(), SQL.read[2].ToString(),
                            SQL.read[3].ToString(), SQL.read[4].ToString(), SQL.read[5].ToString(), SQL.read[6].ToString(),
                            SQL.read[7].ToString());
                        projects.Add(project);

                        // add to list box
                        listBoxProjects.Items.Add(String.Format("Title: {0} | Status: {1}",
                        project.title, project.status));
                    }

                } else {
                    listBoxProjects.Items.Add(String.Format("No projects found for {0}", userInfo.username));
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }


        }

        private void buttonLogout_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
            
            int projectIndex = listBoxProjects.SelectedIndex;
            if (projectIndex == -1) {
                MessageBox.Show("Please select a project");
                return;
            }
            Data.ProjectInfo project = (Data.ProjectInfo)projects[projectIndex];

            ProjectDetailPage page = new ProjectDetailPage(project);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }

        private void Page_FormClosed(object sender, FormClosedEventArgs e) {
            this.Show();
        }
        // Show tasks of the selected project
        private void buttonViewTasks_Click(object sender, EventArgs e) {
            int projectIndex = listBoxProjects.SelectedIndex;
            if (projectIndex == -1) {
                MessageBox.Show("Please select a project");
                return;
            }
                
            Data.ProjectInfo project = (Data.ProjectInfo)projects[projectIndex];
            TaskPage page = new TaskPage(int.Parse(project.projectid), userInfo);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }
    }
}
