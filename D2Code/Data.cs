using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2Code {
    public class Data {
        public class UserInfo {
            public const int PROGRAMMER_ROLE = 0;
            public const int MANAGER_ROLE = 1;

            public bool loggedIn;
            public string username;
            public string firstName;
            public string lastName;
            public string password;
            public int role;

            public UserInfo() {
                this.loggedIn = false;
                this.username = this.firstName = this.lastName = this.password = "";
                this.role = -1;
            }
        }

        public class ProjectInfo {
            public String projectid, title, startDate, endDate, status, budget, description, customerUsername;


            public ProjectInfo(String projectid, String title, String startDate, String endDate, String status,
                String budget, String description, String customerUsername) {

                this.projectid = projectid;
                this.title = title;
                this.startDate = startDate;
                this.endDate = endDate;
                this.status = status;
                this.budget = budget;
                this.description = description;
                this.customerUsername = customerUsername;
            }
        }

        public class TaskInfo {
            public String taskid, name, description, priority, startDate, completeDate;
            public int projectid;

            public TaskInfo(String taskid, String name, String description, String priority, String startDate, String completeDate,
                int projectid) {

                this.taskid = taskid;
                this.name = name;
                this.description = description;
                this.priority = priority;
                this.startDate = startDate;
                this.completeDate = completeDate;
                this.projectid = projectid;
            }
        }

        public class ProgressInfo {
            public String progressid, description, reportDate;
            public int taskid;

            public ProgressInfo(String progressid, String description, String reportDate, int taskid) {
                this.progressid = progressid;
                this.description = description;
                this.reportDate = reportDate;
                this.taskid = taskid;
            }

        }

        public class IssueInfo {
            public String issueid, description, urgency, status, reportDate;
            public int projectid;

            public IssueInfo(string issueid, string description, string urgency, string status, string reportDate, int projectid) {
                this.issueid = issueid;
                this.description = description;
                this.urgency = urgency;
                this.status = status;
                this.reportDate = reportDate;
                this.projectid = projectid;
            }
        }
    }
}