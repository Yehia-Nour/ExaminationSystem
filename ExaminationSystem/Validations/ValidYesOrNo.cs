using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Validations
{
    internal static class ValidYesOrNo
    {
        public static bool GetYesOrNo(string message)
        {
            Console.Write(message);
            string? input;

            while (true)
            {
                input = Console.ReadLine()?.Trim().ToLower();

                if (input == "y" || input == "yes")
                    return true;
                else if (input == "n" || input == "no")
                    return false;
                else
                    Console.Write("Invalid input, please enter (Y/N): ");
            }
        }
    }
}
