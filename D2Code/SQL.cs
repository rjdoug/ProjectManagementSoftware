using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace D2Code {
    public class SQL {
        //generates the connection to the database       
        //Make sure that in the Database connection you put your Database connection here:
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RNU4RRM\SQLEXPRESS;Database=D2;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader read;

        /// <summary>
        /// Generates an SQL query based on the input
        /// query e.g. "SELECT * FROM staff"
        /// </summary>
        /// <param name="query"></param>
        public static void selectQuery(string query) {
            try {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                read = cmd.ExecuteReader();
            } catch (Exception ex) {
                //put a message box in here if you are recieving errors and see if you can find out why?
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }
        public static void selectTasksOnProjectid(int projectid) {
            try {
                con.Close();
                String commandText = "SELECT * FROM task WHERE projectid = @projectid";


                SqlCommand command = new SqlCommand(commandText, con);
                SqlParameter projectParam = new SqlParameter();
                projectParam.ParameterName = "@projectid";
                projectParam.Value = projectid;
                command.Parameters.Add(projectParam);

                con.Open();
                read = command.ExecuteReader();


            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        public static void getProgrammersIssues(String programmerUsername) {
            try {
                con.Close();
                String commandText = "EXEC programmer_issue_assc @username";

                SqlCommand command = new SqlCommand(commandText, con);
                command.Parameters.AddWithValue("@username", programmerUsername);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        public static void getProgrammersTasks(String programmerUsername) {
            try {
                con.Close();
                String commandText = "EXEC programmer_task_assc @username";

                SqlCommand command = new SqlCommand(commandText, con);
                command.Parameters.AddWithValue("@username", programmerUsername);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        public static String getProjectName(int projectid) {
            try {
                String query = String.Format("SELECT title FROM project WHERE projectid = {0}", projectid);
                selectQuery(query);
                if (SQL.read.HasRows) {
                    SQL.read.Read();
                    return SQL.read[0].ToString();
                }

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            return "null";
        } 

        public static void getAllProgrammers() {
            con.Close();
            try {

                String commandText = "SELECT * FROM programmer";
                SqlCommand command = new SqlCommand(commandText, con);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        // gets all programmers based on taskid
        public static void getProgrammersOnTask(int taskid) {
            con.Close();
            try {

                String commandText = "EXEC get_programmer_from_taskid @task";

                SqlCommand command = new SqlCommand(commandText, con);
                SqlParameter projectParam = new SqlParameter();
                projectParam.ParameterName = "@task";
                projectParam.Value = taskid;
                command.Parameters.Add(projectParam);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        // Gets a table of progress that link to task id given
        public static void selectProgressByTask(int taskid) {
            con.Close();
            try {

                String commandText = "EXEC get_progress @task";

                SqlCommand command = new SqlCommand(commandText, con);
                SqlParameter projectParam = new SqlParameter();
                projectParam.ParameterName = "@task";
                projectParam.Value = taskid;
                command.Parameters.Add(projectParam);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }

        }
        public static void selectEmployee(int table, String username) {
            try { 
                con.Close();
                String commandText;


                switch (table) {
                    case 0:
                        commandText = "SELECT * FROM programmer WHERE programmerUsername = @username";
                        break;

                    case 1:
                        commandText = "SELECT * FROM manager WHERE managerUsername = @username";
                        break;

                    default:
                        throw new ArgumentNullException("No Role for user");
                }

                SqlCommand command = new SqlCommand(commandText, con);
                SqlParameter usernameParam = new SqlParameter();
                usernameParam.ParameterName = "@username";
                usernameParam.Value = username;
                command.Parameters.Add(usernameParam);
                         
                con.Open();
                read = command.ExecuteReader();
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        // Get all issues that relate to projects of manager
        public static void getManagerIssues(String username) {
            con.Close();
            String query = "EXEC get_manager_issues @manager";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@manager", username);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        // Gets project info based on given project id
        public static void getProjectOnID(String projectid) {
            con.Close();
            String query = "SELECT * FROM project WHERE projectid = @projectid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@projectid", projectid);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void getManagerProjectAssc(String manager) {
            con.Close();
            String query = "EXEC manager_project_assc @manager";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@manager", manager);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void getProjectFromIssueID(String issueID) {
            con.Close();
            String query = "EXEC get_project_for_issue @issueid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@issueid", issueID);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        // gets number of completed tasks for given project
        public static void getProjectsCompletedTasks(int projectid) {
            con.Close();
            String query = "EXEC completed_tasks_for_project @projectid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@projectid", projectid);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void getProjectsIncompleteTasks(int projectid) {
            con.Close();
            String query = "EXEC incomplete_tasks_for_project @projectid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@projectid", projectid);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void getProjectsTotalTasks(int projectid) {
            con.Close();
            String query = "EXEC total_tasks_for_project @projectid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@projectid", projectid);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void getProjectsTotalProgrammers(int projectid) {
            con.Close();
            String query = "EXEC total_programmers_for_project @projectid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@projectid", projectid);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void getProjectsTotalIssues(int projectid) {
            con.Close();
            String query = "EXEC total_issues_for_project @projectid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@projectid", projectid);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }


        public static void getProjectsTotalClosedIssues(int projectid) {
            con.Close();
            String query = "EXEC total_closed_issues_for_project @projectid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@projectid", projectid);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }
        
        public static void getProjectsTotalOpenIssues(int projectid) {
            con.Close();
            String query = "EXEC total_open_issues_for_project @projectid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@projectid", projectid);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void getProjectsForProgrammer(String programmerUsername) {
            con.Close();
            String query = "EXEC programmer_project_assc @programmer";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@programmer", programmerUsername);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void getIssueOnID(String issueID) {
            con.Close();
            String query = "SELECT * FROM issue WHERE issueid = @issueID";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@issueID", issueID);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void getTaskOnID(String taskID) {
            con.Close();
            String query = "SELECT * FROM task WHERE taskid = @taskID";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@taskID", taskID);

                con.Open();
                read = command.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void updateIssue(String description, string urgency, string status, String issueid) {
            con.Close();
            String query = "UPDATE issue SET description = @description, urgency = @urgency , status = @status WHERE issueid = @issueid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@urgency", urgency);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@issueid", issueid);

                con.Open();
                SqlCommand dateSet = new SqlCommand("SET DATEFORMAT dmy", con);
                dateSet.ExecuteNonQuery();
                command.ExecuteNonQuery();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        public static void updateTask(String description, string priority, string completeDate, String taskid) {
            con.Close();
            String query = "UPDATE task SET description = @description, priority = @priority, completeDate = @completeDate WHERE taskid = @taskid";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@completeDate", completeDate);
                command.Parameters.AddWithValue("@taskid", taskid);

                con.Open();
                SqlCommand dateSet = new SqlCommand("SET DATEFORMAT dmy", con);
                dateSet.ExecuteNonQuery();
                command.ExecuteNonQuery();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }


        //-------------------------------------------------------------
        //                          INSERTS                          --
        //-------------------------------------------------------------

        public static void insertProgress(Data.ProgressInfo progress) {
            con.Close();
            String query = "INSERT INTO progress VALUES(@description, CAST(GETDATE() AS Date), @taskid)";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@description", progress.description);
                command.Parameters.AddWithValue("@taskid", progress.taskid);

                con.Open();
                SqlCommand dateSet = new SqlCommand("SET DATEFORMAT dmy", con);
                dateSet.ExecuteNonQuery();
                command.ExecuteNonQuery();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        // Inserts task data into task database
        public static void insertTask(Data.TaskInfo task) {
       
            con.Close();
            String query = "INSERT INTO task VALUES(@name, @description, @priority, CAST( GETDATE() AS Date ), @completeDate, @projectid)";

            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@name", task.name);
                command.Parameters.AddWithValue("@description", task.description);
                command.Parameters.AddWithValue("@priority", task.priority);
                command.Parameters.AddWithValue("@completeDate", task.completeDate ?? Convert.DBNull);
                command.Parameters.AddWithValue("@projectid", task.projectid);

                con.Open();
                SqlCommand dateSet = new SqlCommand("SET DATEFORMAT dmy", con);
                dateSet.ExecuteNonQuery();
                command.ExecuteNonQuery();
         
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        // inserts given data into worksOn database
        public static void insertWorksOn(int taskid, String username) {
            con.Close();
            String query = "INSERT INTO worksOn VALUES(@taskid, @username)";
            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@taskid", taskid);

                con.Open();
                command.ExecuteNonQuery();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        // Inserts given issue info in database
        public static void insertIssue(Data.IssueInfo issue) {
            con.Close();
            String query = "INSERT INTO issue VALUES(@description, CAST(GETDATE() AS Date), @urgency, @status, @projectid)";
            try {

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@description", issue.description);
                command.Parameters.AddWithValue("@urgency", issue.urgency);
                command.Parameters.AddWithValue("@status", issue.status);
                command.Parameters.AddWithValue("@projectid", issue.projectid.ToString());

                con.Open();
                SqlCommand dateSet = new SqlCommand("SET DATEFORMAT dmy", con);
                dateSet.ExecuteNonQuery();
                command.ExecuteNonQuery();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }


    }
}
