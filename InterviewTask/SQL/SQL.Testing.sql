CREATE TABLE Testing (
City varchar(50),
);

INSERT INTO Testing(City)
VALUES ('Berlin'),
       ('London'),
	   ('Sofia')

ALTER TABLE Testing
ADD Country varchar(50),
PostalCode int
GO

INSERT INTO Testing
VALUES ('Berlin', 'Germany', 33),
       ('London', 'UK',22),
	   ('Sofia', 'Bulgaria', 1326)