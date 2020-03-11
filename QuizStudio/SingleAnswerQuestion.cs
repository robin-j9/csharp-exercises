using System;
using System.Collections.Generic;
using System.Text;

namespace QuizStudio
{
    class SingleAnswerQuestion : MultipleChoiceQuestion
    {
        public override string[] CorrectAnswers { get; set; }
        public override int NumberOfAnswers { get; set; } = 1;

        public SingleAnswerQuestion(string inquiry, List<string> answerChoices, string[] correctAnswer) : base(inquiry, answerChoices)
        {
            CorrectAnswers = correctAnswer;
        }
    }
}
