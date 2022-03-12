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
    public partial class frmStudentCoursecs : Form
    {
        public static string crs_id;
        public frmStudentCoursecs()
        {
            InitializeComponent();
        }
        frmExam exam = new frmExam();
        private void btnToExam_Click(object sender, EventArgs e)
        {
            crs_id = cmbExamType.SelectedValue.ToString()!;
            this.Hide();
            exam.Show();
        }

        private void frmStudentCoursecs_Load(object sender, EventArgs e)
        {
            using (var db = new ExamprojectContext())
            {
                var result = (from c in db.Courses
                              from s in db.StudCourses
                              where c.CourseId == s.CourseId && s.StudId == Convert.ToInt32(Form1.studID)
                              select c.CourseName).ToList();
                cmbExamType.DisplayMember = "course_name";
                cmbExamType.ValueMember = "course_id";
                cmbExamType.DataSource = result;
            }
        }
    }
}
