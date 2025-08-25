using ExaminationSystem.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Validations
{
    internal static class ValidQuestion
    {
        public static Answer GetQuestion(Question question, int index)
        {
            Console.WriteLine($"{question.Header}\t\tMark: {question.Mark}\n");
            Console.WriteLine($"Question ({index + 1}): {question.Body}\n");

            foreach (var answer in question.Answers)
                Console.WriteLine($"{answer.AnswerId}-{answer.AnswerText}");

            int userAnswerId = ValidInt.GetValidInt("Please Enter The Answer Id: ", 1, question.Answers.Length);
            return question.Answers[userAnswerId - 1];
        }
    }
}
