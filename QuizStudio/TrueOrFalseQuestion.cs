using System;
using System.Collections.Generic;
using System.Text;

namespace QuizStudio
{
    class TrueOrFalseQuestion : SingleAnswerQuestion
    {
        public static List<string> answerChoices = new List<string>() { "true", "false" };
        public TrueOrFalseQuestion(string inquiry, string[] correctAnswer)
            : base(inquiry, answerChoices, correctAnswer) { }
    }
}
