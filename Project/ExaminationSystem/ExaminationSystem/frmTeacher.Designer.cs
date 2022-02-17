namespace ExaminationSystem
{
    partial class frmTeacher
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
            this.cmbCrsType = new System.Windows.Forms.ComboBox();
            this.txtNumT_F = new System.Windows.Forms.TextBox();
            this.txtNumMcq = new System.Windows.Forms.TextBox();
            this.lblCrsType = new System.Windows.Forms.Label();
            this.lblT_FQuestions = new System.Windows.Forms.Label();
            this.lblMcqQuestions = new System.Windows.Forms.Label();
            this.btnExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCrsType
            // 
            this.cmbCrsType.FormattingEnabled = true;
            this.cmbCrsType.Items.AddRange(new object[] {
            "C#",
            "JavaScript"});
            this.cmbCrsType.Location = new System.Drawing.Point(447, 265);
            this.cmbCrsType.Name = "cmbCrsType";
            this.cmbCrsType.Size = new System.Drawing.Size(182, 33);
            this.cmbCrsType.TabIndex = 19;
            // 
            // txtNumT_F
            // 
            this.txtNumT_F.Location = new System.Drawing.Point(447, 171);
            this.txtNumT_F.Name = "txtNumT_F";
            this.txtNumT_F.Size = new System.Drawing.Size(182, 31);
            this.txtNumT_F.TabIndex = 18;
            // 
            // txtNumMcq
            // 
            this.txtNumMcq.Location = new System.Drawing.Point(447, 66);
            this.txtNumMcq.Name = "txtNumMcq";
            this.txtNumMcq.Size = new System.Drawing.Size(182, 31);
            this.txtNumMcq.TabIndex = 17;
            // 
            // lblCrsType
            // 
            this.lblCrsType.AutoSize = true;
            this.lblCrsType.Location = new System.Drawing.Point(172, 265);
            this.lblCrsType.Name = "lblCrsType";
            this.lblCrsType.Size = new System.Drawing.Size(109, 25);
            this.lblCrsType.TabIndex = 15;
            this.lblCrsType.Text = "Course Type";
            // 
            // lblT_FQuestions
            // 
            this.lblT_FQuestions.AutoSize = true;
            this.lblT_FQuestions.Location = new System.Drawing.Point(172, 171);
            this.lblT_FQuestions.Name = "lblT_FQuestions";
            this.lblT_FQuestions.Size = new System.Drawing.Size(170, 25);
            this.lblT_FQuestions.TabIndex = 16;
            this.lblT_FQuestions.Text = "no of T_F Questions";
            // 
            // lblMcqQuestions
            // 
            this.lblMcqQuestions.AutoSize = true;
            this.lblMcqQuestions.Location = new System.Drawing.Point(172, 66);
            this.lblMcqQuestions.Name = "lblMcqQuestions";
            this.lblMcqQuestions.Size = new System.Drawing.Size(186, 25);
            this.lblMcqQuestions.TabIndex = 14;
            this.lblMcqQuestions.Text = "no of MCQ Questions";
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(264, 351);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(266, 34);
            this.btnExam.TabIndex = 13;
            this.btnExam.Text = "Generate Exam";
            this.btnExam.UseVisualStyleBackColor = true;
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCrsType);
            this.Controls.Add(this.txtNumT_F);
            this.Controls.Add(this.txtNumMcq);
            this.Controls.Add(this.lblCrsType);
            this.Controls.Add(this.lblT_FQuestions);
            this.Controls.Add(this.lblMcqQuestions);
            this.Controls.Add(this.btnExam);
            this.Name = "frmTeacher";
            this.Text = "frmTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbCrsType;
        private TextBox txtNumT_F;
        private TextBox txtNumMcq;
        private Label lblCrsType;
        private Label lblT_FQuestions;
        private Label lblMcqQuestions;
        private Button btnExam;
    }
}