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
    public partial class UpdateTaskPage : Form {
        Data.TaskInfo task;
        public UpdateTaskPage(Data.TaskInfo task) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.task = task;
            comboBoxPriority.SelectedIndex = 0;
            dtpCompleteDate.Value = DateTime.Now;
        }

        private void buttonConfirm_Click(object sender, EventArgs e) {
            if (dtpCompleteDate.Value < Convert.ToDateTime(task.startDate)) {
                MessageBox.Show("Complete date cannot be set before the start date");
                return;
            }
            string date;
            if (dtpCompleteDate.Checked) {
                date = FormHelper.getDateFromDT(dtpCompleteDate.Value.ToString());
            } else {
                date = task.completeDate;
            }
           
            String priority = comboBoxPriority.SelectedItem.ToString();
            String description = textBoxDescription.Text;

            SQL.updateTask(description, priority, date, task.taskid);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
