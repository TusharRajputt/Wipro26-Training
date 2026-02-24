-- Display Max Salary

select max(basic) from Employ
GO

-- Display Employ Name who is getting max. salary 

select name from Employ WHERE Basic = (select Max(Basic) from Employ) 
GO

-- Display 2nd max. salary 

select max(basic) from Employ WHERE Basic < (select max(basic) from Employ) 
GO

-- Display Name of Employ who is getting 2nd max. Salary 

Select Name
from Employ WHERE Basic =  
(select max(basic) from Employ WHERE Basic < (select max(basic) from Employ))
Go
