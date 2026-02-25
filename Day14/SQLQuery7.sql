create table TempAgent
(
    EntityId int Identity(1,1),
    FirstName varchar(40),
    SSN varchar(40)
)

truncate Table TempAgent


select * from TempAgent

Create Table AgentC
(
  AgentID int identity(1,1) primary key,
  FirstName varchar(15),SSN varchar(50)
)


CREATE TABLE Error
(ErrorID int identity(1,1),
EntityID int,
ErrorMsg varchar(250),
ColumnName varchar(250)
)

create function fnFirstNamevalidate(@FirstName varchar(15))
returns int
as
begin
  declare @ret int 
  if (@FirstName is null or len(@FirstName) > 50 
  or @FirstName like '%[^a-zA-Z]%')
	set @ret=0
  else  
   set @ret=1
  return @ret
end    
 
create function fnSSNValidate(@SSN varchar(20))
returns int 
as
begin
   declare @ret int
   if @ssn NOT LIKE 
'[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'
   set @ret=0
   else
   set @ret=1
   return @ret
end  


alter proc prcAgentTransfer
as
Insert into Error(EntityId,ErrorMsg,ColumnName)
select EntityID,'First Name is Invalid','FirstName' 
from TempAgent where dbo.fnFirstNamevalidate(FirstName)=0

Insert Into Error(EntityID,ErrorMsg,ColumnName)
select EntityID,'SSN is Not in Proper Format','SSN'
from TempAgent where dbo.fnSSNValidate(SSN)=0

Insert into AgentC(FirstName,SSN) 
select FirstName,SSN from TempAgent where 
EntityID <> All(Select EntityID from Error)

prcAgentTransfer

select * from AgentC

select * from Error

