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
    public partial class AddTaskPage : Form {
        int projectid;
        public AddTaskPage(int projectid) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.projectid = projectid;
            comboBoxPriority.SelectedIndex = 0;
            dtpCompleteDate.Value = DateTime.Now;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e) {
            if (!isInput()) return;
            
            
            // Get user input
            String name = textBoxName.Text.Trim();
            String completeDate;
            completeDate = dtpCompleteDate.Checked ? dtpCompleteDate.Text : null;
            if (completeDate != null && DateTime.Today.Date > dtpCompleteDate.Value.Date) {
                MessageBox.Show("Can't set complete date before today");
                return;
            }
            String priority = comboBoxPriority.SelectedItem.ToString();
            String description = textBoxDescription.Text;

            // create task object
            Data.TaskInfo task = new Data.TaskInfo(null, name, description, priority, null,
                completeDate, projectid);

            SQL.insertTask(task);

            this.Close();



        }

        // Checks if Name and Description have input
        private Boolean isInput() {
            String name = textBoxName.Text.Trim();
            String description = textBoxDescription.Text.Trim();
            if (name.Equals("") || description.Equals("")) {
                MessageBox.Show("Please fill 'Name' and 'Description'");
                return false;
            }
            return true;
            
        }
    }
}
