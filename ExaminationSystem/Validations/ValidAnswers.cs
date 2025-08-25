using ExaminationSystem.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Validations
{
    internal static class ValidAnswers
    {
        public static Answer[] GetAnswers(int count)
        {
            Answer[] answers = new Answer[count];
            for (int i = 0; i < count; i++)
            {
                string choice = ValidString.GetValidString($"Please enter choice {i + 1}: ");
                answers[i] = new Answer { AnswerId = i + 1, AnswerText = choice };
            }
            return answers;
        }
    }
}
