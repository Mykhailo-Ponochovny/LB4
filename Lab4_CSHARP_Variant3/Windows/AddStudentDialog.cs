using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab4_CSHARP.Classes;

namespace Lab4_CSHARP.Windows
{
    public partial class AddStudentDialog : Form
    {
        public Student newStudent;
        public AddStudentDialog()
        {
            InitializeComponent();
        }

        private void AddStudentDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox=false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == string.Empty || textBoxName.Text == string.Empty)
                MessageBox.Show("Недостатньо інформації", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                newStudent = new Student(textBoxSurname.Text, textBoxName.Text, new List<AcademicSubject>());
                this.Close();
            }
        }
    }
}