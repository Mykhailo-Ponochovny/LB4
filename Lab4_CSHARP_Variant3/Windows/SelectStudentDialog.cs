using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lab4_CSHARP.Classes;

namespace Lab4_CSHARP.Windows
{
    public partial class SelectStudentDialog : Form
    {
        private List<Student> _students;
        private bool _closeDialog = false;
        public int StudentIndex;

        internal SelectStudentDialog(List<Student> students)
        {
            _students = students;
            InitializeComponent();
        }

        private void SelectStudentDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox=false;
            foreach (var fullName in _students.Select(student => student.GetSetSurname + " " + student.GetSetName))
                comboBoxStudents.Items.Add(fullName);
        }
        
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.Text == string.Empty)
                MessageBox.Show("Оберіть студента!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                StudentIndex = comboBoxStudents.SelectedIndex;
                _closeDialog = true;
                this.Close();
            }
        }
        
        private void SelectStudentDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !_closeDialog;
        }
    }
}