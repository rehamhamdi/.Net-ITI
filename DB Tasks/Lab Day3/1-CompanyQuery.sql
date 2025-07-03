use Company;
select * from EMPLOYEE;

select FNAME , LNAME,SALARY, DNO from EMPLOYEE;

select PNAME,PLOCATION, DNUM from PROJECT;

select [Full Name]=FNAME +' '+LNAME, ANNUAL_COMM=SALARY*12*.1 from EMPLOYEE;

select SSN,FNAME from EMPLOYEE where SALARY>1000;

select SSN,FNAME from EMPLOYEE where SALARY*12>10000;

select FNAME ,SALARY from EMPLOYEE where SEX='female';

select DNUMBER, DNAME from DEPARTMENT where MGRSSN =968574;

select PNUMBER,PNAME,PLOCATION from PROJECT where DNUM=10;
