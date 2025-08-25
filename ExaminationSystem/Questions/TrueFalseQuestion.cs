using ExaminationSystem.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Questions
{
    internal class TrueFalseQuestion : Question
    {
        public static TrueFalseQuestion CreateNewTFQuestion()
        {
            var question = new TrueFalseQuestion
            {
                Header = "True/False Question",
                Body = ValidString.GetValidString("Please enter the question body: "),
                Mark = ValidInt.GetValidInt("Please enter mark (1-10): ", 1, 10),
                Answers = new Answer[]
                {
                    new Answer { AnswerId = 1, AnswerText = "True" },
                    new Answer { AnswerId = 2, AnswerText = "False" }
                }
            };

            int rightAnswerId = ValidInt.GetValidInt("Please enter the right answer id (1 for True, 2 for False): ", 1, 2);
            question.RightAnswer = question.Answers[rightAnswerId - 1];

            return question;
        }
    }
}
