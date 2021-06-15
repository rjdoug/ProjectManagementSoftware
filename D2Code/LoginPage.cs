using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2Code {
    //Name: Riley Douglas
    //Student ID: 1514099

    public partial class LoginPage : Form {
        // comboBox indexes
        const int PROGRAMMER = 0;
        const int MANAGER = 1;

        /// <summary>
        /// This is the first method called when the program form loads.
        /// </summary>
        public LoginPage() {
            InitializeComponent();
            //This line of code allows us to obscure the password visually and limit the max chars in textbox
            textBoxPassword.PasswordChar = '*';     //password character to hide password characters
            textBoxPassword.MaxLength = 20;         //max textbox character count
            comboBoxRole.SelectedIndex = 0;

            FormHelper.centerControlHalf(this, labelTitle);
            FormHelper.centerControlHalf(this, labelUsername);
            FormHelper.centerControlHalf(this, textBoxUserName);
            FormHelper.centerControlHalf(this, labelPassword);
            FormHelper.centerControlHalf(this, textBoxPassword);
            FormHelper.centerControlHalf(this, labelRole);
            FormHelper.centerControlHalf(this, comboBoxRole);
            FormHelper.centerControlHalf(this, buttonLogin);
            FormHelper.centerControlHalf(this, buttonClearAll);
        }


        /// <summary>
        /// Clicked when user decides they are ready to log in, 
        /// Will get username and password, use that to query database and check that username and password are correct.
        /// A message box will be used to state whether or not we logged in successfully
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        

        private Boolean isEmptyInput() {
            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(textBoxUserName.Text.Trim()) || "".Equals(textBoxPassword.Text.Trim())) {
                MessageBox.Show("Please enter a Username and Password");
                return true;
            }
            return false;
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            // hold userInfo
            Data.UserInfo userInfo = new Data.UserInfo();

            if (isEmptyInput()) return;

            // get username and password from the text boxes
            try {
                userInfo.username = textBoxUserName.Text.Trim();
                userInfo.password = textBoxPassword.Text.Trim();
            } catch {
                MessageBox.Show("Username or Password given is in an incorrect format.");
                return;
            }

            userInfo.role = comboBoxRole.SelectedIndex;
            // query managers for username
            SQL.selectEmployee(userInfo.role, userInfo.username);

            Boolean loggedIn = false;

            // Check if table was returned -- Info has to be in first and only row as we used primary key to query
            try {

                if (SQL.read.HasRows) {
                    // read row
                    SQL.read.Read();
                    // check if combination exists
                    if (passwordMatches(userInfo)) {
                        // fill in other credentials
                        loggedIn = true;
                        fillRemainingCredentials(userInfo);
                        // Change window
                        Hide();

                        Form homePage;
                        switch (userInfo.role) {
                            case 0:
                                homePage = new ProgrammerHome(userInfo);
                                break;
                            case 1:
                                homePage = new ManagerHome(userInfo);
                                break;
                            default:
                                throw new ArgumentNullException("No Role for user");
                        }
                        // open project view
                        homePage.ShowDialog();
                        this.Close();
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }

            // wrong combination
            if (!loggedIn) {
                MessageBox.Show("Username and Password combination incorrect");
                textBoxUserName.Focus();
                return;
            }
        }
        // Fills the remaining credentials of the user given that username and password checks out
        private void fillRemainingCredentials(Data.UserInfo user) {
            user.firstName = SQL.read[2].ToString();
            user.lastName = SQL.read[3].ToString();
        }

        // returns true if username and password exists
        private Boolean passwordMatches(Data.UserInfo user) {
            return user.password.Equals(SQL.read[1].ToString());
        } 
        /// <summary>
        /// Clears the text boxes on the page focuses on top one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearAll_Click(object sender, EventArgs e) {
            initialiseTextBoxes();
        }

        /// <summary>
        /// Initialises all textboxes to blank text
        /// Re focus to first text box
        /// </summary>
        public void initialiseTextBoxes() {
            //goes through and clears all of the textboxes
            foreach (Control c in this.Controls) {
                if (c is TextBox) {
                    (c as TextBox).Clear();
                }
            }
            //makes next place user types the text box
            textBoxUserName.Focus();
        }
    }
}