-- Display Matching records from Employ and LeaveDetails table 

select * from Employ WHERE Empno = (select Empno From LeaveDetails) 
GO

select * from Employ WHERE EMpno = ANY(select Empno FROM LeaveDetails) 
GO

-- Display Unmatched Records from Employ and LeaveDetails Table (This acts AS DIFFERENCE Operator) 

-- DIsplay employ details who are not table any leave 

SELECT * from Employ WHERE EMPNO <> ALL(Select Empno From LeaveDetails) 
GO

-- Display Agent Details who did policy (AgentId exists in Both Agent and AgentPolicy Tables) 

select * from Agent WHERE AgentID = ANY(select AgentID FROM AgentPolicy) 
GO

-- Display IDLE Agents (AgentId Exists in Agent Table, but not in AgentPolicy Table) 

SELECT * From Agent WHERE AgentID <> ALL(Select AgentID FROM AgentPolicy) 
GO

-- Display Matching Policies (PolicyId Exists in Both Policy and AgentPolicy Tables) 

SELECT *
FROM Policy WHERE PolicyID = ANY (Select PolicyID From AgentPolicy) 
GO

-- Display Idle Policies (PolicyID Exists in Policy Table, But not in AgentPolicy Table) 

Select * from Policy WHERE PolicyID <> ALL(Select PolicyID From AgentPolicy) 
GO
