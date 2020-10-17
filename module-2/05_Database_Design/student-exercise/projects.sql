CREATE DATABASE ProjectOrganizer

USE ProjectOrganizer


CREATE TABLE Employee (
employee_number int NOT NULL IDENTITY(1,1) PRIMARY KEY,
job_title varchar(30),
last_name varchar (60),
first_name varchar (60),
gender varchar (20),
date_of_birth varchar (10),
date_of_hire varchar (10),
department_number int,
project_number int);

CREATE TABLE Department (
department_number int NOT NULL IDENTITY(1,1) PRIMARY KEY,
department_name varchar(30));

ALTER TABLE Employee
ADD FOREIGN KEY (department_number) REFERENCES Department(department_number);

CREATE TABLE Project (
project_number int IDENTITY(1,1) NOT NULL PRIMARY KEY,
project_name varchar(50),
project_start_date varchar(10));

ALTER TABLE Employee
ADD FOREIGN KEY (project_number) REFERENCES Project(project_number);

BEGIN TRANSACTION

INSERT INTO Employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire) 
VALUES ('Manager', 'Gates', 'Breydon', 'Male', '05/18/1993', '10/16/2020');

INSERT INTO Employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire) 
VALUES ('Web Developer', 'Smith', 'Tom', 'Male', '06/28/1990', '03/16/2020');

INSERT INTO Employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire) 
VALUES ('Web Developer', 'Garcia', 'Angie', 'Female', '12/28/1980', '05/11/2018');

INSERT INTO Employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire) 
VALUES ('Director', 'Reilly', 'Shannon', 'Female', '10/10/1991', '08/09/2019');

INSERT INTO Employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire) 
VALUES ('QA Engineer', 'Kaine', 'Ashley', 'Female', '11/28/1980', '05/20/2018');

INSERT INTO Employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire) 
VALUES ('Web Developer', 'Drake', 'Tom', 'Male', '12/28/1980', '05/11/2019');

INSERT INTO Employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire) 
VALUES ('Designer', 'Jones', 'Mike', 'Male', '10/28/1980', '05/19/2018');

INSERT INTO Employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire) 
VALUES ('Center', 'James', 'Lebron', 'Male', '10/28/1980', '10/11/2020');

INSERT INTO Department(department_name)
VALUES ('Acounting');

INSERT INTO Department(department_name)
VALUES ('Marketing');

INSERT INTO Department(department_name)
VALUES ('Basketball');

INSERT INTO Department(department_name)
VALUES ('Sleeping');

INSERT INTO Project(project_name, project_start_date)
VALUES ('The Big Project', '10/16/2020')

INSERT INTO Project(project_name, project_start_date)
VALUES ('The Big Nap', '10/16/2020')

INSERT INTO Project(project_name, project_start_date)
VALUES ('Stealing the Decleration of Independence', '10/16/2020')

INSERT INTO Project(project_name, project_start_date)
VALUES ('Doing something other than this', '10/16/2020')

COMMIT TRANSACTION;


UPDATE Employee
SET department_number = 8
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 9)

UPDATE Employee
SET department_number = 7
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 10)

UPDATE Employee
SET department_number = 6
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 11)

UPDATE Employee
SET department_number = 5
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 12)

UPDATE Employee
SET department_number = 6
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 13)

UPDATE Employee
SET department_number = 7
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 14)

UPDATE Employee
SET department_number = 8
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 15)

UPDATE Employee
SET department_number = 5
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 16)

UPDATE Employee
SET project_number = 6
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 9)

UPDATE Employee
SET project_number = 7
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 10)

UPDATE Employee
SET project_number = 6
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 11)

UPDATE Employee
SET project_number = 5
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 12)

UPDATE Employee
SET project_number = 7
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 13)

UPDATE Employee
SET project_number = 5
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 14)

UPDATE Employee
SET project_number = 6
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 15)

UPDATE Employee
SET project_number = 7
WHERE employee_number IN
(SELECT employee_number 
FROM Employee 
WHERE employee_number = 16)

