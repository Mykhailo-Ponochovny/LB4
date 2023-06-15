using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lab4_CSHARP.Classes;

namespace Lab4_CSHARP.Windows
{
    public partial class AddStudentToSubjectDialog : Form
    {
        private List<Student> _students;
        private List<AcademicSubject> _academicSubjects;

        internal AddStudentToSubjectDialog(List<Student> students, List<AcademicSubject> academicSubjects)
        {
            _students = students;
            _academicSubjects = academicSubjects;
            InitializeComponent();
        }

        private void AddStudentToSubjectDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox=false;
            foreach (var fullName in _students.Select(student => student.GetSetSurname + " " + student.GetSetName))
                comboBoxStudents.Items.Add(fullName);
            foreach (var subject in _academicSubjects)
                comboBoxSubjects.Items.Add(subject.GetSetSubjectName);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var grade = Convert.ToInt32(Math.Round(numericUpDownGrade.Value, 0));
            if (comboBoxStudents.Text == string.Empty || comboBoxSubjects.Text == string.Empty || grade == 0)
                MessageBox.Show("Недостатньо інформації!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Functions.FindSubject(_students[comboBoxStudents.SelectedIndex],
                         _academicSubjects[comboBoxSubjects.SelectedIndex].GetSetSubjectName))
                MessageBox.Show("Цей студент вже записаний до цього предмета!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                var newStudentSubject =
                    new AcademicSubject(_academicSubjects[comboBoxSubjects.SelectedIndex].GetSetSubjectName, grade);
                _students[comboBoxStudents.SelectedIndex].AddAcademicSubjects = newStudentSubject;
                this.Close();
            }
        }
    }
}