namespace ExaminationSystem
{
    partial class frmStudentCoursecs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExamType = new System.Windows.Forms.Label();
            this.btnToExam = new System.Windows.Forms.Button();
            this.cmbExamType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblExamType
            // 
            this.lblExamType.AutoSize = true;
            this.lblExamType.Location = new System.Drawing.Point(173, 127);
            this.lblExamType.Name = "lblExamType";
            this.lblExamType.Size = new System.Drawing.Size(163, 25);
            this.lblExamType.TabIndex = 5;
            this.lblExamType.Text = "select Exam Course";
            // 
            // btnToExam
            // 
            this.btnToExam.Location = new System.Drawing.Point(319, 262);
            this.btnToExam.Name = "btnToExam";
            this.btnToExam.Size = new System.Drawing.Size(254, 69);
            this.btnToExam.TabIndex = 4;
            this.btnToExam.Text = "Start Exam";
            this.btnToExam.UseVisualStyleBackColor = true;
            this.btnToExam.Click += new System.EventHandler(this.btnToExam_Click);
            // 
            // cmbExamType
            // 
            this.cmbExamType.FormattingEnabled = true;
            this.cmbExamType.Location = new System.Drawing.Point(445, 119);
            this.cmbExamType.Name = "cmbExamType";
            this.cmbExamType.Size = new System.Drawing.Size(182, 33);
            this.cmbExamType.TabIndex = 3;
            // 
            // frmStudentCoursecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExamType);
            this.Controls.Add(this.btnToExam);
            this.Controls.Add(this.cmbExamType);
            this.Name = "frmStudentCoursecs";
            this.Text = "frmStudentCoursecs";
            this.Load += new System.EventHandler(this.frmStudentCoursecs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblExamType;
        private Button btnToExam;
        private ComboBox cmbExamType;
    }
}