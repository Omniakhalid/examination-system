use ExamProject
--1
create proc get_all_students
as
select * from Student
-------------------------------------------
--2
create proc get_all_departments
as
select * from Department
-------------------------------------------
--3
create proc get_all_instructors
as
select * from Instructor
-------------------------------------------
--4
create proc get_all_topics
as
select * from Topic
-------------------------------------------------
--5
create proc get_all_courses
as
select * from Course
-------------------------------------------------
--6
create proc get_all_exams
as
select * from Exam
-------------------------------------------------
--7
create proc get_all_choices
as
select * from Exam_choices
-------------------------------------------------
--8
create proc get_all_questions
as
select * from Question
-------------------------------------------------
--9
create proc get_all_choices
as
select * from Exam_choices
-------------------------------------------------
--10
create proc get_stud @id int
as
select *from Student 
where std_id =@id
--------------------------------------------------
--11
create proc get_inst @id int
as
select *from Instructor
where inst_id =@id
-------------------------------------------------
--12
create proc get_course @id int
as
select *from Course
where course_id =@id
--------------------------------------------------
--13
create proc get_dept @id int
as
select *from Department
where dept_id =@id
---------------------------------------------------
--14
create proc get_exam @id int
as
select *from Exam
where exam_id =@id
---------------------------------------------------
--15
create proc get_question_choices @id int
as
select *from Exam_choices
where Q_id =@id
----------------------------------------------------
--16
create proc get_instructor_courses @id int
as
select *from Inst_course
where inst_id =@id
----------------------------------------------------*****
--17
create proc get_q_stud_answer @st_id int
as
select std_answer from Q_ex_stud
where stud_id =@st_id
------------------------------------------------------
--18
create proc get_course_questions @c_id int
as
select *from Question
where course_id =@c_id
---------------------------------------------------------
--19
create proc get_question @id int
as
select *from Question
where Q_id =@id
---------------------------------------------------------
--20
create proc get_std_courses @st_id int
as
select *from Stud_course
where stud_id =@st_id
---------------------------------------------------------
--21
create proc get_course_topics @c_name nchar(20)
as
select topic_name from Topic t
inner join Course c
on t.course_id = c.course_id and c.course_name = @c_name
----------------------------------------------------
--22
create proc get_topics @t_id int
as
select * from Topic t
where topic_id = @t_id
