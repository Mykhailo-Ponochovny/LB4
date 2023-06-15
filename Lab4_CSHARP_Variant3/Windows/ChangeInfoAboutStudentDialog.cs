using System;
using System.Windows.Forms;
using Lab4_CSHARP.Classes;

namespace Lab4_CSHARP.Windows
{
    public partial class ChangeInfoAboutStudentDialog : Form
    {
        private Student _student;
        
        internal ChangeInfoAboutStudentDialog(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        private void ChangeInfoAboutStudentDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox=false;
            textBoxSurname.Text = _student.GetSetSurname;
            textBoxName.Text = _student.GetSetName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == string.Empty || textBoxName.Text == String.Empty)
                MessageBox.Show("Поля не можуть бути порожніми!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                _student.GetSetSurname = textBoxSurname.Text;
                _student.GetSetName = textBoxName.Text;
                this.Close();
            }
        }
    }
}