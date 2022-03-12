using ExaminationSystem.Context;
using ExaminationSystem.Entities;
using Microsoft.Data.SqlClient;
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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private async void btnExam_Click(object sender, EventArgs e)
        {
            using (var db = new ExamprojectContext())
            {
                var procedures = new ExamprojectContextProcedures(db);
                await procedures.generateExamAsync(cmbCrsType.SelectedIndex + 1, int.Parse(txtNumT_F.Text), int.Parse(txtNumMcq.Text));
                MessageBox.Show("Exam Created Successfully!");
            }
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
        }
    }
}
