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
    public partial class ProjectDetailPage : Form {
        public ProjectDetailPage(Data.ProjectInfo projectInfo) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            labelTitle.Text = projectInfo.title;
            textBoxStatus.Text = projectInfo.status;
            textBoxDescription.Text = projectInfo.description;
            // Remove time from start date
            String[] startDateTokens = projectInfo.startDate.Split(' ');
            labelStartDate.Text = String.Format("Start Date: {0}", startDateTokens[0]);
            // Remove time from start date
            String[] endDateTokens = projectInfo.endDate.Split(' ');
            labelEndDate.Text = String.Format("End Date: {0}", endDateTokens[0]);
            labelBudget.Text = String.Format("Budget: ${0}", projectInfo.budget);
            labelCustomer.Text = String.Format("Customer: {0}", projectInfo.customerUsername);

            // attatch event listener to remove focus from textboxes when clicked
            textBoxStatus.GotFocus += textBox_GotFocus;
            textBoxDescription.GotFocus += textBox_GotFocus;

            FormHelper.centerControlHalf(this, labelTitle);
            FormHelper.centerControlHalf(this, textBoxStatus);
            FormHelper.centerControlHalf(this, textBoxDescription);
            FormHelper.centerControlHalf(this, labelStartDate);
            FormHelper.centerControlHalf(this, labelEndDate);
            FormHelper.centerControlHalf(this, labelBudget);
            FormHelper.centerControlHalf(this, labelCustomer);
            FormHelper.centerControlHalf(this, buttonBack);
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox_GotFocus(object sender, EventArgs e) {
            labelTitle.Focus();
        }
    }
}
