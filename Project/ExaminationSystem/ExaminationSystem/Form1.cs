namespace ExaminationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        frmTeacher frmTeacher = new frmTeacher();
        frmStudentCoursecs studentCoursecs = new frmStudentCoursecs();
        private void btnLgn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (cmbType.SelectedIndex == 0)
                frmTeacher.Show();
            else
                studentCoursecs.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }
    }
}