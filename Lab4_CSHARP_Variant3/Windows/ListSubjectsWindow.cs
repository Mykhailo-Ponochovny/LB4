using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab4_CSHARP.Classes;

namespace Lab4_CSHARP.Windows
{
    public partial class ListSubjectsWindow : Form
    {
        private List<AcademicSubject> _academicSubjects;

        internal ListSubjectsWindow(List<AcademicSubject> academicSubjects)
        {
            _academicSubjects = academicSubjects;
            InitializeComponent();
        }

        private void ListSubjectsWindow_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < _academicSubjects.Count; i++)
                dataGridView1.Rows.Add(i + 1, _academicSubjects[i].GetSetSubjectName);
        }
    }
}