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
    //Name: Riley Douglas
    //Student ID: 1514099

    public partial class LoginPage : Form {
        /// <summary>
        /// This is the first method called when the program form loads.
        /// </summary>
        public LoginPage() {
            InitializeComponent();
            //This line of code allows us to obscure the password visually and limit the max chars in textbox
            textBoxPassword.PasswordChar = '*';     //password character to hide password characters
            textBoxPassword.MaxLength = 20;         //max textbox character count
        }


        /// <summary>
        /// Clicked when user decides they are ready to log in, 
        /// Will get username and password, use that to query database and check that username and password are correct.
        /// A message box will be used to state whether or not we logged in successfully
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e) {
            //Variables to be used: 1x bool, 4x string
            bool loggedIn = false;
            string username = "", firstname = "", lastname = "", password = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(textBoxUserName.Text.Trim()) || "".Equals(textBoxPassword.Text.Trim())) {
                MessageBox.Show("Please enter a Username and Password");
                return;
            }

            // GET the username and password from the text boxes, is good to put them in a try catch
            try {
                username = textBoxUserName.Text.Trim();
                password = textBoxPassword.Text.Trim();
            } catch {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format.");
                return;
            }

            // SELECT statement getting all data from users, i.e. SELECT * FROM Users
            SQL.selectQuery("SELECT * FROM manager");

            //(3) IF it returns some data, THEN check each username and password combination, ELSE There are no
            //registered users
            // if a row exists
            if (SQL.read.HasRows) {
                // read rows
                while (SQL.read.Read()) {
                    // check if combination exists
                    if (username.Equals(SQL.read[0].ToString()) &&
                        password.Equals(SQL.read[1].ToString())) {

                        // correct combination, fill in other credentials
                        loggedIn = true;
                        firstname = SQL.read[2].ToString();
                        lastname = SQL.read[3].ToString();
                        Hide();
                        ProjectViewPage browsePage = new ProjectViewPage(username);
                        browsePage.ShowDialog();
                        Close();
                        break;
                    }
                }
            } else {
                MessageBox.Show("Username and Password combination incorrect");
                return;
            }


            if (!loggedIn) {
                //message stating we couldn't log in
                MessageBox.Show("Login attempt unsuccessful! Please check details");
                textBoxUserName.Focus();
                return;
            }
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
