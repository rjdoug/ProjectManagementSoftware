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
    public partial class ProgressPage : Form {
        ArrayList progress;
        int taskid;
        public ProgressPage(int taskid) {
            InitializeComponent();
            this.taskid = taskid;
            this.StartPosition = FormStartPosition.CenterParent;
            listBoxProgress.HorizontalScrollbar = true;

            populateProgressList(taskid);

        }

        private void populateProgressList(int taskid) {
            listBoxProgress.Items.Clear();
            progress = new ArrayList();
            SQL.selectProgressByTask(taskid);
            try {
                if (SQL.read.HasRows) {

                    while (SQL.read.Read()) {
                        // Create taskInfo object and add to arrayList
                        Data.ProgressInfo progressInfo = new Data.ProgressInfo(SQL.read[0].ToString(), SQL.read[1].ToString(), SQL.read[2].ToString(),
                            int.Parse(SQL.read[3].ToString()));
                        progress.Add(progressInfo);

                        // add to list box
                        listBoxProgress.Items.Add(String.Format("Date: {0} | Description: {1}",
                        FormHelper.getDateFromDT(progressInfo.reportDate), progressInfo.description));
                    }

                } else {
                    listBoxProgress.Items.Add(String.Format("No progress found..."));
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonAddTask_Click(object sender, EventArgs e) {
            AddProgressPage page = new AddProgressPage(taskid);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }

        private void Page_FormClosed(object sender, FormClosedEventArgs e) {
            this.Show();
            populateProgressList(taskid);
            
        }
    }
}
