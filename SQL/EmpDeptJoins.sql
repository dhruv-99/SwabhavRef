select * from EMP;

select EMP.ENAME, DEPT.DNAME 
from EMP join DEPT 
on EMP.DEPTNO = DEPT.DEPTNO;

select * 
from DEPT left join EMP 
on EMP.DEPTNO = DEPT.DEPTNO;

select DEPT.* 
from DEPT left join EMP 
on EMP.DEPTNO = DEPT.DEPTNO
where EMPNO is null;

select EMP1.ENAME, EMP2.ENAME as BOSSNAME
from EMP as EMP1 left join EMP as EMP2
on EMP1.MGR = EMP2.EMPNO ;

select EMP1.ENAME, EMP2.ENAME as BOSSNAME, DEPT.DNAME 
from EMP as EMP1 left join EMP as EMP2
on EMP1.MGR = EMP2.EMPNO join DEPT 
on EMP1.DEPTNO = DEPT.DEPTNO;

Select DEPTNO, count(EMPNO) 
as EMPLOYEES 
from EMP
group by DEPTNO; 

Select JOB, count(EMPNO) 
as EMPLOYEES 
from EMP
group by JOB; 

Select JOB, DEPTNO, count(EMPNO) 
as EMPLOYEES 
from EMP
group by JOB, DEPTNO; 

select DEPTNO, JOB, count(EMPNO) 
from EMP 
where DEPTNO = 10 AND JOB = 'MANAGER'
group by DEPTNO, JOB;

Select DNAME, count(EMPNO) 
as EMPLOYEES 
from DEPT left join EMP
on EMP.DEPTNO = DEPT.DEPTNO
group by DEPT.DNAME; 

Select DNAME, count(EMPNO) 
as EMPLOYEES 
from DEPT left join EMP
on EMP.DEPTNO = DEPT.DEPTNO
group by DEPT.DNAME
having count(EMPNO) < 5; 