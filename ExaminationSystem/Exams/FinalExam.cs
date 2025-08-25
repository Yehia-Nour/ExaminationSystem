using ExaminationSystem.Questions;
using ExaminationSystem.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Exams
{
    internal class FinalExam : Exam
    {
        public override void ShowExam()
        {
            CreateExam();
            Console.Clear();
            bool startExam = ValidYesOrNo.GetYesOrNo("Do you want to Start Exam (Y/N): ");
            if (startExam)
                StartExam();
            else
                Console.WriteLine("Thank You");
        }

        public override void CreateExam()
        {
            TimeOfExam = ValidInt.GetValidInt("Please Enter the Time for Exam (30 - 180 minutes): ", 30, 180);
            NumberOfQuestion = ValidInt.GetValidInt("Please Enter the Number of Questions (1 - 20): ", 1, 20);
            Console.Clear();


            Questions = new Question[NumberOfQuestion];

            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.Clear();
                Console.WriteLine($"Creating Question {i + 1}");
                int choice = ValidInt.GetValidInt("Please Enter the Type of Question (1 for MCQ | 2 for True/False): ", 1, 2);

                if (choice == 1)
                    Questions[i] = MCQQuestion.CreateNewMCQQuestion();
                else
                    Questions[i] = TrueFalseQuestion.CreateNewTFQuestion();
            }
        }

        public override void StartExam()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddMinutes(TimeOfExam);

            Dictionary<int, Answer> studentAnswers = new Dictionary<int, Answer>();

            Console.Clear();
            Console.WriteLine("===== Final Exam Started =====\n\n");

            for (int i = 0; i < NumberOfQuestion; i++)
            {
                if (DateTime.Now >= endTime)
                {
                    Console.WriteLine("\nTime is over! The exam has ended.");
                    break;
                }

                studentAnswers[i] = ValidQuestion.GetQuestion(Questions[i], i);
                Console.WriteLine("\n---------------------------\n");
            }

            TimeSpan examDuration = DateTime.Now - startTime;

            FinishExam(studentAnswers, examDuration);
        }

        public override void FinishExam(Dictionary<int, Answer> studentAnswers, TimeSpan duration)
        {
            int totalGrade = 0;
            int studentGrade = 0;

            Console.Clear();
            Console.WriteLine("===== Exam Finished =====\n");

            for (int i = 0; i < studentAnswers.Count; i++)
            {
                var question = Questions[i];
                Console.WriteLine($"Question {i + 1} : {question.Body}");
                Console.WriteLine($"Your Answer  => {studentAnswers[i].AnswerText}");
                Console.WriteLine($"Right Answer => {question.RightAnswer.AnswerText}\n");

                totalGrade += question.Mark;
                if (studentAnswers[i].AnswerId == question.RightAnswer.AnswerId)
                    studentGrade += question.Mark;
            }

            Console.WriteLine($"Your Grade is {studentGrade} From {totalGrade}");
            Console.WriteLine($"Time = {duration:mm\\:ss}\n");
            Console.WriteLine("Thank you");
        }
    }
}