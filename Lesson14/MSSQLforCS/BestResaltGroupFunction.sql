--create function BestStudent()
--returns table as
--return 

select Student_Name,Student_LastName, max(Student_Avg_mark) as 'Best group resalt'from Students
group by Student_IdGroup
--select * from Students
--select * from BestStudent()