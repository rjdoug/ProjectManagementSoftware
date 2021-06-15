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
    public partial class TaskDetailPage : Form {
        ArrayList progressArr;
        ArrayList programmers;
        Data.TaskInfo task;
        public TaskDetailPage(Data.TaskInfo task, Data.UserInfo user) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.task = task;

            compute();
           
        }

        private void compute() {
            
            

            labelTitle.Text = task.name;
            textBoxPriority.Text = task.priority;
            textBoxDescription.Text = task.description;

            labelProject.Text = "Project: "+ SQL.getProjectName(task.projectid);
            labelStartDate.Text = "StartDate: " + FormHelper.getDateFromDT(task.startDate);
            labelCompleteDate.Text = "CompleteDate: " + FormHelper.getDateFromDT(task.completeDate);

            // Center end of Quartile 1
            FormHelper.centerControlHalf(this, labelTitle);
            FormHelper.centerControlQ1(this, textBoxPriority);
            FormHelper.centerControlQ1(this, labelDescription);
            FormHelper.centerControlQ1(this, textBoxDescription);
            FormHelper.centerControlQ1(this, labelProject);
            FormHelper.centerControlQ1(this, labelStartDate);
            FormHelper.centerControlQ1(this, labelCompleteDate);

            // Center end of Quartile 3
            FormHelper.centerControlQ3(this, labelProgress);
            FormHelper.centerControlQ3(this, listBoxProgress);
            FormHelper.centerControlQ3(this, labelProgrammers);
            FormHelper.centerControlQ3(this, listBoxProgrammers);

            // Stop textbox focus
            textBoxDescription.GotFocus += textBox_GotFocus;
            textBoxPriority.GotFocus += textBox_GotFocus;


            processProgress();
            processProgrammers();
            setPriorityColor();
        }

        private void reloadTask() {
            SQL.getTaskOnID(task.taskid);
            try {
                if (SQL.read.HasRows) {
                    SQL.read.Read();
                    task = new Data.TaskInfo(SQL.read[0].ToString(), SQL.read[1].ToString(), SQL.read[2].ToString(), SQL.read[3].ToString(),
                        SQL.read[4].ToString(), SQL.read[5].ToString(), int.Parse(SQL.read[6].ToString()));

                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
            }
            
        }

        private void setPriorityColor() {
            switch (task.priority.ToLower()) {
                case "low":
                    textBoxPriority.BackColor = Color.Green;
                    break;

                case "moderate":
                    textBoxPriority.BackColor = Color.Orange;
                    break;

                default:
                    textBoxPriority.BackColor = Color.Red;
                    break;
            }
        }

        private void textBox_GotFocus(object sender, EventArgs e) {
            labelTitle.Focus();
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void processProgrammers() {
            SQL.getProgrammersOnTask(int.Parse(task.taskid));
            programmers = new ArrayList();
            try {
                if (SQL.read.HasRows) {
                    while (SQL.read.Read()) {
                        String programmer = SQL.read[0].ToString();
                        programmers.Add(programmer);
                        listBoxProgrammers.Items.Add(programmer);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void processProgress() {
            SQL.selectProgressByTask(int.Parse(task.taskid));
            progressArr = new ArrayList();
            try {
                if (SQL.read.HasRows) {
                    while (SQL.read.Read()) {
                        Data.ProgressInfo progress = new Data.ProgressInfo(SQL.read[0].ToString(), SQL.read[1].ToString(), SQL.read[2].ToString(),
                            int.Parse(SQL.read[3].ToString()));
                        progressArr.Add(progress);

                        // add to listbox
                        listBoxProgress.Items.Add(String.Format("Date: {0} - {1}", FormHelper.getDateFromDT(progress.reportDate), progress.description));
                    }
                } else {
                    listBoxProgress.Items.Add(String.Format("No progress..."));
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void buttonAddProgrammer_Click(object sender, EventArgs e) {

            AssignProgrammerPage page = new AssignProgrammerPage(programmers, int.Parse(task.taskid));
            page.FormClosed += Page_FormClosed;
            page.ShowDialog();
        }

        private void Page_FormClosed(object sender, FormClosedEventArgs e) {
            reloadTask();
            listBoxProgrammers.Items.Clear();
            listBoxProgress.Items.Clear();
            compute();
            this.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e) {
            UpdateTaskPage page = new UpdateTaskPage(task);
            page.FormClosed += Page_FormClosed;
            Hide();
            page.ShowDialog();
        }
    }
}
