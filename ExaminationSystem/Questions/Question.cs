using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Questions
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark {  get; set; }
        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; }
    }
}
