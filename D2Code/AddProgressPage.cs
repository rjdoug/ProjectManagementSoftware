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
    public partial class AddProgressPage : Form {
        int taskid;
        public AddProgressPage(int taskid) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.taskid = taskid;

        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e) {
            if (textBoxDescription.Text.Equals("")) {
                MessageBox.Show("Please enter a description");
                return;
            }
            Data.ProgressInfo progress = new Data.ProgressInfo(null, textBoxDescription.Text, null, taskid);

            // add progress to database
            try {
                SQL.insertProgress(progress);
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
                MessageBox.Show("Error adding progress");
                return;
            }
            this.Close();
        }
    }
}
