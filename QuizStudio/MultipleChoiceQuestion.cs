using System;
using System.Collections.Generic;
using System.Text;

namespace QuizStudio
{
    abstract class MultipleChoiceQuestion : Question
    {
        public List<string> AnswerChoices { get; set; } = new List<string>();
        public override int NumberOfAnswers { get; set; }

        public override string[] CorrectAnswers { get; set; }

        public MultipleChoiceQuestion(string inquiry, List<string> answerChoices) : base(inquiry)
        {
            AnswerChoices = answerChoices;
        }

        public override void PrintQuestion()
        {
            Console.WriteLine(Inquiry + "\n");
            foreach (string choice in AnswerChoices)
            {
                Console.WriteLine(choice);
            }
        }
    }
}
