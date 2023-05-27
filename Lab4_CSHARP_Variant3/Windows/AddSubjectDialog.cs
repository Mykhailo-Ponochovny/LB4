using System;
using System.Windows.Forms;
using Lab4_CSHARP_Variant3.Classes;

namespace Lab4_CSHARP_Variant3.Windows
{
    public partial class AddSubjectDialog : Form
    {
        public AcademicSubject newAcademicSubject;
        public AddSubjectDialog()
        {
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
                newAcademicSubject = new AcademicSubject(textBoxSubjectName.Text, 0);
                this.Close();
            }
        }
    }
}