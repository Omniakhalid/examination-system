using ExaminationSystem.Context;

namespace ExaminationSystem
{
    public partial class Form1 : Form
    {
        public static string studID;
        public Form1()
        {
            InitializeComponent();
        }
        frmTeacher frmTeacher = new frmTeacher();
        frmStudentCoursecs studentCoursecs = new frmStudentCoursecs();

        private async void btnLgn_Click(object sender, EventArgs e)
        {
            bool isblank = false;
            if (txtName.Text.Length == 0)
            {
                isblank = true;
                MessageBox.Show("lUser Name Cannot be Left Blank...");
            }
            else if (txtID.Text.Length == 0)
            {
                isblank = true;
                MessageBox.Show("ID Cannot be Left Blank...");
            }
            else if (cmbType.Text.Length == 0)
            {
                isblank = true;
                MessageBox.Show("Please Select a Role...");
            }

            if (!isblank)
            {
                if (cmbType.SelectedIndex == 0)//instuctor
                {
                    using (var db = new ExamprojectContext())
                    {
                        var proc = new ExamprojectContextProcedures(db);
                        var result = await proc.get_instAsync(int.Parse(txtID.Text));
                        if (result == null)
                        {
                            MessageBox.Show("username and or password are not found");
                            txtName.Clear(); txtID.Clear(); txtName.Focus();
                        }
                        else
                        {
                            this.Hide();
                            frmTeacher.Show();
                        }
                    }
                }
                else//student
                {
                    using (var db = new ExamprojectContext())
                    {
                        var proc = new ExamprojectContextProcedures(db);
                        var result = await proc.get_studAsync(int.Parse(txtID.Text));
                        if (result == null)
                        {
                            MessageBox.Show("username and or password are not found");
                            txtName.Clear(); txtID.Clear(); txtName.Focus();
                        }
                        else
                        {
                            studID = txtID.Text;
                            this.Hide();
                            studentCoursecs.Show();
                        }
                    }
                }
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //for (int j = 0; j < 4; j++)
            //{
            //    Console.WriteLine(rnd.Next(1, 21));//returns random integers < 10}
            //}

            //Random rnd = new Random(); for (int j = 0; j < 4; j++)
            //{
            //    Console.WriteLine(rnd.Next(10, 20)); // returns random integers >= 10 and < 19}
            //}
        }
    }
}