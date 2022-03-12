using ExaminationSystem.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class frmExam : Form
    {
        public frmExam()
        {
            InitializeComponent();
        }
        frmGrade grades = new frmGrade();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var db = new ExamprojectContext())
            {
                var proc = new ExamprojectContextProcedures(db);
                //takes answer and store it in db then correct it
                //ex,stud,qs_id,answers
                var x = proc.Exam_AnswersAsync(20, Convert.ToInt32(Form1.studID), arr[0], arr[1], arr[2], arr[3], arr[4],
                    arr[5], arr[6], arr[7], arr[8], arr[9],
                    comboBox1.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(),
                    comboBox3.SelectedValue.ToString(), comboBox4.SelectedValue.ToString(), comboBox5.SelectedValue.ToString()
                    , comboBox6.SelectedValue.ToString(), comboBox7.SelectedValue.ToString(), comboBox8.SelectedValue.ToString(),
                    comboBox9.SelectedValue.ToString(), comboBox10.SelectedValue.ToString());
               // var result =proc.correctExamAsync(20, 100, 2);//ex,std,crs
            }
            this.Hide();
            grades.Show();
        }
        Label[] q_lbls;
        ComboBox[] cmb_choices;
        int[] arr= new int[10];
        private async void frmExam_Load(object sender, EventArgs e)
        {
            //this.Text = Form1.studID;

            q_lbls = new[] { lblQ1, lblQ2, lblQ3, lblQ4, lblQ5, lblQ6, lblQ7, lblQ8, lblQ9, lblQ10 };
            cmb_choices = new[] { comboBox1,comboBox2,comboBox3,comboBox4,comboBox5,comboBox6,comboBox7,comboBox8,comboBox9,comboBox10};
            using (var db = new ExamprojectContext())
            {
                this.Text = frmStudentCoursecs.crs_id;
                //var course_id = (
                //    from c in db.Courses
                //    where c.CourseName == frmStudentCoursecs.crs_id
                //    select  c.CourseId );
                var proc = new ExamprojectContextProcedures(db);
                var res = (await proc.getcourseIDAsync(frmStudentCoursecs.crs_id)).ToList();//qes,ex
                var qs = (
                    from q in db.Questions
                    from qex in db.QExStuds
                    where qex.ExId == 20 && q.QId == qex.QId && q.CourseId == 2//int.Parse(res[0])//int.Parse(course_id)//sql // get exam id 
                    select new { q.Question1,q.QId,qex.ExId}).ToList();
                for (int i = 0; i < q_lbls.Length; i++)
                {
                    q_lbls[i].Text = qs[i].Question1;
                    arr[i]=qs[i].QId;
                    var result = await proc.questionChoicesAsync(qs[i].QId,20);//qes,ex
                    cmb_choices[i].DisplayMember = "choices";
                    cmb_choices[i].ValueMember = "choices";
                    cmb_choices[i].DataSource = result;
                }
            }
        }

        private void lblQ1_Click(object sender, EventArgs e)
        {

        }
    }
}
