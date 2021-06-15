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
    public partial class TaskPage : Form {
        ArrayList tasks;
        int projectidPass;
        Data.UserInfo userInfo;
        public TaskPage(int projectid, Data.UserInfo userInfo) {
            InitializeComponent();
            projectidPass = projectid;
            this.userInfo = userInfo;

            this.StartPosition = FormStartPosition.CenterParent;
            listBoxTasks.HorizontalScrollbar = true;
     
            handleUserRole(userInfo);
            

        }

        private void handleUserRole(Data.UserInfo userInfo) {
            listBoxTasks.Items.Clear();
            switch (userInfo.role) {
                case Data.UserInfo.MANAGER_ROLE:
                    SQL.selectTasksOnProjectid(projectidPass);
                    break;
                case Data.UserInfo.PROGRAMMER_ROLE:
                    SQL.getProgrammersTasks(userInfo.username);
                    buttonAddTask.Text = "View Progress"; 
                    break;
            }
            readInTasks();
        }

        private void readInTasks() {
            tasks = new ArrayList();
            try {
                if (SQL.read.HasRows) {

                    while (SQL.read.Read()) {
                        // Create taskInfo object and add to arrayList
                        Data.TaskInfo task = new Data.TaskInfo(SQL.read[0].ToString(), SQL.read[1].ToString(), SQL.read[2].ToString(),
                            SQL.read[3].ToString(), SQL.read[4].ToString(), SQL.read[5].ToString(), int.Parse(SQL.read[6].ToString()));
                        tasks.Add(task);

                        // add to list box
                        listBoxTasks.Items.Add(String.Format("Name: {0} | Priority: {1}",
                        task.name, task.priority));
                    }

                } else {
                    listBoxTasks.Items.Add(String.Format("No tasks found..."));
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonMiddle_Click(object sender, EventArgs e) {
            Form page = null;
            switch (userInfo.role) {    
                case Data.UserInfo.MANAGER_ROLE:
                    page = new AddTaskPage(projectidPass);
                    page.FormClosed += Page_FormClosed;
                    Hide();
                    page.ShowDialog();
                    break;
                // View progress
                case Data.UserInfo.PROGRAMMER_ROLE:
                    if (listBoxTasks.SelectedIndex == -1) {
                        MessageBox.Show("Please select a task");
                        return;
                    }
                    Data.TaskInfo task = (Data.TaskInfo) tasks[listBoxTasks.SelectedIndex];
                    page = new ProgressPage(int.Parse(task.taskid));
                    page.FormClosed += Page_FormClosed;
                    Hide();
                    page.ShowDialog();
                    break;
            }

        }

        private void Page_FormClosed(object sender, FormClosedEventArgs e) {
            handleUserRole(userInfo);
            this.Show();
            
        }

        private void buttonSelect_Click(object sender, EventArgs e) {           
            int taskIndex = listBoxTasks.SelectedIndex;

            if (tasks.Count == 0 || taskIndex== -1) {
                MessageBox.Show("Please select a task");
                return;
            }

            Data.TaskInfo task = (Data.TaskInfo)tasks[taskIndex];

            Form page = null;
            switch (userInfo.role) {
                case Data.UserInfo.MANAGER_ROLE:
                    page = new TaskDetailPage(task, userInfo);
                    page.FormClosed += Page_FormClosed;
                    Hide();
                    page.ShowDialog();
                    break;
                // View progress
                case Data.UserInfo.PROGRAMMER_ROLE:
                    page = new ProgrammerTaskDetailPage(task);
                    page.FormClosed += Page_FormClosed;
                    Hide();
                    page.ShowDialog();
                    break;
            }

        }




    }
}
