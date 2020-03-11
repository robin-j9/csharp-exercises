using System;
using System.Collections.Generic;
using System.Text;

namespace QuizStudio
{
    abstract class Question
    {
        public string Inquiry { get; set; }
        public abstract int NumberOfAnswers { get; set; }
        public abstract string[] CorrectAnswers { get; set; }

        public Question(string inquiry) 
        {
            Inquiry = inquiry;
        }

        public abstract void PrintQuestion();
    }                                                                                                                                                                                                                                                                                                
}
