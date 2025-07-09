use Company_SD
--1--
select d.Dependent_name, d.Sex from Dependent d, Employee e
where e.ssn=d.ESSN and d.Sex='F' and e.sex='F'
union
select d.Dependent_name, d.Sex from Dependent d, Employee e 
where e.ssn=d.ESSN and d.Sex='M' and e.sex='M'
--2--
select Pname , sum(Hours)
from Project p, Works_for w 
where p.Pnumber=w.Pno 
group by Pname
--3--
select d.* from departments d , Employee e
where d.Dnum=e.Dno and ssn=(select min(Employee.SSN) from Employee)
--4--
select d.Dname, MAX(e.Salary)[Max Salary],min(e.Salary)[Min Salary], avg(isnull(e.Salary,0))[AVG Salary]
from departments d inner join Employee e
on d.Dnum=e.Dno
group by Dname
--5--
select Fname+' '+Lname as full_name    from Employee   ,Departments
where  ssn=MGRSSN
except
select Fname+' '+Lname as full_name    from Employee   ,Dependent
where  ssn=ESSN
--6--
select d.Dnum,d.Dname,count(*) from departments d inner join Employee e 
on d.Dnum=e.Dno
group by dnum ,Dname
having  avg(Salary) <(select avg(Salary)  from Departments  ,Employee where dnum=Dno)
--7--
select Fname , Pname  from Employee e  , Project p, Departments d
where d.Dnum=p.Dnum and d.Dnum=e.Dno
 order by d.Dnum ,Lname desc,Fname desc
--8--
 select (SELECT MAX(Salary) FROM Employee) ,  (SELECT MAX(Salary) FROM Employee
  WHERE Salary NOT IN (SELECT MAX(Salary) FROM Employee ))
--9--
select Fname+' '+Lname as full_name from Employee 
intersect
select Dependent_name from Dependent
--10--
select ssn ,Fname from employee
where exists( select * from Dependent where ssn=ESSN)
--11--
insert into Departments values('DEPT IT',100,112233,1-11-2006)
--12--
update  Departments
set mgrssn=968574 
where dnum=100

update  Departments
set mgrssn=102672 
where dnum=20

update Employee
set Superssn=102672
where ssn=102660 
--13--
update Employee
set Superssn=102660
where Superssn= 223344

update Works_for
set ESSn=102660
where ESSn= 223344

update Departments
set MGRSSN=102660
where MGRSSN= 223344
delete Employee where ssn=223344

--14--
update Employee
set Salary+=Salary*.30
where ssn=(select essn from Project , Works_for where pno=Pnumber and Pname='Al Rabwah')