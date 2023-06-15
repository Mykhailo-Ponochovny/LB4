using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab4_CSHARP.Classes;

namespace Lab4_CSHARP.Windows
{
    public partial class InfoAboutStudentWindow : Form
    {
        private Student _student;
        
        public InfoAboutStudentWindow(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        private void InfoAboutStudentWindow_Load(object sender, EventArgs e)
        {
            labelSurname.Text = _student.GetSetSurname;
            labelName.Text = _student.GetSetName;
            var studentAcademicSubjects = _student.GetAcademicSubjects;
            for (var i = 0; i < studentAcademicSubjects.Count; i++)
                dataGridView1.Rows.Add(i + 1, studentAcademicSubjects[i].GetSetSubjectName,
                    studentAcademicSubjects[i].GetSetGrade);
        }
    }
}