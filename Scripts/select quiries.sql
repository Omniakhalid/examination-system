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
create proc get_topics @c_name nchar(20)
as
select topic_name from Topic t
inner join Course c
on t.course_id = c.course_id and c.course_name = @c_name
----------------------------------------------------
