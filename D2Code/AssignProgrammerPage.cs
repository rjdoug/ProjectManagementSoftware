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
    public partial class AssignProgrammerPage : Form {
        int taskid;
        public AssignProgrammerPage(ArrayList programmers, int taskid) {
            InitializeComponent();
            this.taskid = taskid;
            this.StartPosition = FormStartPosition.CenterParent;
            FormHelper.centerControlHalf(this, labelTitle);
            FormHelper.centerControlHalf(this, listBoxProgrammers);
            FormHelper.centerControlHalf(this, buttonAssign);
            FormHelper.centerControlHalf(this, buttonCancel);

            SQL.getAllProgrammers();

            try {
                if (SQL.read.HasRows) {
                    while (SQL.read.Read()) {
                        String programmerUsername = SQL.read[0].ToString();
                        Boolean exists = false;
                        foreach (String programmer in programmers) {
                            if (programmer.Equals(programmerUsername)) 
                                exists = true;
                        }
                        if (exists) continue;
                        listBoxProgrammers.Items.Add(programmerUsername);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonAssign_Click(object sender, EventArgs e) {
            if (listBoxProgrammers.Items.Count == 0) {
                MessageBox.Show("All programmers have been assigned");
                return;
            }

            if (listBoxProgrammers.SelectedIndex == -1) {
                MessageBox.Show("Please select a programmer");
                return;
            }
            
            String selectedUsername = listBoxProgrammers.SelectedItem.ToString();
            // error handle - nothing selected
            if (selectedUsername.Equals(""))
                return;

            SQL.insertWorksOn(taskid, selectedUsername);
            
            this.Close();
        }
    }
}
