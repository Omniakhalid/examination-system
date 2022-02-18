create proc displayAllStudentInfo_Deptid @id int
as
select * from Student s
inner join Department d
on d.dept_id=@id and d.dept_id=s.dept_id 

displayAllStudentInfo_Deptid 10

---2

create proc gradesStudentAllCourses @st_id int
as
select c.course_name,s.course_grade from Stud_course s
inner join Course c
on s.stud_id=@st_id and c.course_id=s.course_id

gradesStudentAllCourses 100

--3
alter proc nameCourses_noStudents @ins_id int 
as
select c.course_name, COUNT(s.stud_id) as studentNumbers from Inst_course i 
inner join Course c 
on i.inst_id=@ins_id and i.course_id=c.course_id
inner join Stud_course s
on s.course_id=i.course_id
group by c.course_name

nameCourses_noStudents 1


--4
create proc topicsINCourse @crs_id int 
as
select t.topic_name from Topic t
inner join Course c
on t.course_id=c.course_id and c.course_id=@crs_id

topicsINCourse 1

--5
alter proc QuestionsChoicesinExam @ex_id int 
as
select q.Question, e.choices from Q_ex_stud qex 
inner join Question q
on qex.ex_id=@ex_id and qex.Q_id=q.Q_id
inner join Exam_choices e
on e.Q_id=q.Q_id


QuestionsChoicesinExam 1

--6
create proc examAnswers @ex_id int ,@st_id int 
as
select q.Question,qex.std_answer from Q_ex_stud qex 
inner join Question q
on qex.ex_id=@ex_id and qex.stud_id=@st_id and qex.Q_id=q.Q_id

examAnswers 1,1 