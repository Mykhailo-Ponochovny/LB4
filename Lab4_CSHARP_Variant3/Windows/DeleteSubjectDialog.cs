using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab4_CSHARP.Classes;

namespace Lab4_CSHARP.Windows
{
    public partial class DeleteSubjectDialog : Form
    {
        private List<AcademicSubject> _academicSubjects;
        private List<Student> _students;

        internal DeleteSubjectDialog(List<AcademicSubject> academicSubjects, List<Student> students)
        {
            _academicSubjects = academicSubjects;
            _students = students;
            InitializeComponent();
        }

        private void DeleteSubjectDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox=false;
            foreach (var t in _academicSubjects)
                comboBoxSubjects.Items.Add(t.GetSetSubjectName);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjects.Text == string.Empty)
                MessageBox.Show("Оберіть предмет зі списку", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var mb = MessageBox.Show("Ви дійсно бажаєте видалити цей предмет?", "Information",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mb == DialogResult.Yes)
                {
                    _academicSubjects.RemoveAt(comboBoxSubjects.SelectedIndex);
                    foreach (var student in _students)
                        student.RemoveAcademicSubject(comboBoxSubjects.Text);
                    this.Close();
                }
                else
                    this.Close();
            }
        }
    }
}