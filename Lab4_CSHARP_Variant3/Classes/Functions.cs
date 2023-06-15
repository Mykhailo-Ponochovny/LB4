using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lab4_CSHARP.Classes
{
    public class Functions
    {
        public static void SerializeStudentsJson(List<Student> students)
        {
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");
            string infoSerialized = JsonSerializer.Serialize(students);
            File.WriteAllText("data/students.json", infoSerialized);
        }

        public static List<Student> DeserializeStudentsJson()
        {
            List<Student> result = new List<Student>();
            if (File.Exists("data/students.json"))
            {
                string infoDeserialized = File.ReadAllText("data/students.json");
                result = JsonSerializer.Deserialize<List<Student>>(infoDeserialized);
            }

            return result;
        }

        public static void SerializeSubjectsJson(List<AcademicSubject> academicSubjects)
        {
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");
            string infoSerialized = JsonSerializer.Serialize(academicSubjects);
            File.WriteAllText("data/subjects.json", infoSerialized);
        }

        public static List<AcademicSubject> DeserializeSubjectsJson()
        {
            List<AcademicSubject> result = new List<AcademicSubject>();
            if (File.Exists("data/subjects.json"))
            {
                string infoDeserialized = File.ReadAllText("data/subjects.json");
                result = JsonSerializer.Deserialize<List<AcademicSubject>>(infoDeserialized);
            }

            return result;
        }
        
        public static bool FildGrade(List<Student> students)
        {
            return students.Select(student => student.GetAcademicSubjects).Any(getAcademicSubjects => getAcademicSubjects.Count > 0);
        }
        
        public static bool FindSubject(Student student, string subjectName)
        {
            var result = false;

            var studentSubjects = student.GetAcademicSubjects;

            if (studentSubjects.Count > 0)
            {
                var findSubject = studentSubjects.Find(s => s.GetSetSubjectName.Equals(subjectName));
                if (findSubject != null)
                    result = true;
            }
            
            return result;
        }
    }
}