create proc prcAgentSrchout @AgentID int,@FirstName varchar(30)
output,@LastName varchar(30) output,@City varchar(30) output,
@ssn varchar(30) output
as
   if exists(select * from agent where agentid=@AgentID)
   begin
    select @FirstName=FirstName,@LastName=LastName,
     @City=City,@SSN=SSN from Agent where AgentID=@AgentID
    return 0
   end
   else 
    return 1

create proc prcAgentExecOut @AgentId int
as
   declare @FirstName varchar(30),@LastName varchar(30),
   @city varchar(30),@ssn varchar(30),@ret int 
   exec @ret=prcAgentSrchout @AgentID,@FirstName output,
@LastName output,@City output,@SSn output
   if @ret=0
   begin 
     print 'First Name ' +@FirstName
     print 'Last Name ' +@LastName
     print 'City   ' +@city
     print 'SSN   ' +@ssn
   end
   else
     print 'Record not found...'

prcAgentExecOut 2