create function CalcSum(@a int,@b int) returns int
as
begin
     declare @c int
     set @c=@a+@b
	 return @c
end

select dbo.CalcSum(12,-4)

create function factorial(@n int) returns int 
as
begin
   declare @i int,@f int 
   set @i=1
   set @f=1
   while @i <= @n
   begin
      set @f=@f*@i
      set @i=@i+1
   end
  return @f
end

select dbo.factorial(5)

create function fnDiscount(@amount int) returns float
as
begin
    return @amount*0.05
end

select PolicyId,AnnualPremium,dbo.fndiscount(AnnualPremium) 
as Discount,AnnualPremium-dbo.fndiscount(AnnualPremium)
'Cash on Hand'
from Policy


-- NCR 

create function ncr(@n int,@r int) returns int 
as
begin
   declare @r1 int,@r2 int,@r3 int,@res int
   select @r1=dbo.factorial(@n)
   select @r2=dbo.factorial(@n-@r)
   select @r3=dbo.factorial(@r)
   select @res=((@r1)/(@r2*@r3))
   return @res
end

select dbo.ncr(6,3)

