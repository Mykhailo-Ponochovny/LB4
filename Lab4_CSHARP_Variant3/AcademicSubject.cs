﻿using System;

namespace Lab4_CSHARP_Variant3
{
    public class AcademicSubject
    {
        private string SubjectName { get; set; }
        private int Grade { get; set; }

        public AcademicSubject()
        {
            SubjectName = string.Empty;
            Grade = 0;
        }

        public AcademicSubject(string subjectName, int grade)
        {
            this.SubjectName = subjectName;
            this.Grade = grade;
        }

        public string GetSetSubjectName
        {
            get => SubjectName;
            set => SubjectName = value;
        }

        public int GetSetGrade
        {
            get => Grade;
            set => Grade = value;
        }
    }
}