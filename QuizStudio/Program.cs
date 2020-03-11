using System;
using System.Collections.Generic;
namespace QuizStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz1 = new Quiz();

            List<string> answerChoices1 = new List<string>() { "choice1", "choice2", "choice3" };
            string[] correctAnswer = { "choice1" };
            SingleAnswerQuestion question1 = new SingleAnswerQuestion("Question 1?", answerChoices1, correctAnswer);

            List<string> answerChoices2 = new List<string>() { "answer1", "answer2", "answer3" };
            string[] correctAnswers = new string[2] { "answer1", "answer2" };
            MultipleAnswerQuestion question2 = new MultipleAnswerQuestion("Question 2? (2 correct answers)", answerChoices2, correctAnswers);

            string[] correctAnswer2 = new string[] { "true" };
            TrueOrFalseQuestion question3 = new TrueOrFalseQuestion("Question 3?", correctAnswer2);

            quiz1.Add(question1);
            quiz1.Add(question2);
            quiz1.Add(question3);

            quiz1.StartQuiz();
            quiz1.PrintGrade();
        }
    }
}
