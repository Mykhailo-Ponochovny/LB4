using System.Collections.Generic;

namespace Lab4_CSHARP_Variant3.Classes
{
    public class Student
    {
        private string Surname { get; set; }
        private string Name { get; set; }
        private List<AcademicSubject> AcademicSubjects { get; set; }

        public Student()
        {
            Surname = string.Empty;
            Name = string.Empty;
            AcademicSubjects = new List<AcademicSubject>();
        }

        public Student(string surname, string name, List<AcademicSubject> academicSubjects)
        {
            this.Surname = surname;
            this.Name = name;
            this.AcademicSubjects = academicSubjects;
        }

        public string GetSetSurname
        {
            get => Surname;
            set => Surname = value;
        }
        
        public string GetSetName
        {
            get => Name;
            set => Name = value;
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