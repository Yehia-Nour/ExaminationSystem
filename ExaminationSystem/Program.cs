using ExaminationSystem.Subjects;
using ExaminationSystem.Validations;
using System.Text.RegularExpressions;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subjectId = ValidInt.GetValidInt("Please Enter the Subject Id (1 - 100): ", 1, 100);
            string subjectName = ValidString.GetValidString("Please Enter the Subject Name: ");

            var subject = new Subject(subjectId, subjectName);
            Console.Clear();

            int choice = ValidInt.GetValidInt("Please Enter the Type of Exam (1 for Practical | 2 for Final): ", 1, 2);

            Console.Clear();
            subject.CreateExam(choice);

        }
    }
}
