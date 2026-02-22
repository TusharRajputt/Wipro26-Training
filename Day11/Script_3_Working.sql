-- EmployDetails(Empno,Ename,Salary,SalaryDate,AadharNo,DeptNo) 

Use Wipro26 
GO

IF EXISTS(SELECT * FROM Sysobjects WHERE Name='EmployDetails') 
DROP TABLE EmployDetails 
GO

Create Table EmployDetails
(
   Empno INT,
   Ename VARCHAR(30) NOT NULL,
   Salary Numeric(9,2),
   SalaryDate DATE,
   AadharNo varchar(30),
   DeptNo INT,
   CONSTRAINT PK_EmployDetails_EmpnoSalDate Primary Key(Empno,SalaryDate)
)
GO

Insert into EmployDetails(Empno,Ename,Salary,SalaryDate,AadharNo,DeptNo)
values(1,'Pranav',84823,'01-01-2026','84823884844',10),
(1,'Pranav',84823,'02-01-2026','84823884844',10),
(2,'Pranav',84823,'01-02-2026','84823884844',11),
(2,'Pranav',84823,'02-02-2026','84823884844',11)
GO

select * from EmployDetails
GO
