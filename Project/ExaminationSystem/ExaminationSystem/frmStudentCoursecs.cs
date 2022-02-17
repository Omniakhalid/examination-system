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
        public frmStudentCoursecs()
        {
            InitializeComponent();
        }
        frmExam exam = new frmExam();
        private void btnToExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            exam.Show();
        }
    }
}
