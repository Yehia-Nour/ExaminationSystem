using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Validations
{
    internal static class ValidString
    {
        public static string GetValidString(string message)
        {
            string input;
            Console.Write(message);
            while (string.IsNullOrWhiteSpace(input = Console.ReadLine()))
            {
                Console.Write("Invalid input, please try again: ");
            }
            return input;
        }

    }
}
