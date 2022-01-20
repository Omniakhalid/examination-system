--1
create proc insert_dept @id int, @name nchar(50)
with encryption
as
insert into Department values(@id,@name)
--------------------------------------------------
--2
create proc insert_exam @id int, @duration time(7), @course_id int
with encryption
as
insert into Exam values(@id,@duration,@course_id)
--------------------------------------------------
--3
alter proc insert_exam_choices @id int, @choices nvarchar(100)
with encryption
as
IF EXISTS
(select Q_id from Question where Q_id = @id)
    BEGIN
        insert into Exam_choices values(@id,@choices)
		PRINT 'inserted';
END;
----------------------------------------------------
--4
create proc insert_inst_courses @c_id int, @inst_id int
with encryption
as
IF EXISTS
(select course_id from Course where course_id = @c_id )and EXISTS (select inst_id from Instructor where inst_id = @inst_id)
    BEGIN
        insert into Inst_course values(@c_id,@inst_id)
		PRINT 'inserted';
END;
-------------------------------------------------------
--5
create proc insert_inst @id int, @name nchar(50),@dept_id int
with encryption
as
insert into Instructor values(@id,@name,@dept_id)
------------------------------------------------------
--6
create proc insert_student_answer @q_id int, @ex_id int,@stud_id int,@std_answer nchar(20)
with encryption
as
IF EXISTS
(select Q_id from Question where Q_id = @q_id )and EXISTS
(select exam_id from Exam where exam_id = @ex_id)
and EXISTS(select std_id from Student where std_id = @stud_id )
    BEGIN
        insert into Q_ex_stud values(@q_id,@ex_id,@stud_id,@std_answer)
		PRINT 'insertd';
END;
------------------------------------------------------
--7
create proc insert_question @id int, @q_desc nvarchar(max),@q_type nchar(20),
						@model_answer nvarchar(max),@grade int,@c_id int
with encryption
as
insert into Question values(@id,@q_desc,@q_type,@model_answer,@grade,@c_id)
--------------------------------------------------------
--8
create proc insert_stud_courses @c_id int, @std_id int,@crs_grade int
with encryption
as
IF EXISTS
(select course_id from Course where course_id = @c_id )and EXISTS (select std_id from Student where std_id = @std_id)
    BEGIN
        insert into Stud_course values(@c_id,@std_id,@crs_grade)
		PRINT 'inserted';
END;
---------------------------------------------------------
--9
create proc insert_stud @id int, @f_name nchar(20), @l_name nchar(20),@dept_id int
with encryption
as
insert into Student values(@id,@f_name,@l_name,@dept_id)
---------------------------------------------------------
--10
create proc insert_topics @id int, @topic_name nchar(50), @crs_id int
with encryption
as
insert into Topic values(@id,@topic_name,@crs_id)
----------------------------------------------------------
--11
create proc insert_course @id int, @crs_name nchar(20)
with encryption
as
insert into Course values(@id,@crs_name)












