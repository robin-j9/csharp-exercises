using System;
using System.Collections.Generic;
using System.Text;

namespace QuizStudio
{
    class Quiz
    {
        public List<Question> quiz = new List<Question>();
        private List<string> input = new List<string>();
        private int totalScore;
        public int TotalPossibleScore { get; set; }
        

        public void Add(Question newQuestion)
        {
            quiz.Add(newQuestion);
        }

        public void StartQuiz()
        {
            foreach(Question q in quiz)
            {
                q.PrintQuestion();
                TotalPossibleScore += q.NumberOfAnswers;
                AcceptInputAndEvaluate(q);
            }
        }

        public void AcceptInputAndEvaluate(Question q)
        {
            Console.WriteLine("\n");
            if (q is TrueOrFalseQuestion || q is SingleAnswerQuestion)
            {
                string singleInput = Console.ReadLine();
                if (q.CorrectAnswers[0] == singleInput)
                {
                    totalScore++;
                }
            }
            else if (q is MultipleAnswerQuestion)
            {
                while (true)
                {
                    input.Add(Console.ReadLine());
                    if (input[input.Count - 1] == "" || input.Count == q.NumberOfAnswers)
                    {
                        break;
                    }
                }

                foreach (string answer in input)
                {
                    if (Array.Exists(q.CorrectAnswers, response => response == answer))
                    {
                        totalScore++;
                    }
                }
            }
            Console.WriteLine("\n");
        }

        public void PrintGrade()
        {
            Console.WriteLine("You got " + totalScore + " / " + TotalPossibleScore + " questions right.");
            double grade = (totalScore / TotalPossibleScore) * 100;
            Console.WriteLine(grade + "%");
        }
    }
}
