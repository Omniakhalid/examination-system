--1----------------------------------------------------------------
create proc delete_crs @id int
as
delete from topic where course_id=@id
delete from Inst_course where course_id=@id 
delete from Stud_course where course_id=@id
exec delete_crs_questions @id
delete from exam where course_id=@id
delete from Course where course_id=@id
delete_crs 1
---=======================================
create proc delete_crs_questions @crs_id int 
as 
delete from Exam_choices where Q_id in (select Q_id from Question  where course_id=@crs_id)
delete from Q_ex_stud where Q_id in (select Q_id from Question  where course_id=@crs_id)
delete from question where course_id=@crs_id

delete_crs_questions 2

-------------------------------------------
--2
create proc delete_dept @id int
as
update Instructor  set dept_id= null where dept_id=@id
update Student set dept_id= null where dept_id=@id
delete from Department 
where dept_id = @id

delete_dept 1

------------------------------------------
--3
create proc delete_exam @id int
as
delete from Q_ex_stud where ex_id=@id
delete from Exam where exam_id = @id

delete_exam 1

--------------------------------------------
--4
create proc delete_exam_choices @id int
as
delete from Exam_choices
where Q_id = @id

delete_exam_choices 1

---------------------------------------------
--5  many to many table so we will delete the parents only 

--------------------------------------------------
--6 
create proc delete_instructor @id int 
as
delete from Inst_course where inst_id=@id
delete from Instructor  where inst_id=@id

delete_instructor 2

--------------------------------------------------
--7-- delete student answer in an exam 
create proc  delete_Q_ex_stud @Q_id int, @ex_id int , @stud_id int
as
delete from Q_ex_stud
where( Q_id=@Q_id and ex_id=@ex_id and stud_id=@stud_id)

delete_Q_ex_stud 7,1,1

--------------------------------------------------
--8
create proc  delete_Question @Q_id int, @ex_id int 
as 
delete from Exam_choices where Q_id = @Q_id
delete from Q_ex_stud where Q_id = @Q_id and ex_id=@ex_id
delete from Question
where  Q_id=@Q_id

delete_Question 1,2

----------------------------------------------------
--9
create proc delete_stud_course @st_id int ,@crs_id int
as
delete from Stud_course where stud_id=@st_id and course_id=@crs_id

delete_stud_course 1 ,2 
----------------------------------------------------
--10
create proc delete_student @id int 
as 
delete from  Stud_course where  stud_id=@id 
delete from Q_ex_stud where stud_id=@id
delete from student where std_id=@id 

delete_student 1
----------------------------------------------------
--11
create proc delete_topic @topic_id int 
as 
delete from topic where topic_id=@topic_id

delete_topic 1 

----------------------------------------------------
--create proc update_dept @name nchar(50),@id int
--with encryption
--as
--update Department
--set dept_name = @name
--where dept_id = @id
---------------------------------------------------
