using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Validations
{
    internal static class ValidInt
    {
        public static int GetValidInt(string message, int min, int max)
        {
            int value;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out value) || value < min || value > max)
            {
                Console.Write($"Invalid number, please enter a number between {min} and {max}: ");
            }
            return value;
        }
    }
}
