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
    public partial class frmGrade : Form
    {
        public frmGrade()
        {
            InitializeComponent();
        }

        private void frmGrade_Load(object sender, EventArgs e)
        {
            using (var db = new ExamprojectContext())
            {
                var proc = new ExamprojectContextProcedures(db);
                proc.correctExamAsync(20, Convert.ToInt32(Form1.studID), 2);//ex,std,crs

                //ex 7 stud 101 crs1,2                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ExamprojectContext())
            {
                var result = (from g in db.StudCourses
                              where g.StudId == Convert.ToInt32(Form1.studID) && g.CourseId == 2
                              select g.CourseGrade
                            ).ToList();
                label2.Text = result[0].ToString()+"0";

            }
        }
    }
}
