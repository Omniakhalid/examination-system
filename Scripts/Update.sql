--1
create proc update_stud (@id           int,
                        @first_name    nchar(20),
                        @last_name     nchar(20),
                        @dept_id        int)
as
UPDATE Student
SET f_name = @first_name,
    l_name = @last_name,
    dept_id = @dept_id
where  std_id = @id
--------------------------------------------------
--2
create proc update_inst (@id           int,
                        @name   nchar(50),
                        @dept_id        int)
as
UPDATE Instructor
SET inst_name = @name,
    dept_id = @dept_id
where  inst_id = @id
-------------------------------------------------
--3
create proc update_course (@id           int,
                        @name    nchar(20))
as
UPDATE Course
SET course_name = @name
where course_id = @id
--------------------------------------------------
--4
create proc update_dept (@id           int,
                        @name    nchar(50))
as
UPDATE Department
SET dept_name = @name
where  dept_id = @id
---------------------------------------------------
--5
create proc update_exam (@id           int,
                        @duration    time(7),
                        @course_id     int)
as
UPDATE Exam
SET duration = @duration,
    course_id = @course_id
where  exam_id = @id
---------------------------------------------------
--6
create proc update_question_choices (@id           int,
                        @choices    nchar(100))
as
UPDATE Exam_choices
SET choices = @choices
where  Q_id = @id
----------------------------------------------------
--7
create proc update_instructor_courses(@id           int,
                                      @course_id        int)
as
UPDATE Inst_course
SET course_id = @course_id
where  inst_id = @id
----------------------------------------------------*****
--8
create proc update_q_stud_answer (@id           int,
						@Q_id           int,
                        @ex_id        int,
                        @std_answer     nchar(20))
as
UPDATE Q_ex_stud
SET Q_id = @Q_id,
    ex_id = @ex_id,
    std_answer = @std_answer
where  stud_id = @id
------------------------------------------------------
--9.1
create proc update_course_questions (@id           int,
						@Q_id           int,
                        @Question    nvarchar(MAX),
                        @Q_type     nchar(20),
                        @Q_model_answer  nvarchar(MAX),       
						@grade			int)
as
UPDATE Question
SET Q_id = @Q_id,
    Question = @Question,
	Q_type = @Q_type,
	Q_model_answer = @Q_model_answer,
    grade = @grade
where  course_id = @id
---------------------------------------------------------
--9.2
create proc update_course_questions2 (@id           int,
                        @Question    nvarchar(MAX),
                        @Q_type     nchar(20),
                        @Q_model_answer  nvarchar(MAX),       
						@grade			int,
						@course_id      int)
as
UPDATE Question
SET Question = @Question,
	Q_type = @Q_type,
	Q_model_answer = @Q_model_answer,
    grade = @grade,
	course_id = @course_id
where  Q_id = @id
---------------------------------------------------------
--10
create proc update_std_courses (@id           int,
                        @course_id        int,
						@course_grade	  int)
as
UPDATE Stud_course
SET course_id = @course_id,
    course_grade = @course_grade
where  stud_id = @id
---------------------------------------------------------
--11
create proc update_course_topics (@id           int,
                        @topic_name    nchar(50),
                        @topic_id        int)
as
UPDATE Topic
SET topic_id = @topic_id,
    topic_name = @topic_name
where  course_id = @id
