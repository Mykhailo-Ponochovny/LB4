using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab4_CSHARP.Classes;

namespace Lab4_CSHARP.Windows
{
    public partial class ChangeSubjectNameDialog : Form
    {
        private List<AcademicSubject> _academicSubjects;

        internal ChangeSubjectNameDialog(List<AcademicSubject> academicSubjects)
        {
            _academicSubjects = academicSubjects;
            InitializeComponent();
        }

        private void ChangeSubjectNameDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox=false;
            foreach (var t in _academicSubjects)
                comboBoxSubjects.Items.Add(t.GetSetSubjectName);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjects.Text == string.Empty)
                MessageBox.Show("Оберіть предмет зі списку", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                textBoxName.Enabled = true;
                textBoxName.Text = _academicSubjects[comboBoxSubjects.SelectedIndex].GetSetSubjectName;
                buttonSave.Enabled = true;
                comboBoxSubjects.Enabled = false;
                buttonSelect.Enabled = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty)
                MessageBox.Show("Поле назви не може бути порожнім", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                _academicSubjects[comboBoxSubjects.SelectedIndex].GetSetSubjectName = textBoxName.Text;
                this.Close();
            }
        }
    }
}