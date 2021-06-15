USE D2
SET DATEFORMAT dmy



CREATE TABLE customer (
	customerUsername	VARCHAR(32) 
						NOT NULL
						PRIMARY KEY,

	-- NOT NULL because a key value pair is required to login
	password			VARCHAR(32)
						NOT NULL,
						--CHECK ((LEN(password) >= 6) 
						-- Must contain a capital
						--AND (password LIKE '%[A-Z]%')
						--AND (password LIKE '%[0-9]%')),	

	-- fname and lname NOT NULL as I would be a problem otherwise. Lots of people running around
	-- with only usernames and no conenction to who they are.
	fName				VARCHAR(32)
						NOT NULL,
						

	lName				VARCHAR(64)
						NOT NULL,
						

	email				VARCHAR(64)
						CHECK (email LIKE '_%@_%._%'),

	phone				VARCHAR(32),

	bankAccount			BIGINT,

	-- Address
	-- ie University of Waikato, Te Whare Wananga o Waikato
	-- assuming it would all be stored as one thing as they both reference the same 'company'
	company				VARCHAR(128),

	-- ie Gate 1 or 16A
	street_number		VARCHAR(16),

	street				VARCHAR(64),

	locality			VARCHAR(64),

	city				VARCHAR(64)
		
)

CREATE TABLE project (
	projectid			INT 
						NOT NULL
						PRIMARY KEY
						IDENTITY(1,1),

	title				VARCHAR(128),

	-- NOT NULL as assume that when a project is created then that's its start date
	-- Didn't put a constraint on (ie < currentDAte) unless someone need to change it down the line
	startDate			DATE
						NOT NULL,
	
	-- Find way to do endDate >= startDate
	endDate				DATE,
						
	-- NOT NULL because there will always be some sort of status
	status				VARCHAR(32)
						NOT NULL,

	-- NOT NULL as assuming that there will always be an idea of the money wanting to be spent
	-- even if it's something like unlimited
	budget				REAL
						NOT NULL
						CHECK (budget >= 0),

	description			VARCHAR(1028),

	customerUsername	VARCHAR(32) 
						NOT NULL
						FOREIGN KEY REFERENCES customer,
)

CREATE TABLE manager(
	managerUsername	    VARCHAR(32) 
						NOT NULL
						PRIMARY KEY,

password				VARCHAR(32)
						NOT NULL,
						--CHECK ((LEN(password) >= 6) 
						-- Must contain a capital
						--AND (password LIKE '%[A-Z]%')
						--AND (password LIKE '%[0-9]%')),	

	fName				VARCHAR(32)
						NOT NULL,

	lName				VARCHAR(64)
						NOT NULL,

	DOB					DATE
						-- Check older than 16
						CHECK ((YEAR(DOB)) <= YEAR(GETDATE() - 16)),

	salary				REAL
						-- Check atleast the absolute minimum you can pay someone
						-- ie 16yo training wage (NZ)
						CHECK (salary >= 33280),

	phone				VARCHAR(32),

	-- Address
	-- ie University of Waikato, Te Whare Wananga o Waikato
	-- assuming it would all be stored as one thing as they both reference the same 'company'
	company				VARCHAR(128),

	-- ie Gate 1 or 16A
	street_number		VARCHAR(16),

	street				VARCHAR(64),

	locality			VARCHAR(64),

	city				VARCHAR(64)
)




CREATE TABLE issue (
	issueid				INT
						NOT NULL
						PRIMARY KEY
						IDENTITY(1,1),

	description			VARCHAR(256),

	-- NOT NULL as assumed auto set date to date of report
	reportDate			DATE
						NOT NULL,

	urgency				VARCHAR(16),

	-- NOT NULL as assume there will always be a status of sorts
	status				VARCHAR(16)
						NOT NULL,

	projectid			INT
						FOREIGN KEY REFERENCES project
						NOT NULL,
)


CREATE TABLE task (
	taskid				INT
						NOT NULL
						PRIMARY KEY
						IDENTITY(1,1),

	name				VARCHAR(64),

	description			VARCHAR(256),
	
	priority			VARCHAR(16),

	-- NOT NULL as assume start date is the day it was created
	startDate			DATE
						NOT NULL,

	completeDate		DATE,

	projectid			INT
						NOT NULL
						FOREIGN KEY REFERENCES project,
)


CREATE TABLE progress (
	progressid			INT
						NOT NULL
						PRIMARY KEY
						IDENTITY(1,1),

	description			VARCHAR(256),

	-- NOT NULL assuming report date will be auto input as current date
	reportDate			DATE
						NOT NULL,

	taskid				INT
						NOT NULL
						FOREIGN KEY REFERENCES task,
)


CREATE TABLE programmer (
	programmerUsername	VARCHAR(32)
						NOT NULL
						PRIMARY KEY,


	password			VARCHAR(32)
						NOT NULL,
						--CHECK ((LEN(password) >= 8) 
						-- Must contain a capital
						--AND (password LIKE '%[A-Z]%')
						--AND (password LIKE '%[0-9]%')),	

						
	fName				VARCHAR(32)
						NOT NULL,

	lName				VARCHAR(64)
						NOT NULL,

	DOB					DATE
						-- Check older than 16
						CHECK ((YEAR(DOB)) <= YEAR(GETDATE() - 16)),

	salary				REAL
						-- Check atleast the absolute minimum you can pay someone
						-- ie 16yo training wage (NZ)
						CHECK (salary >= 33280),

	phone				VARCHAR(32),

		-- Address
	-- ie University of Waikato, Te Whare Wananga o Waikato
	-- assuming it would all be stored as one thing as they both reference the same 'company'
	company				VARCHAR(128),

	-- ie Gate 1 or 16A
	street_number		VARCHAR(16),

	street				VARCHAR(64),

	locality			VARCHAR(64),

	city				VARCHAR(64)
)


CREATE TABLE manage (
	projectid			INT
						NOT NULL
						FOREIGN KEY REFERENCES project,

	managerUsername		VARCHAR(32)
						NOT NULL
						FOREIGN KEY REFERENCES manager,

	PRIMARY KEY(projectid, managerUsername)
)


CREATE TABLE worksOn (
	taskid				INT
						NOT NULL
						FOREIGN KEY REFERENCES task,

	programmerUsername	VARCHAR(32)
						NOT NULL
						FOREIGN KEY REFERENCES programmer,

	PRIMARY KEY (taskid, programmerUsername)
)


INSERT INTO customer VALUES ('cpilbrow', 'Q!e3R$5tY^', 'Colin', 'Pilbrow', 'cpilbrow@waikato.ac.nz', null, 8588268673,
							null, '220', 'Seddul Bahr Road', 'Akatarawu', 'Upper Hutt')

INSERT INTO customer VALUES ('anna', 'password', 'Anna', 'Smith', 'annasmith@gmail.com', '755-2099', 8524546400912,
							null, '42', 'Ngaio Street', 'Macandrew Bay', 'Dunedin')

INSERT INTO customer VALUES ('bob', '123456', 'Bob', 'Johnson', 'bobby@gmail.com', '634-5789', 10266563210016,
							null, null, null, null, null)

INSERT INTO customer VALUES ('clint', 'picture1', 'Clint', 'Brown', 'browner@hotmail.com', '867-5309', 684915015503483,
							null, '131', 'Forres Street', 'Aramoho', 'Wanganui')

INSERT INTO customer VALUES ('dave', 'qwerty', 'Dave', 'Jones', 'dj123@students.waikato.ac.nz', '0118 999 881 99 9119 7253', 
							419534544, null, null, null, null, null)
							
INSERT INTO customer VALUES ('emma', 'abc123', 'Emma', 'Miller', 'emabc123@yahoo.com', '273-9164', 329906149290,
							null, '168', 'Seddon Road', 'Waikato Hospital', 'Hamilton')

						

INSERT INTO project VALUES ('Attention: Database', '1/01/2021', null, 'Development', '10000', 
'Video game', 'Bob')
INSERT INTO project VALUES ('Essential Database Smartphone App', '2/01/2021', null, 'Development', '200000', 
							'All in one application', 'Anna')
INSERT INTO project VALUES ('Database Adventures', '6/02/2020', '15/04/2021', 'Postpone', '5200', 
							'VRMMO', 'Bob')
INSERT INTO project VALUES ('Database Expert Interview', '10/04/2019', '6/06/2020', 'Complete', '30', 
							'Interview with university students', 'Dave')
INSERT INTO project VALUES ('COMPX223 Project', '1/03/2020', null, 'Development', '0', 
							'What you''re doing now', 'cpilbrow')
INSERT INTO project VALUES ('Database Iphone App', '25/04/2019', '24/08/2020', 'Complete', '123000', 
							'The essential database app ported to iPhone', 'Anna')
INSERT INTO project VALUES ('Database May Not Exist!', '1/06/2020', null, 'Testing', '999999', 
							'Unknown', 'Emma')
INSERT INTO project VALUES ('The Philosophy Of Database', '26/09/2019', '27/12/2020', 'Testing', '1000000', 
							'We have no idea what this is but the client is paying heaps for it', 'Emma')
INSERT INTO project VALUES ('Warning: Database', '25/12/2018', '4/01/2019', 'shutdown', '100', 
							'Video game', 'Bob')

INSERT INTO programmer VALUES ('BlaviButcher', 'herpderp', 'Riley', 'Douglas', '24/09/1997', '33280', '0272179555',
								null, '16A', 'Firth Street', 'Piako', 'Matamata')
INSERT INTO programmer VALUES ('HorseBoy', 'itsnotwhatyouthink', 'Kurt', 'Bonenkamp', '18/10/1997', '33280', '0225876897',
								null, '1056', 'No.1 Road', 'Piako', 'Springdale')
INSERT INTO programmer VALUES ('Builderhut', 'iguessibuildhuts', 'Joel', 'Howse', '1/6/1997', '80000', '02745678965',
								null, '24', 'Vosper Street', 'Piako', 'Matamata')


INSERT INTO task VALUES ('Sprites', 'Create base sprites for main character', 'Low', '4/4/2021', null, '9')
INSERT INTO task VALUES ('Remove Unessential', 'Someone decided to put non-essential things in the essential database',
						'Urgent', '7/4/2021', '9/4/2021', '2')
INSERT INTO task VALUES ('Make sql database', 'Do the damned assignment!', 'Urgent', '20/4/2021', '7/4/2021', '5')
INSERT INTO task VALUES ('404 Not Found', 'Find the missing database!!!?!!?!', 'Urgent', '23/4/2021', null, '7')
INSERT INTO task VALUES ('Ponder', 'Why do we need databases you ask?', 'Moderate', '2/3/2021', null, '8')
INSERT INTO task VALUES ('Be the expert', 'Create expert database', 'Low', '1/3/2021', null, '4')
INSERT INTO task VALUES ('Self-destruct in t-minus', 'Delete everything now!', 'Urgent', '7/3/2021', '8/3/2021', '9')
INSERT INTO task VALUES ('Adventure', 'You don''t really know what you''re doing. Have a browse of the current codebase',
							'Moderate', '12/3/2021', '27/3/2021', '3')
INSERT INTO task VALUES ('Get more info', 'Get some more info from the customer', 'High', '12/3/2021', '27/3/2021',
						'3')
INSERT INTO task VALUES ('Clean up mess', 'You didn''t clear data in time. Self destruct twas not the goods', 'High',
						'9/3/2021', null, '3')
INSERT INTO task VALUES ('Do your best', 'Make sure to have fun', 'High',
						'10/3/2021', null, '1')


INSERT INTO worksOn VALUES ('1', 'BlaviButcher')
INSERT INTO worksOn VALUES ('2', 'HorseBoy')
INSERT INTO worksOn VALUES ('3', 'BlaviButcher')
INSERT INTO worksOn VALUES ('3', 'Builderhut')
INSERT INTO worksOn VALUES ('4', 'Builderhut')
INSERT INTO worksOn VALUES ('4', 'HorseBoy')
INSERT INTO worksOn VALUES ('5', 'Builderhut')
INSERT INTO worksOn VALUES ('6', 'BlaviButcher')
INSERT INTO worksOn VALUES ('7', 'BlaviButcher')
INSERT INTO worksOn VALUES ('7', 'HorseBoy')
INSERT INTO worksOn VALUES ('8', 'Builderhut')
INSERT INTO worksOn VALUES ('8', 'HorseBoy')
INSERT INTO worksOn VALUES ('9', 'Builderhut')
INSERT INTO worksOn VALUES ('9', 'BlaviButcher')
INSERT INTO worksOn VALUES ('10', 'BlaviButcher')

INSERT INTO manager VALUES ('swu', 'uws', 'Shaoqun', 'Wu', null, null, '4782', 
							'The University of Waikato, Te Whare Wananga o Waikato',
							'Gate 1', 'Knighton Road', null, null)
INSERT INTO manager VALUES ('nilesh', 'million2', 'Nilesh', 'Kanji', null, null, '5047', 
							'The University of Waikato, Te Whare Wananga o Waikato',
							'Gate 1', 'Knighton Road', null, null)
INSERT INTO manager VALUES ('admin', 'admin', 'Admin', 'Admin', null, null, null, 
							null, '1', 'Admin Road', 'Admin', 'Admin')




INSERT INTO issue VALUES('database not found, lord save us', '5/05/2021', 'Urgent', 'Development', 1)
INSERT INTO issue VALUES('Kyle has been lost in the database', '3/05/2021', 'Urgent', 'Completed', 1)
INSERT INTO issue VALUES('Made app for iphone', '3/03/2021', 'Moderate', 'Development', 2)
INSERT INTO issue VALUES('app will not launch', '3/04/2021', 'Low', 'Completed', 2)
INSERT INTO issue VALUES('Cannot compute', '3/02/2021', 'High', 'Completed', 3)
INSERT INTO issue VALUES('Stuggles to find words', '3/03/2021', 'High', 'Development', 4)
INSERT INTO issue VALUES('Interviewer is mean', '6/03/2021', 'High', 'Development', 4)
INSERT INTO issue VALUES('Issues will not add themselves', '6/06/2021', 'High', 'Completed', 5)
INSERT INTO issue VALUES('60 hours... cannot go on', '9/06/2021', 'Urgent', 'Completed', 5)
INSERT INTO issue VALUES('App was made for android', '9/06/2021', 'Urgent', 'Development', 6)
INSERT INTO issue VALUES('Find database, it is lost', '7/06/2021', 'High', 'Development', 7)
INSERT INTO issue VALUES('Existensial Crisis', '11/06/2021', 'High', 'Development', 8)
INSERT INTO issue VALUES('Existensial Crisis v2', '11/06/2021', 'High', 'Completed', 8)
INSERT INTO issue VALUES('Database is scaring the programmers', '4/03/2021', 'High', 'Completed', 9)
INSERT INTO issue VALUES('Database is scaring the programmers v2', '4/03/2021', 'High', 'Completed', 9)

SELECT * FROM issue

INSERT INTO progress VALUES('Created the legs for sprites', '6/05/2021', 1)
INSERT INTO progress VALUES('Made animations', '6/06/2021', 1)
INSERT INTO progress VALUES('Removed half of the non-essentials', '1/06/2021', 2)
INSERT INTO progress VALUES('Added data to empty tables', '1/05/2021', 3)
INSERT INTO progress VALUES('Made FormHelper class', '5/05/2021', 3)
INSERT INTO progress VALUES('Searched every room', '15/05/2021', 4)
INSERT INTO progress VALUES('Youtubed the point of databases', '11/05/2021', 5)
INSERT INTO progress VALUES('Had exestential crisis', '12/05/2021', 5)
INSERT INTO progress VALUES('Attempted to create expert database, failed', '22/05/2021', 6)
INSERT INTO progress VALUES('Deleted most things, lost of limbs', '24/05/2021', 7)
INSERT INTO progress VALUES('Took a peek at the codebase', '29/04/2021', 8)
INSERT INTO progress VALUES('Talked to customer, got abused', '29/05/2021', 9)
INSERT INTO progress VALUES('Played nice with customer', '30/05/2021', 9)
INSERT INTO progress VALUES('Cleaned up some of the mess', '4/06/2021', 9)


INSERT INTO manage VALUES ('1', 'swu') 
INSERT INTO manage VALUES ('2', 'swu') 
INSERT INTO manage VALUES ('3', 'nilesh') 
INSERT INTO manage VALUES ('4', 'swu') 
INSERT INTO manage VALUES ('4', 'nilesh') 
INSERT INTO manage VALUES ('5', 'swu') 
INSERT INTO manage VALUES ('6', 'swu') 
INSERT INTO manage VALUES ('6', 'nilesh') 
INSERT INTO manage VALUES ('7', 'nilesh') 
INSERT INTO manage VALUES ('8', 'nilesh') 
INSERT INTO manage VALUES ('9', 'swu') 

SELECT * FROM task
--------------------------------------
--			RESET TABLES			--
--------------------------------------
DBCC CHECKIDENT ('project', RESEED, 0)
DBCC CHECKIDENT ('issue', RESEED, 0)
DBCC CHECKIDENT ('task', RESEED, 0)
DBCC CHECKIDENT ('progress', RESEED, 0)

DROP TABLE worksOn;
DROP TABLE manage;
DROP TABLE programmer;
DROP TABLE progress;
DROP TABLE task;
DROP TABLE issue;
DROP TABLE manager;
DROP TABLE project;
DROP TABLE customer;

SELECT * FROM issue where issueid = 1

SELECT * FROM project 
SELECT * FROM customer
SELECT * FROM manage
SELECT * FROM manager
SELECT * FROM programmer
SELECT * FROM worksOn
SELECT * FROM task
SELECT * FROM issue
SELECT * FROM progress

--------------------------------------------------------------------------------
-- Procedure that takes in a task id and returns table of progress that links --
--------------------------------------------------------------------------------
GO
IF OBJECT_ID('get_progress') IS NOT NULL
	DROP PROC get_progress
GO
CREATE PROC get_progress @task_id int = NULL
AS
IF @task_id IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT * FROM progress WHERE taskid = @task_id)
BEGIN
	PRINT 'No task with id ' + STR(@task_id, 2)
	RETURN -2
END
ELSE
BEGIN
	SELECT * FROM progress WHERE taskid = @task_id
END
RETURN
GO

EXEC get_progress 1
-------------------------------------------------
-- Procedure gets programmer names from taskid --
-------------------------------------------------
GO
IF OBJECT_ID('get_programmer_from_taskid') IS NOT NULL
	DROP PROC get_programmer_from_taskid
GO
CREATE PROC get_programmer_from_taskid @task_id int = NULL
AS
IF @task_id IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT programmerUsername FROM worksOn WHERE taskid = @task_id)
BEGIN
	PRINT 'No programmers assigned to task ' + STR(@task_id, 2)
	RETURN -2
END
ELSE
BEGIN
	SELECT programmerUsername FROM worksOn WHERE taskid = @task_id
END
RETURN
GO


-----------------------------------------------------------------------
-- Procedure gets issue and project info given a programmer username --
-----------------------------------------------------------------------
IF OBJECT_ID('get_programmer_issues') IS NOT NULL
	DROP PROC get_programmer_issues
GO
CREATE PROC get_programmer_issues @programmer VARCHAR(32) = NULL
AS
IF @programmer IS NULL
BEGIN
	PRINT 'param is empty'
	RETURN -1
END
IF NOT EXISTS (SELECT *
	FROM project p INNER JOIN issue i
		on p.projectid = i.projectid
	WHERE p.projectid IN (
	SELECT projectid
	FROM task t INNER JOIN worksOn w 
		ON t.taskid = w.taskid
	WHERE programmerUsername = @programmer))
BEGIN
	PRINT 'No issues for this programmer ' + @programmer
	RETURN -2
END
ELSE
BEGIN 
	SELECT *
	FROM project p INNER JOIN issue i
		on p.projectid = i.projectid
	WHERE p.projectid IN (
	SELECT projectid
	FROM task t INNER JOIN worksOn w 
		ON t.taskid = w.taskid
	WHERE programmerUsername = @programmer)
END
RETURN
GO


---------------------------------------------------------------------
-- Procedure gets issue and project info given a manager username --
---------------------------------------------------------------------
GO
IF OBJECT_ID('get_manager_issues') IS NOT NULL
	DROP PROC get_manager_issues
GO
CREATE PROC get_manager_issues 
@manager VARCHAR(32) = NULL
AS
IF @manager IS NULL
BEGIN
	PRINT 'param is empty'
	RETURN - 1
END
IF NOT EXISTS (SELECT *
				FROM ((project p
					INNER JOIN manage m ON p.projectid = m.projectid)
					INNER JOIN issue i ON p.projectid = i.projectid)
				WHERE managerUsername = @manager)
BEGIN
	PRINT 'No issues for this manager ' + @manager
	RETURN -2
END	
ELSE 
BEGIN
	SELECT *
	FROM ((project p
		INNER JOIN manage m ON p.projectid = m.projectid)
		INNER JOIN issue i ON p.projectid = i.projectid)
	WHERE managerUsername = @manager	
END
RETURN
GO

-------------------------------------------------------------
-- Procedure gets projects that manager is associated with --
-------------------------------------------------------------
GO
IF OBJECT_ID('manager_project_assc') IS NOT NULL
	DROP PROC manager_project_assc
GO
GO
CREATE PROC manager_project_assc @manager VARCHAR(32) = NULL
AS
IF @manager IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT *
				FROM manage m INNER JOIN project p
					ON m.projectid = p.projectid
				WHERE m.managerUsername = @manager)
BEGIN
	PRINT @manager + ' is not associated with any projects'
	RETURN -2;
END
ELSE
BEGIN
	SELECT *
	FROM manage m INNER JOIN project p
		ON m.projectid = p.projectid
	WHERE m.managerUsername = @manager
END
RETURN
GO
---------------------------------------------
-- Gets tasks associated with a programmer --
---------------------------------------------
IF OBJECT_ID('programmer_task_assc') IS NOT NULL
	DROP PROC programmer_task_assc
GO
GO
CREATE PROC programmer_task_assc @programmer VARCHAR(32) = NULL
AS
IF @programmer IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT *
				FROM task t INNER JOIN worksOn w
					ON t.taskid = w.taskid
				WHERE w.programmerUsername = @programmer)
BEGIN
	PRINT @programmer + ' is not associated with any tasks'
	RETURN -2;
END
ELSE
BEGIN
	SELECT *
	FROM task t INNER JOIN worksOn w
		ON t.taskid = w.taskid
	WHERE w.programmerUsername = @programmer
END
RETURN
GO
--------------------------------------------------------7
-- gets all issues associated with a given programmer --
--------------------------------------------------------
IF OBJECT_ID('programmer_issue_assc') IS NOT NULL
	DROP PROC programmer_issue_assc
GO
GO
CREATE PROC programmer_issue_assc @programmer VARCHAR(32) = NULL
AS
IF @programmer IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (	SELECT i.issueid, p.projectid, p.title, i.description, i.reportDate, i.urgency, i.status
				FROM ((task t 
					INNER JOIN issue i ON t.projectid = i.projectid)
					INNER JOIN project p ON t.projectid = p.projectid)
					WHERE t.taskid IN (
						SELECT taskid
						FROM worksON
						WHERE programmerUsername = @programmer)
				GROUP BY i.issueid, p.projectid, p.title, i.description, i.reportDate, i.urgency, i.status)
BEGIN
	PRINT @programmer + ' is not associated with any issues'
	RETURN -2;
END		
ELSE
BEGIN
	SELECT i.issueid, p.projectid, p.title, i.description, i.reportDate, i.urgency, i.status
				FROM ((task t 
					INNER JOIN issue i ON t.projectid = i.projectid)
					INNER JOIN project p ON t.projectid = p.projectid)
					WHERE t.taskid IN (
						SELECT taskid
						FROM worksON
						WHERE programmerUsername = @programmer)
				GROUP BY i.issueid, p.projectid, p.title, i.description, i.reportDate, i.urgency, i.status
END
RETURN
GO

-------------------------------------------------
-- Number of completed tasks for given project --
-------------------------------------------------
GO
IF OBJECT_ID('completed_tasks_for_project') IS NOT NULL
	DROP PROC completed_tasks_for_project
GO
GO
CREATE PROC completed_tasks_for_project @projectid int = NULL
AS
IF @projectid IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT COUNT(taskid)
				FROM task
				WHERE projectid = @projectid
				AND completeDate <= CAST(GETDATE() AS Date))
BEGIN
	PRINT @projectid + ' is not associated with any projects'
	RETURN -2;
END		
ELSE
BEGIN
	SELECT COUNT(taskid)
	FROM task
	WHERE projectid = @projectid
	AND completeDate <= CAST(GETDATE() AS Date)
END
RETURN


--------------------------------------------------
-- Number of incomplete tasks for given project --
--------------------------------------------------
GO
IF OBJECT_ID('incomplete_tasks_for_project') IS NOT NULL
	DROP PROC incomplete_tasks_for_project
GO
GO
CREATE PROC incomplete_tasks_for_project @projectid int = NULL
AS
IF @projectid IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT COUNT(taskid)
				FROM task
				WHERE projectid = @projectid
				AND (completeDate > CAST(GETDATE() AS Date)
				OR completeDate IS NULL))
BEGIN
	PRINT @projectid + ' is not associated with any projects'
	RETURN -2;
END		
ELSE
BEGIN
	SELECT COUNT(taskid)
	FROM task
	WHERE projectid = @projectid
	AND (completeDate > CAST(GETDATE() AS Date)
	OR completeDate IS NULL)
END
RETURN

--------------------------------------------------
-- Number of total tasks for given project --
--------------------------------------------------
GO
IF OBJECT_ID('total_tasks_for_project') IS NOT NULL
	DROP PROC total_tasks_for_project
GO
GO
CREATE PROC total_tasks_for_project @projectid int = NULL
AS
IF @projectid IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT COUNT(taskid)
				FROM task
				WHERE projectid = @projectid)
BEGIN
	PRINT @projectid + ' is not associated with any projects'
	RETURN -2;
END		
ELSE
BEGIN
	SELECT COUNT(taskid)
	FROM task
	WHERE projectid = @projectid
END
RETURN

-----------------------------------------
-- Gets project based on given issueid --
-----------------------------------------
GO
IF OBJECT_ID('get_project_for_issue') IS NOT NULL
	DROP PROC get_project_for_issue
GO
GO
CREATE PROC get_project_for_issue @issueid int = NULL
AS
IF @issueid IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT *
	FROM project
	WHERE projectid = (SELECT p.projectid
		FROM project p INNER JOIN issue i
			ON p.projectid = i.projectid
		WHERE issueid = @issueid))
BEGIN
	PRINT @issueid + ' is not associated with any projects'
	RETURN -2;
END		
ELSE
BEGIN
	SELECT *
		FROM project
		WHERE projectid = (SELECT p.projectid
			FROM project p INNER JOIN issue i
				ON p.projectid = i.projectid
			WHERE issueid = @issueid)
END
RETURN


----------------------------------------------
-- Number of currently assigned programmers --
----------------------------------------------
GO
IF OBJECT_ID('total_programmers_for_project') IS NOT NULL
	DROP PROC total_programmers_for_project
GO
GO
CREATE PROC total_programmers_for_project @projectid int = NULL
AS
IF @projectid IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT COUNT(DISTINCT p.programmerUsername)
				FROM programmer p INNER JOIN worksOn w
					ON p.programmerUsername = w.programmerUsername
					WHERE w.taskid IN (SELECT taskid
						FROM task
						WHERE projectid = @projectid))
BEGIN
	PRINT @projectid + ' is not associated with any projects'
	RETURN -2;
END		
ELSE
BEGIN
	SELECT COUNT(DISTINCT p.programmerUsername)
	FROM programmer p INNER JOIN worksOn w
		ON p.programmerUsername = w.programmerUsername
		WHERE w.taskid IN (SELECT taskid
			FROM task
			WHERE projectid = @projectid)
END
RETURN
GO


----------------------------------------------
-- Number of issues --
----------------------------------------------
GO
IF OBJECT_ID('total_issues_for_project') IS NOT NULL
	DROP PROC total_issues_for_project
GO
GO
CREATE PROC total_issues_for_project @projectid int = NULL
AS
IF @projectid IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT COUNT(issueid)
			FROM issue
			WHERE projectid = @projectid)
BEGIN
	PRINT @projectid + ' is not associated with any projects'
	RETURN -2;
END		
ELSE
BEGIN
	SELECT COUNT(issueid)
	FROM issue
	WHERE projectid = @projectid
END
RETURN
GO


----------------------------------------------
-- Number of closed issues --
----------------------------------------------
GO
IF OBJECT_ID('total_closed_issues_for_project') IS NOT NULL
	DROP PROC total_closed_issues_for_project
GO
GO
CREATE PROC total_closed_issues_for_project @projectid int = NULL
AS
IF @projectid IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT COUNT(issueid)
				FROM issue
				WHERE projectid = 2
				AND status = 'completed')
BEGIN
	PRINT @projectid + ' is not associated with any projects'
	RETURN -2;
END		
ELSE
BEGIN
	SELECT COUNT(issueid)
	FROM issue
	WHERE projectid = 2
	AND status = 'completed'
END
RETURN
GO

----------------------------------------------
-- Number of open issues --
----------------------------------------------
GO
IF OBJECT_ID('total_open_issues_for_project') IS NOT NULL
	DROP PROC total_open_issues_for_project
GO
GO
CREATE PROC total_open_issues_for_project @projectid int = NULL
AS
IF @projectid IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT COUNT(issueid)
				FROM issue
				WHERE projectid = 2
				AND status <> 'completed')
BEGIN
	PRINT @projectid + ' is not associated with any projects'
	RETURN -2;
END		
ELSE
BEGIN
	SELECT COUNT(issueid)
	FROM issue
	WHERE projectid = 2
	AND status <> 'completed'
END
RETURN
GO

--------------------------------------------------------
-- gets projects that programmers are associated with --
--------------------------------------------------------
GO
IF OBJECT_ID('programmer_project_assc') IS NOT NULL
	DROP PROC programmer_project_assc
GO
GO
CREATE PROC programmer_project_assc @programmer VARCHAR(32) = NULL
AS
IF @programmer IS NULL
BEGIN
	PRINT 'param is null'
	RETURN -1
END
IF NOT EXISTS (SELECT *
				FROM project
				WHERE projectid IN (
					SELECT DISTINCT projectid
					FROM worksOn w INNER JOIN task t
						ON w.taskid = t.taskid
					WHERE programmerUsername = @programmer))
BEGIN
	PRINT @programmer + ' is not associated with any projects'
	RETURN -2;
END		
ELSE
BEGIN
	SELECT *
	FROM project
	WHERE projectid IN (
		SELECT DISTINCT projectid
		FROM worksOn w INNER JOIN task t
			ON w.taskid = t.taskid
		WHERE programmerUsername = @programmer)
END
RETURN
GO


BEGIN TRANSACTION
UPDATE issue SET description = 'test', urgency = 'test', status = 'test' WHERE issueid = 1
ROLLBACK TRANSACTION