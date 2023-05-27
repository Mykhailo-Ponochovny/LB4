using System.Collections.Generic;

namespace Lab4_CSHARP_Variant3
{
    public class Student
    {
        private string FullName { get; set; }
        private List<AcademicSubject> AcademicSubjects { get; set; }

        public Student()
        {
            FullName = string.Empty;
            AcademicSubjects = new List<AcademicSubject>();
        }

        public Student(string fullName, List<AcademicSubject> academicSubjects)
        {
            this.FullName = fullName;
            this.AcademicSubjects = academicSubjects;
        }

        public string GetSetFullName
        {
            get => FullName;
            set => FullName = value;
        }

        public List<AcademicSubject> GetAcademicSubjects => AcademicSubjects;

        public AcademicSubject AddAcademicSubjects
        {
            set => AcademicSubjects.Add(value);
        }

        public void RemoveAcademicSubject(AcademicSubject academicSubject)
        {
            AcademicSubjects.Remove(academicSubject);
        }
    }
}