create database EmployeeDb

create table Employee(
	Id INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Salary DECIMAL(18,2),
    Status BIT
)