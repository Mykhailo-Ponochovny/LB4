using System.Collections.Generic;

namespace Lab4_CSHARP.Classes
{
    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public List<AcademicSubject> AcademicSubjects { get; set; }

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

        public List<AcademicSubject> SetAcademicSubjects
        {
            set => AcademicSubjects = value;
        }

        public AcademicSubject AddAcademicSubjects
        {
            set => AcademicSubjects.Add(value);
        }

        public void RemoveAcademicSubject(string academicSubjectName)
        {
            if (AcademicSubjects.Count > 0)
            {
                var findSubject = AcademicSubjects.Find(
                    s => s.GetSetSubjectName.Equals(academicSubjectName));
                if (findSubject != null)
                    AcademicSubjects.Remove(findSubject);
            }
        }
    }
}