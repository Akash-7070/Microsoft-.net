create procedure spEmp

@val2 nvarchar(max),
@val3 float 

as
begin
Insert  into Employee(Name,Salary) values(@val2,@val3)
end

