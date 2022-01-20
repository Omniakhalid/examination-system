--1----------------------------------------------------------------
alter proc delete_crs @id int
as
delete from topic where course_id=@id
delete from Inst_course where course_id=@id 
delete from Stud_course where course_id=@id
exec delete_crs_questions @id
delete from exam where course_id=@id
delete from Course where course_id=@id
delete_crs 1
---=======================================
create proc delete_crs_questions @crsid int 
as 
delete from Exam_choices where Q_id in (select Q_id from Question  where course_id=@crsid)
delete from Q_ex_stud where Q_id in (select Q_id from Question  where course_id=@crsid)
delete from question where course_id=@crsid

delete_crs_questions 2

-------------------------------------------
--2
create proc delete_dept @id int
as
update Instructor  set dept_id= null where dept_id=@id
update Student set dept_id= null where dept_id=@id
delete from Department 
where dept_id = @id
------------------------------------------
--3
create proc delete_exam @id int
as
delete from Exam
where exam_id = @id
--------------------------------------------
--4
create proc delete_exam_choices @id int
as
delete from Exam_choices
where Q_id = @id
---------------------------------------------
--5
create proc delete_inst_crses @id int
as
delete from Exam
where exam_id = @id
--------------------------------------------------
--6
create proc  delete_Question @id int
as
delete from Question
where where Q_id=course_id
----------------------------------------------------
--7
create proc
create proc  delete_Q_ex_stud @id	int

as

if Exists (Select * from Q_ex_stud where Q_id=ex_id)
begin 
delete from Q_ex_stud
where Q_id=ex_id

end;
---------------------------------------------------
--6
create proc update_dept @name nchar(50),@id int
with encryption
as
update Department
set dept_name = @name
where dept_id = @id
---------------------------------------------------