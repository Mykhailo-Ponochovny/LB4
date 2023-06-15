using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lab4_CSHARP.Classes;

namespace Lab4_CSHARP.Windows
{
    public partial class DeleteStudentDialog : Form
    {
        private List<Student> _students;

        internal DeleteStudentDialog(List<Student> students)
        {
            _students = students;
            InitializeComponent();
        }

        private void DeleteStudentDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox=false;
            foreach (var fullName in _students.Select(student => student.GetSetSurname + " " + student.GetSetName))
                comboBoxStudents.Items.Add(fullName);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.Text == string.Empty)
                MessageBox.Show("Оберіть студента!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var mb = MessageBox.Show("Ви дійсно бажаєте відрахувати цього студента?", "Information",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mb == DialogResult.Yes)
                {
                    _students.RemoveAt(comboBoxStudents.SelectedIndex);
                    this.Close();
                }
                else
                    this.Close();
            }
        }
    }
}