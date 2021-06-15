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
    public partial class ProgrammerHome : Form {
        Data.UserInfo userInfo;
        public ProgrammerHome(Data.UserInfo userInfo) {
            InitializeComponent();
            this.userInfo = userInfo;
            this.StartPosition = FormStartPosition.CenterParent;
            //  TODO: Too long username shorten 
            labelWelcome.Text = String.Format("Welcome {0}", userInfo.username);

            FormHelper.centerControlHalf(this, labelWelcome);

        }

        private void buttonLogout_Click(object sender, EventArgs e) {
            LoginPage loginPage = new LoginPage();
            Hide();
            loginPage.ShowDialog();
            this.Close();
        }

        private void buttonTasks_Click(object sender, EventArgs e) {
            TaskPage page = new TaskPage(-1, userInfo);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();

        }
        private void Page_FormClosed(object sender, FormClosedEventArgs e) {
            this.Show();
        }

        private void buttonIssues_Click(object sender, EventArgs e) {
            IssuesPage page = new IssuesPage(userInfo);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }

        private void buttonReport_Click(object sender, EventArgs e) {
            ReportSelectPage page = new ReportSelectPage(userInfo);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }
    }
}
