﻿using System;
using System.Collections.Generic;
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
                var checkGrade = Functions.FildGrade(_students);
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
            
            if (_students.Count > 0 && _academicSubjects.Count > 0)
                buttonAddStudentToSubject.Enabled = true;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var addStudentDialog = new AddStudentDialog();
            addStudentDialog.ShowDialog();
            if (addStudentDialog.newStudent != null)
            {
                _students.Add(addStudentDialog.newStudent);
                buttonInfoAboutStudent.Enabled = true;
                buttonDeleteStudent.Enabled = true;
                buttonChangeInfoAboutStudent.Enabled = true;
            }

            if (_students.Count > 0 && _academicSubjects.Count > 0)
                buttonAddStudentToSubject.Enabled = true;
        }

        private void buttonRemoveSubject_Click(object sender, EventArgs e)
        {
            var deleteSubjectDialog = new DeleteSubjectDialog(_academicSubjects, _students);
            deleteSubjectDialog.ShowDialog();
            if (_academicSubjects.Count == 0)
            {
                buttonRemoveSubject.Enabled = false;
                buttonChangeGrade.Enabled = false;
                buttonChangeSubjectName.Enabled = false;
                buttonListSubjects.Enabled = false;
            }
            else
            {
                if (!Functions.FildGrade(_students))
                    buttonChangeGrade.Enabled = false;
            }
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudentDialog deleteStudentDialog = new DeleteStudentDialog(_students);
            deleteStudentDialog.ShowDialog();
            if (_students.Count == 0)
            {
                buttonDeleteStudent.Enabled = false;
                buttonInfoAboutStudent.Enabled = false;
                buttonChangeInfoAboutStudent.Enabled = false;
                buttonChangeGrade.Enabled = false;
                buttonAddStudentToSubject.Enabled = false;
            }
        }

        private void buttonListSubjects_Click(object sender, EventArgs e)
        {
            var listSubjectsWindow = new ListSubjectsWindow(_academicSubjects);
            this.Hide();
            listSubjectsWindow.ShowDialog();
            this.Show();
        }
    }
}