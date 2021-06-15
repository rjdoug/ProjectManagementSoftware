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
    
    public partial class ManagerHome : Form {
        Data.UserInfo userInfo;
        public ManagerHome(Data.UserInfo userInfo) {
            InitializeComponent();
            this.userInfo = userInfo;
            this.StartPosition = FormStartPosition.CenterParent;

            // TODO: Trim username if longer than 0123456789012345678
            labelWelcome.Text = String.Format("Welcome {0}", userInfo.username);
            FormHelper.centerControlHalf(this, labelWelcome);
        }

        private void buttonIssue_Click(object sender, EventArgs e) {
            IssuesPage page = new IssuesPage(userInfo);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }

        private void buttonProjects_Click(object sender, EventArgs e) {
            ProjectPage projectPage = new ProjectPage(userInfo);
            projectPage.FormClosed += Page_FormClosed;
            Hide();
            projectPage.ShowDialog();
        }

        // Home page is used as base to tree. So show when page closes.
        private void Page_FormClosed(object sender, FormClosedEventArgs e) {
            this.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e) {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
        }

        private void buttonReport_Click(object sender, EventArgs e) {
            ReportSelectPage page = new ReportSelectPage(userInfo);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }
    }
}
