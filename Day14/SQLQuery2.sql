create proc prcagentins @FirstName varchar(30),@MI varchar(1),
@LastName varchar(30),@Gender
varchar(10),@DOB DateTime,@SSN varchar(20),@MaritalStatus int,
@Address1 varchar(30),@Address2 varchar(30),@city varchar(20),
@state varchar(10),@ZipCode varchar(20),@Country varchar(20),
@AgentId int Output,@FullName varchar(80) output
as
    select @FullName=@FirstName + ' ' + @Mi + ' ' +@LastName
    Insert Into Agent(FirstName,MI,LastName,Gender,DOB,SSN,
MaritalStatus,Address1,Address2,City,State,ZipCode,Country)
   values(@FirstName,@Mi,@LastName,@Gender,@DOB,@SSN,
@MaritalStatus,@Address1,@Address2,@CIty,@state,@ZipCode,
@Country)
    select @AgentID=Scope_Identity()

create proc prcAgentInsOut @FirstName varchar(30),@MI varchar(1),
@LastName varchar(30),@Gender
varchar(10),@DOB DateTime,@SSN varchar(20),@MaritalStatus int,
@Address1 varchar(30),@Address2 varchar(30),@city varchar(20),
@state varchar(10),@ZipCode varchar(20),@Country varchar(20)
as
   declare @AgentID int,@FullName varchar(30)
   exec prcagentins @FirstName,@MI,@LastName,@Gender,@DOB,
@SSN,@MaritalStatus,@Address1,@Address2,@city,@state,
@ZipCode,@Country,@AgentID output,@FullName output
   print 'Agent Id  ' +convert(varchar(30),@AgentID)
   print 'Full Name ' +@FullName

prcAgentInsOut 'Komala','M','Mahesh','Female','12/12/1987',
'123-44-2111',1,'TRT 81','S Heights','Detroit','MI',
'44833','USA'
