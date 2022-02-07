create proc generateExam @crs_id int ,@no_T_F int ,@no_mcq int
as 

declare @EID int =(select top(1)exam_id from Exam e where e.course_id = @crs_id  order by NEWID() );
--insert into Q_ex_stud (Q_id,ex_id) values (Q_id,@EID)
insert into Q_ex_stud (Q_id,ex_id)
select * FROM
(select top(@no_T_F) Q_id,e.exam_id from Question q,Exam e
where q.course_id = @crs_id and q.Q_type = 'T/F' and e.exam_id = @EID
order by NEWID())A
UNION ALL
select * FROM
(select top(@no_mcq) Q_id,e.exam_id from Question q,Exam e
where q.course_id = @crs_id and q.Q_type = 'MCQ' and e.exam_id = @EID
order by NEWID())B3
--return @EID
generateExam 1,2,3
delete from Q_ex_stud
----------------------------------------------------------------
create proc correctExam @ex_id int ,@std_id int,@crs_id int
--, @crs_grade int output
as
--DECLARE @Total INT SET @Total = 0
update Stud_course
set course_grade = (
		select count(grade) from Question q
		inner join Q_ex_stud q_ex
		on q.Q_model_answer = q_ex.std_answer --and @std_id = stud_id
		and q.course_id = course_id --and @crs_id=q.course_id
		and q.Q_id = q_ex.Q_id and ex_id = @ex_id
)where @std_id = stud_id and @crs_id=course_id
correctExam 4,1,1
select course_grade from Stud_course where stud_id =1 and course_id =1
------------------------------------------------------------------
create proc answer_question @id int,@Q_id int,@std_answer nchar(20),@crs_id int
as
update Q_ex_stud 
set std_answer = @std_answer,
Q_id = (select q.Q_id from Question q where Q_id = @Q_id and @crs_id = q.course_id)
where  stud_id = @id