sp_help Employ
GO

Sp_help LeaveDetails
GO

select E.Empno, E.Name, E.Dept, E.Desig,
LD.Empno, Ld.LeaveStartDate, LD.LeaveEndDate
from Employ E INNER JOIN LeaveDetails LD 
ON E.Empno = LD.Empno
GO

SELECT A.AgentID, FirstName, LastName, City, State,
P.PolicyID, AppNumber, ModalPremium, AnnualPremium, PaymentModeID
FROM Agent A INNER JOIN AgentPolicy AP 
ON A.AgentID = AP.AgentID 
INNER JOIN Policy P ON P.PolicyID = AP.PolicyID
GO

/* Implementing Left-Outer Join */

select E.Empno, E.Name, E.Dept, E.Desig,
LD.Empno, Ld.LeaveStartDate, LD.LeaveEndDate
from Employ E LEFT JOIN LeaveDetails LD 
ON E.Empno = LD.Empno
GO

SELECT A.AgentID, FirstName, LastName, City, State,
P.PolicyID, AppNumber, ModalPremium, AnnualPremium, PaymentModeID
FROM Agent A LEFT JOIN AgentPolicy AP 
ON A.AgentID = AP.AgentID 
LEFT JOIN Policy P ON P.PolicyID = AP.PolicyID
GO

/* Implemeting RIGHT-OUTER Join */

select E.Empno, E.Name, E.Dept, E.Desig,
LD.Empno, Ld.LeaveStartDate, LD.LeaveEndDate
from Employ E RIGHT JOIN LeaveDetails LD 
ON E.Empno = LD.Empno
GO

SELECT A.AgentID, FirstName, LastName, City, State,
P.PolicyID, AppNumber, ModalPremium, AnnualPremium, PaymentModeID
FROM Agent A RIGHT JOIN AgentPolicy AP 
ON A.AgentID = AP.AgentID 
RIGHT JOIN Policy P ON P.PolicyID = AP.PolicyID
GO

/* Implemeting FULL-OUTER Join */

select E.Empno, E.Name, E.Dept, E.Desig,
LD.Empno, Ld.LeaveStartDate, LD.LeaveEndDate
from Employ E FULL JOIN LeaveDetails LD 
ON E.Empno = LD.Empno
GO

SELECT A.AgentID, FirstName, LastName, City, State,
P.PolicyID, AppNumber, ModalPremium, AnnualPremium, PaymentModeID
FROM Agent A FULL JOIN AgentPolicy AP 
ON A.AgentID = AP.AgentID 
FULL JOIN Policy P ON P.PolicyID = AP.PolicyID
GO


/* Example for Cross Join */

Select * from Employ CROSS JOIN LeaveDetails 
GO

SELECT * FROM Agent CROSS JOIN AgentPolicy 
GO






