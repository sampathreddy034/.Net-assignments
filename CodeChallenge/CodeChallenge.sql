use CaseStudy

Create table Employee(
Empno int primary key,
Empname varchar(30),
Empsal numeric(10,2), check(Empsal>=25000),
Emptype char,check(Emptype in ('C','P'))
)

Create or alter proc EmpInsert @Eid int,@Ename varchar(20),@Esal numeric(10,2),@Etype char
as
begin
   insert into Employee values(@Eid,@Ename,@Esal,@Etype)
end


select execution_count from sys.dm_exec_procedure_stats qt WHERE qt.object_id = OBJECT_ID('EmpInsert')