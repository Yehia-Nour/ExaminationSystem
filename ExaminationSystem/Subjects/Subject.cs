using ExaminationSystem.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Subjects
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(int choice)
        {
            if (choice == 1)
            {
                Exam = new PracticalExam();
                Exam.ShowExam();
            }
            else
            {
                Exam = new FinalExam();
                Exam.ShowExam();
            }
        }
    }
}
