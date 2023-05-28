using System;
using System.Collections.Generic;
using System.Linq;
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
                buttonAddStudentToSubject.Enabled = true;
            }
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            var addSubjectDialog = new AddSubjectDialog(_academicSubjects);
            addSubjectDialog.ShowDialog();
            if (_academicSubjects.Count > 0)
            {
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
                buttonAddStudentToSubject.Enabled = false;
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

        private void buttonInfoAboutStudent_Click(object sender, EventArgs e)
        {
            var selectStudentDialog = new SelectStudentDialog(_students);
            selectStudentDialog.ShowDialog();
            var infoAboutStudentWindow = new InfoAboutStudentWindow(_students[selectStudentDialog.StudentIndex]);
            this.Hide();
            infoAboutStudentWindow.ShowDialog();
            this.Show();
        }

        private void buttonChangeInfoAboutStudent_Click(object sender, EventArgs e)
        {
            var selectStudentDialog = new SelectStudentDialog(_students);
            selectStudentDialog.ShowDialog();
            var changeInfoAboutStudentDialog =
                new ChangeInfoAboutStudentDialog(_students[selectStudentDialog.StudentIndex]);
            changeInfoAboutStudentDialog.ShowDialog();
        }

        private void buttonChangeGrade_Click(object sender, EventArgs e)
        {
            var changeStudentGradeDialog = new ChangeStudentGradeDialog(_students);
            changeStudentGradeDialog.ShowDialog();
        }

        private void buttonChangeSubjectName_Click(object sender, EventArgs e)
        {
            var changeSubjectNameDialog = new ChangeSubjectNameDialog(_academicSubjects);
            changeSubjectNameDialog.ShowDialog();
        }

        private void buttonAddStudentToSubject_Click(object sender, EventArgs e)
        {
            var addStudentToSubjectDialog = new AddStudentToSubjectDialog(_students, _academicSubjects);
            addStudentToSubjectDialog.ShowDialog();
            if (Functions.FildGrade(_students))
                buttonChangeGrade.Enabled = true;
        }
        
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви дійсно бажаєте завершити роботу?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Functions.SerializeStudentsJson(_students);
                Functions.SerializeSubjectsJson(_academicSubjects);
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
    }
}