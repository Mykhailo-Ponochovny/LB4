namespace Lab4_CSHARP_Variant3.Windows
{
    partial class MainWindow
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
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonListSubjects = new System.Windows.Forms.Button();
            this.buttonInfoAboutStudent = new System.Windows.Forms.Button();
            this.buttonRemoveSubject = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonChangeInfoAboutStudent = new System.Windows.Forms.Button();
            this.buttonChangeGrade = new System.Windows.Forms.Button();
            this.buttonChangeSubjectName = new System.Windows.Forms.Button();
            this.buttonAddStudentToSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Location = new System.Drawing.Point(12, 12);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(153, 95);
            this.buttonAddSubject.TabIndex = 0;
            this.buttonAddSubject.Text = "Додати предмет";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(171, 12);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(153, 95);
            this.buttonAddStudent.TabIndex = 1;
            this.buttonAddStudent.Text = "Додати студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonListSubjects
            // 
            this.buttonListSubjects.Enabled = false;
            this.buttonListSubjects.Location = new System.Drawing.Point(330, 12);
            this.buttonListSubjects.Name = "buttonListSubjects";
            this.buttonListSubjects.Size = new System.Drawing.Size(153, 95);
            this.buttonListSubjects.TabIndex = 2;
            this.buttonListSubjects.Text = "Список предметів";
            this.buttonListSubjects.UseVisualStyleBackColor = true;
            this.buttonListSubjects.Click += new System.EventHandler(this.buttonListSubjects_Click);
            // 
            // buttonInfoAboutStudent
            // 
            this.buttonInfoAboutStudent.Enabled = false;
            this.buttonInfoAboutStudent.Location = new System.Drawing.Point(12, 113);
            this.buttonInfoAboutStudent.Name = "buttonInfoAboutStudent";
            this.buttonInfoAboutStudent.Size = new System.Drawing.Size(153, 95);
            this.buttonInfoAboutStudent.TabIndex = 3;
            this.buttonInfoAboutStudent.Text = "Інформація про студента";
            this.buttonInfoAboutStudent.UseVisualStyleBackColor = true;
            this.buttonInfoAboutStudent.Click += new System.EventHandler(this.buttonInfoAboutStudent_Click);
            // 
            // buttonRemoveSubject
            // 
            this.buttonRemoveSubject.Enabled = false;
            this.buttonRemoveSubject.Location = new System.Drawing.Point(171, 113);
            this.buttonRemoveSubject.Name = "buttonRemoveSubject";
            this.buttonRemoveSubject.Size = new System.Drawing.Size(153, 95);
            this.buttonRemoveSubject.TabIndex = 4;
            this.buttonRemoveSubject.Text = "Видалити предмет";
            this.buttonRemoveSubject.UseVisualStyleBackColor = true;
            this.buttonRemoveSubject.Click += new System.EventHandler(this.buttonRemoveSubject_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Enabled = false;
            this.buttonDeleteStudent.Location = new System.Drawing.Point(330, 113);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(153, 95);
            this.buttonDeleteStudent.TabIndex = 5;
            this.buttonDeleteStudent.Text = "Відрахувати студента";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // buttonChangeInfoAboutStudent
            // 
            this.buttonChangeInfoAboutStudent.Enabled = false;
            this.buttonChangeInfoAboutStudent.Location = new System.Drawing.Point(12, 214);
            this.buttonChangeInfoAboutStudent.Name = "buttonChangeInfoAboutStudent";
            this.buttonChangeInfoAboutStudent.Size = new System.Drawing.Size(153, 95);
            this.buttonChangeInfoAboutStudent.TabIndex = 6;
            this.buttonChangeInfoAboutStudent.Text = "Змінити інформацію про студента";
            this.buttonChangeInfoAboutStudent.UseVisualStyleBackColor = true;
            this.buttonChangeInfoAboutStudent.Click += new System.EventHandler(this.buttonChangeInfoAboutStudent_Click);
            // 
            // buttonChangeGrade
            // 
            this.buttonChangeGrade.Enabled = false;
            this.buttonChangeGrade.Location = new System.Drawing.Point(171, 214);
            this.buttonChangeGrade.Name = "buttonChangeGrade";
            this.buttonChangeGrade.Size = new System.Drawing.Size(153, 95);
            this.buttonChangeGrade.TabIndex = 7;
            this.buttonChangeGrade.Text = "Змінити оцінку студента";
            this.buttonChangeGrade.UseVisualStyleBackColor = true;
            this.buttonChangeGrade.Click += new System.EventHandler(this.buttonChangeGrade_Click);
            // 
            // buttonChangeSubjectName
            // 
            this.buttonChangeSubjectName.Enabled = false;
            this.buttonChangeSubjectName.Location = new System.Drawing.Point(330, 214);
            this.buttonChangeSubjectName.Name = "buttonChangeSubjectName";
            this.buttonChangeSubjectName.Size = new System.Drawing.Size(153, 95);
            this.buttonChangeSubjectName.TabIndex = 8;
            this.buttonChangeSubjectName.Text = "Змінити назву предмета";
            this.buttonChangeSubjectName.UseVisualStyleBackColor = true;
            this.buttonChangeSubjectName.Click += new System.EventHandler(this.buttonChangeSubjectName_Click);
            // 
            // buttonAddStudentToSubject
            // 
            this.buttonAddStudentToSubject.Enabled = false;
            this.buttonAddStudentToSubject.Location = new System.Drawing.Point(171, 315);
            this.buttonAddStudentToSubject.Name = "buttonAddStudentToSubject";
            this.buttonAddStudentToSubject.Size = new System.Drawing.Size(153, 95);
            this.buttonAddStudentToSubject.TabIndex = 9;
            this.buttonAddStudentToSubject.Text = "Зарахувати студента на курс";
            this.buttonAddStudentToSubject.UseVisualStyleBackColor = true;
            this.buttonAddStudentToSubject.Click += new System.EventHandler(this.buttonAddStudentToSubject_Click);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 421);
            this.Controls.Add(this.buttonAddStudentToSubject);
            this.Controls.Add(this.buttonChangeSubjectName);
            this.Controls.Add(this.buttonChangeGrade);
            this.Controls.Add(this.buttonChangeInfoAboutStudent);
            this.Controls.Add(this.buttonDeleteStudent);
            this.Controls.Add(this.buttonRemoveSubject);
            this.Controls.Add(this.buttonInfoAboutStudent);
            this.Controls.Add(this.buttonListSubjects);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.buttonAddSubject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(511, 460);
            this.MinimumSize = new System.Drawing.Size(511, 460);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonAddStudentToSubject;

        private System.Windows.Forms.Button buttonChangeGrade;
        private System.Windows.Forms.Button buttonChangeSubjectName;

        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonListSubjects;
        private System.Windows.Forms.Button buttonInfoAboutStudent;
        private System.Windows.Forms.Button buttonRemoveSubject;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonChangeInfoAboutStudent;

        #endregion
    }
}