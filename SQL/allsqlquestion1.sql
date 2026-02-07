---------------------------------------

Select * from EmployeeMaster
Select * from Sales
Select * from Department

----------q2------------------------------
ALTER TABLE EmployeeMaster
ADD BonusPoints INT DEFAULT 0;
-------------q3---------------
alter table EmployeeMaster add constraint bp check(BonusPoints between 0 and 100);
---------q4---------------
select EmployeeMaster.EmpName,Department.DepartmentName,Month(Sales.SaleDate) as Month, Year(Sales.SaleDate) as Year,Sales.SaleAmount 
FROM EmployeeMaster INNER JOIN Department on Department.DepartmentId = EmployeeMaster.DepartmentId INNER JOIN  Sales On Sales.EmpId = EmployeeMaster.EmpId 
------q5--calculate total sales for current year-----------
Select EmployeeMaster.EmpName,Sum(Sales.SaleAmount) as TotalSales from EmployeeMaster inner join Sales on Sales.EmpId = EmployeeMaster.EmpId
where Year(Sales.SaleDate) = year(GetDate()) Group by EmployeeMaster.EmpName
-----------q6---------
select EmployeeMaster.EmpName, Substring(EmployeeMaster.EmpName,1,3)+Left(Department.DepartmentName,2)+CAST(EmployeeMaster.EmpId AS VARCHAR) AS Username from EmployeeMaster inner join Department on EmployeeMaster.DepartmentId = Department.DepartmentId
---------q7-------------
SELECT EmpName from EmployeeMaster where EmpId in(Select EmpId from Sales group by EmpId having Sum(SaleAmount)>(Select avg(SaleAmount) from Sales));
------------q8---------------
SELECT EmployeeMaster.EmpName,Sum(Sales.SaleAmount) as totalSales, 'High' as Category from EmployeeMaster inner join Sales on EmployeeMaster.EmpId = Sales.EmpId
where Sales.SaleAmount > 50000 group by EmployeeMaster.EmpName
union
SELECT EmployeeMaster.EmpName,Sum(Sales.SaleAmount) as totalSales, 'Low' as Category from EmployeeMaster inner join Sales on EmployeeMaster.EmpId = Sales.EmpId
where Sales.SaleAmount < 10000 group by EmployeeMaster.EmpName
--------q9--------
ALTER TRIGGER trg_UpdateBonusPoints
ON dbo.Sales
AFTER INSERT
AS
BEGIN
UPDATE em SET em.BonusPoints = ISNULL(em.BonusPoints, 0) +
CASE
WHEN i.SaleAmount >= 50000 THEN 10
WHEN i.SaleAmount >= 20000 THEN 5
ELSE 0
END
FROM dbo.EmployeeMaster em INNER JOIN inserted i ON em.EmpId = i.EmpId;
END;
SELECT EmpId, BonusPoints FROM EmployeeMaster WHERE EmpId = 101;

INSERT INTO Sales (EmpId, SaleDate, SaleAmount)
VALUES (101, GETDATE(), 60000);

-----------------------------q10---------
SELECT EmployeeMaster.EmpName, Department.DepartmentName,Sum(Sales.SaleAmount),EmployeeMaster.BonusPoints,
case
when 
EmployeeMaster.BonusPoints >= 50 then 'A'
when EmployeeMaster.BonusPoints between 20 and 49 then 'B'
else 'C' end as Performance
from EmployeeMaster inner join Department on EmployeeMaster.DepartmentId = Department.DepartmentId
        inner join Sales on Sales.EmpId = EmployeeMaster.EmpId group by EmployeeMaster.EmpName,Department.DepartmentName,
        EmployeeMaster.BonusPoints
   




