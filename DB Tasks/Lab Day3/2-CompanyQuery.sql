use Company;
--1--
select DNUMBER, DNAME,SSN, FNAME from DEPARTMENT inner join EMPLOYEE 
on DEPARTMENT.DNUMBER=EMPLOYEE.DNO;
--2--
select DNAME, PNAME from DEPARTMENT inner join PROJECT 
on DEPARTMENT.DNUMBER=PROJECT.DNUM;
--3--
select DEPENDENT.*, FNAME from DEPENDENT inner join EMPLOYEE
on EMPLOYEE.SSN=DEPENDENT.ESSN;
--4--
select PNUMBER, PNAME, PLOCATION from PROJECT where PLOCATION in ('Cairo' , 'Alex ');
--5--
select * from PROJECT where PNAME like 'a%';
--6--
select FNAME from EMPLOYEE where DNO=30 and SALARY between 1000 and 2000;
--7--
select FNAME from EMPLOYEE inner join WORKS_ON 
on EMPLOYEE.SSN=WORKS_ON.ESSN inner join PROJECT on PROJECT.PNUMBER=WORKS_ON.PNO
where DNO=10 and HOURS>=10 and PNAME='AL Rabwah';
--8--
select e.FNAME from EMPLOYEE e ,EMPLOYEE super
where super.SSN =e.SUPERSSN and super.FNAME='kamel Mohamed';
--9--
select FNAME, PNAME from EMPLOYEE inner join WORKS_ON 
on EMPLOYEE.SSN=WORKS_ON.ESSN inner join PROJECT
on PROJECT.PNUMBER=WORKS_ON.PNO order by PNAME;
--10--
select PNUMBER,DName, LNAME, ADDRESS, BDATE  from EMPLOYEE inner join DEPARTMENT
on EMPLOYEE.SSN=DEPARTMENT.MGRSSN inner join WORKS_ON 
on EMPLOYEE.SSN=WORKS_ON.ESSN inner join PROJECT
on PROJECT.PNUMBER=WORKS_ON.PNO where PLOCATION='cairo';
--11--
select * from Employee ,Department
where ssn=MGRSSN

--12--
select * from Employee left outer join Dependent
on ssn=essn
--13--
insert into Employee (Fname,Lname ,SSN ,BDATE,ADDRESS,SEX ,Salary ,Superssn,DNO)
values ('Ahmed','noor',102672 ,'1999-07-17','Egypt','Male',3000,112233,30);
--14--
insert into Employee (Fname,Lname ,Dno ,ssn )
values ('Amera','Ali',25 ,102660);
--15--
update Employee set Salary+=Salary*.20




