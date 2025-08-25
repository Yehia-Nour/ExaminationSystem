using ExaminationSystem.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Exams
{
    internal abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestion { get; set; }
        public Question[] Questions { get; set; }

        public abstract void ShowExam();
        public abstract void CreateExam();
        public abstract void StartExam();
        public abstract void FinishExam(Dictionary<int, Answer> studentAnswers, TimeSpan duration);

    }
}
