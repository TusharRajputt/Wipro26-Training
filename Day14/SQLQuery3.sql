CREATE proc prcAgentAll @FirstName varchar(40),    
@LastName    
varchar(40),@MI varchar(2),@DOB DateTime,    
@FullName varchar(80),    
@Gender varchar(10),@SSN    
varchar(20),@MaritalStatus int,    
@Address1 varchar(15),@Address2    
varchar(15),@City varchar(15),@State varchar(15),    
@ZipCode    
varchar(15),@country varchar(30),    
@AgentID int output,@opt int=0    
 as    
if(@opt=2)    
begin    
Insert into Agent(FirstName,MI,LastName,FullName,Gender,DOB,SSN,MaritalStatus,    
Address1,Address2,    
City,State,ZipCode,Country)    
values(@FirstName,@mi,@lastname,@FullName,@gender,@DOB,@SSN,@MaritalStatus,    
@address1,@address2,@city,@state,@zipcode,@Country)    
select @AgentId=SCOPE_IDENTITY()    
end    
if(@opt=4)    
begin    
Update Agent set    
FirstName=isnull(@FirstName,FirstName),  
MI=isnull(@mi,MI),    
LastName=isnull(@lastname,LastName),    
FullName=IsNull(@FullName,FullName),    
Gender=isnull(@gender,Gender),    
SSN=isnull(@ssn,SSN),    
DOB=ISNULL(@DOB,DOB),    
MaritalStatus=ISNULL(@MaritalStatus,MARITALSTATUS),    
Address1=isnull(@address1,Address1),    
Address2=isnull(@address1,Address2),    
City=isnull(@city,City),    
State=isnull(@state,State),    
ZipCode=isnull(@zipcode,ZipCode),    
Country=IsNull(@Country,Country)    
where AgentId=@AgentId    
end    
if(@opt=8)    
begin    
--print @agentid    
delete from Agent where AgentId=@AgentId    
end    
if(@opt=12)    
begin    
select *    
from Agent    
where AgentId=@AgentId    
end    