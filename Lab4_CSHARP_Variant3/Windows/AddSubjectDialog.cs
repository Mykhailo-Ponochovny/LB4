using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab4_CSHARP_Variant3.Classes;

namespace Lab4_CSHARP_Variant3.Windows
{
    public partial class AddSubjectDialog : Form
    {
        private List<AcademicSubject> _academicSubjects;
        internal AddSubjectDialog(List<AcademicSubject> academicSubjects)
        {
            _academicSubjects = academicSubjects;
            InitializeComponent();
        }

        private void AddSubjectDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox=false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxSubjectName.Text == string.Empty)
                MessageBox.Show("Вкажіть назву предмета!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var findSubject = _academicSubjects.Find(s => s.GetSetSubjectName.Equals(textBoxSubjectName.Text));
                if (findSubject == null)
                {
                    var newAcademicSubject = new AcademicSubject(textBoxSubjectName.Text, 0);
                    _academicSubjects.Add(newAcademicSubject);
                    this.Close();
                }
                else
                    MessageBox.Show("Цей предмет вже записаний!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}