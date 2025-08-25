using ExaminationSystem.Questions;
using ExaminationSystem.Validations;

namespace ExaminationSystem.Exams
{
    internal class PracticalExam : Exam
    {
        public override void ShowExam()
        {
            CreateExam();
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
                Questions[i] = MCQQuestion.CreateNewMCQQuestion();
            }
        }

        public override void StartExam()
        {
            DateTime startTime = DateTime.Now;
            TimeSpan allowedTime = TimeSpan.FromMinutes(TimeOfExam);

            Dictionary<int, Answer> studentAnswers = new Dictionary<int, Answer>();

            Console.Clear();
            Console.WriteLine("===== Practical Exam Started =====\n\n");

            for (int i = 0; i < NumberOfQuestion; i++)
            {
                if (DateTime.Now - startTime >= allowedTime)
                {
                    Console.WriteLine("\nTime is up! Exam finished automatically.\n");
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
            Console.Clear();
            Console.WriteLine("===== Exam Finished =====\n");
            Console.WriteLine("Correct Answers:\n");

            for (int i = 0; i < studentAnswers.Count; i++)
            {
                var question = Questions[i];
                Console.WriteLine($"Question {i + 1}: {question.Body}");
                Console.WriteLine($"Right Answer: {question.RightAnswer.AnswerText}\n");
            }

            Console.WriteLine($"Time Taken = {duration:mm\\:ss}\n");
            Console.WriteLine("Thank You");
        }
    }
}
