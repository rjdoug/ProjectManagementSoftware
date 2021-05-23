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
    public partial class ProjectViewPage : Form {
        public ProjectViewPage(String username) {
            InitializeComponent();

            String projectid = "";
            String title = "";
            String startDate = "";
            String endDate = "";
            String status = "";
            String budget = "";
            String description = "";
            String customerUsername = "";

            String projectQuery = String.Format("SELECT managerUsername FROM manage WHERE " +
                "managerUsername = '{0}", username);
            labelWelcome.Text = String.Format("Welcome {0}", username);

            String query = String.Format("SELECT * FROM project JOIN manage " +
                "ON project.projectid = manage.projectid WHERE managerUsername='{0}'", username);
            SQL.selectQuery(query);

            try {
                if (SQL.read.HasRows) {

                    while (SQL.read.Read()) {
                        projectid = SQL.read[0].ToString();
                        title = SQL.read[1].ToString();
                        startDate = SQL.read[2].ToString();
                        endDate = SQL.read[3].ToString();
                        status = SQL.read[4].ToString();
                        budget = String.Format("${0}", SQL.read[5].ToString());
                        description = SQL.read[6].ToString();
                        customerUsername = SQL.read[7].ToString();

                        //listBoxProjects.Items.Add(String.Format("ProjectID: {0}, Title: {1}, Start Date: {2}" +
                        //    "End Date: {3}, Status: {4}, Budget: {5}, Description: {6}, Customer: {7}",
                        //    projectid, title, startDate, endDate, status, budget, description, customerUsername));

                        // Can't fit everything in the width of the listbox. I would assume there would be a title and
                        // a small bit of info, then when selected it takes you to a page with more details
                        listBoxProjects.Items.Add(String.Format("Title: {0}, Status: {1}, Customer: {2}",
                        title, status, customerUsername));
                    }

                } else {
                    listBoxProjects.Items.Add(String.Format("No projects found for {0}", username));
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
              

        }

        private void buttonLogout_Click(object sender, EventArgs e) {
            this.Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
            this.Close();
        }
    }
}
