using ExaminationSystem.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Questions
{
    internal class MCQQuestion : Question
    {
        public static MCQQuestion CreateNewMCQQuestion()
        {

            var question = new MCQQuestion
            {
                Header = "MCQ Question",
                Body = ValidString.GetValidString("Please enter the question body: "),
                Mark = ValidInt.GetValidInt("Please enter mark (1-10): ", 1, 10),
                Answers = ValidAnswers.GetAnswers(3)
            };

            int rightAnswerId = ValidInt.GetValidInt("Please enter the right answer id: ", 1, 3);
            question.RightAnswer = question.Answers[rightAnswerId - 1];

            return question;
        }
    }
}
