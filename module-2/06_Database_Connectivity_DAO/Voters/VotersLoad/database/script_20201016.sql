USE master;
GO

DROP DATABASE IF EXISTS Voters;
GO

CREATE DATABASE Voters;
GO

USE Voters;

CREATE TABLE Voter (
state_id nvarchar(12) PRIMARY KEY,
county_id nvarchar(9),
registered datetime,
last_name nvarchar(60),
first_name nvarchar(60)
);

CREATE TABLE Election (
id int IDENTITY,
state_id nvarchar(12),
election_year int,
election_month int,
election_type char(1),
ballot_type char(1)
);


INSERT INTO Voter (state_id, county_id, registered, last_name, first_name) VALUES 
('OH0017762498', '990288455', '1/1/1999', 'ADAIR', 'BEVERLY');
INSERT INTO Election (state_id, election_year, election_month, election_type, ballot_type) VALUES
('OH0017762498',2012, 11, 'G', 'X');


ALTER TABLE Election
ADD CONSTRAINT FK_ElectionVoter
FOREIGN KEY (state_id) REFERENCES Voter(state_id);
GO





