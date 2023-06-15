using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lab4_CSHARP.Classes;

namespace Lab4_CSHARP.Windows
{
    public partial class ChangeStudentGradeDialog : Form
    {
        private List<Student> _students;

        internal ChangeStudentGradeDialog(List<Student> students)
        {
            _students = students;
            InitializeComponent();
        }

        private void ChangeStudentGradeDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            foreach (var fullName in _students.Select(student => student.GetSetSurname + " " + student.GetSetName))
                comboBoxStudents.Items.Add(fullName);
        }

        private void buttonChooseStudent_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.Text == string.Empty)
                MessageBox.Show("Оберіть студента!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                comboBoxStudents.Enabled = false;
                buttonChooseStudent.Enabled = false;
                comboBoxSubjects.Enabled = true;
                buttonChooseSubject.Enabled = true;
                var getStudentSubjects = _students[comboBoxStudents.SelectedIndex].GetAcademicSubjects;
                foreach (var subject in getStudentSubjects)
                    comboBoxSubjects.Items.Add(subject.GetSetSubjectName);
            }
        }

        private void buttonChooseSubject_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjects.Text == string.Empty)
                MessageBox.Show("Оберіть предмет!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                comboBoxSubjects.Enabled = false;
                buttonChooseSubject.Enabled = false;
                numericUpDownGrade.Enabled = true;
                buttonSave.Enabled = true;
                var getStudentSubjects = _students[comboBoxStudents.SelectedIndex].GetAcademicSubjects;
                numericUpDownGrade.Value = getStudentSubjects[comboBoxSubjects.SelectedIndex].GetSetGrade;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var grade = Convert.ToInt32(Math.Round(numericUpDownGrade.Value, 0));
            if (grade == 0)
                MessageBox.Show("Оцінка не може бути нулем!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var getStudentSubjects = _students[comboBoxStudents.SelectedIndex].GetAcademicSubjects[comboBoxSubjects.SelectedIndex];
                getStudentSubjects.GetSetGrade = grade;
                this.Close();
            }
        }
    }
}