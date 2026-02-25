create function fnGetAgentPolicy() returns Table
as
return
   select A.AgentID,FirstName,LastName,City,SSN,P.PolicyID,
   AnnualPremium,ModalPremium from Agent A Inner Join 
   AgentPolicy AP on A.AgentID=AP.AgentID Inner Join Policy P
   on P.PolicyID=Ap.PolicyID


select * from dbo.fnGetAgentPolicy()

