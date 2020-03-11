using System;
using System.Collections.Generic;
using System.Text;

namespace QuizStudio
{
    class MultipleAnswerQuestion: MultipleChoiceQuestion
    {
        public override string[] CorrectAnswers { get; set; }
        public override int NumberOfAnswers { get; set; }

        public MultipleAnswerQuestion(string inquiry, List<string> answerChoices, string[] correctAnswers) : base(inquiry, answerChoices)
        {
            CorrectAnswers = correctAnswers;
            NumberOfAnswers = correctAnswers.Length;
        }
    }
}
