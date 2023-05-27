using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Lab4_CSHARP_Variant3.Classes;

namespace Lab4_CSHARP_Variant3.Windows
{
    public partial class MainWindow : Form
    {
        private List<Student> _students;
        private List<AcademicSubject> _academicSubjects;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        { 
            _students = Functions.DeserializeStudentsJson(); 
            _academicSubjects = Functions.DeserializeSubjectsJson();
            if (_students.Count > 0)
            {
                buttonInfoAboutStudent.Enabled = true;
                buttonDeleteStudent.Enabled = true;
                buttonChangeInfoAboutStudent.Enabled = true;
            }
            if (_academicSubjects.Count > 0)
            {
                buttonListSubjects.Enabled = true;
                buttonRemoveSubject.Enabled = true;
                buttonChangeSubjectName.Enabled = true;
            }

            if (_students.Count > 0 && _academicSubjects.Count > 0)
            {
                bool checkGrade = Functions.FildGrade(_students);
                if (checkGrade)
                    buttonChangeGrade.Enabled = true;
            }
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            var addSubjectDialog = new AddSubjectDialog();
            addSubjectDialog.ShowDialog();
            if (addSubjectDialog.newAcademicSubject != null)
            {
                _academicSubjects.Add(addSubjectDialog.newAcademicSubject);
                buttonListSubjects.Enabled = true;
                buttonRemoveSubject.Enabled = true;
                buttonChangeSubjectName.Enabled = true;
            }
        }
    }
}