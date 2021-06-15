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
    public partial class ProgrammerTaskDetailPage : Form {
        public ProgrammerTaskDetailPage(Data.TaskInfo task) {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            labelTitle.Text = task.name;
            textBoxPriority.Text = task.priority;
            textBoxDescription.Text = task.description;
            labelProject.Text += SQL.getProjectName(task.projectid);
            labelStartDate.Text += FormHelper.getDateFromDT(task.startDate);
            labelCompleteDate.Text += FormHelper.getDateFromDT(task.completeDate);

            FormHelper.centerControlHalf(this, labelTitle);
            FormHelper.centerControlHalf(this, textBoxPriority);
            FormHelper.centerControlHalf(this, textBoxDescription);
            FormHelper.centerControlHalf(this, labelProject);
            FormHelper.centerControlHalf(this, labelStartDate);
            FormHelper.centerControlHalf(this, labelCompleteDate);

            // stop textbox focus
            textBoxDescription.GotFocus += textBox_GotFocus;
            textBoxPriority.GotFocus += textBox_GotFocus;
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox_GotFocus(object sender, EventArgs e) {
            labelTitle.Focus();
        }
    }
}
