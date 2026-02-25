alter FUNCTION fnAgentTable(@AgentID int,@end int) returns @table
table(FirstName varchar(20),SSN varchar(25),CITY varchar(25))
as
begin
      insert into @table(FirstName,SSN,CITY)
      select FIRSTNAME,SSN,CITY from AGENT
	    where AGENTID between @agentID and @end
      return
end  

select * from dbo.fnAgentTable(1,10)