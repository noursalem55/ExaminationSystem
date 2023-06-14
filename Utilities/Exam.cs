using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Exam
    {
        private int time;
        private int numberOfQuestions = 0;
        private List<string> questionsAnswers = new List<string>();
        //----------------------------------------------------------------
        public int studentGrade;
        public List<string> userAnswers = new List<string>();






        public int Time { get => time; set => time = value; }
        public int NumberOfQuestions { get => numberOfQuestions; set => numberOfQuestions = value; }
        public List<string> QuestionsAnswers { get => questionsAnswers; set => questionsAnswers = value; }


        //==========================================GenerateExam====================================================
        public Dictionary<string, Answers> GenerateExam(QuestionList Ql, AnswerList ANl)
        {
            numberOfQuestions = Ql.Count; // question number according to Questions list

            Dictionary<string, Answers> ExamCopy = new Dictionary<string, Answers>();
            for (int i = 0; i < numberOfQuestions; i++)
            {
                ExamCopy.Add(Ql[i].QuestionBody, ANl[i]);
                QuestionsAnswers.Add(Ql[i].QuestionRightAnswer);
            }
            return ExamCopy;
        }

        //==========================================ShowExam====================================================
        public void ShowExam(QuestionList Ql, Dictionary<string, Answers> ex)
        {
            studentGrade = 0;


            for (int i = 0; i < numberOfQuestions; i++)
            {
                if (Ql[i].Questionheader == QuestionHeader.TRUEFALSEQUESTION)
                {
                    Console.WriteLine("Q-chooes the correct answer, you can write T or F in answer part.");

                }
                else if (Ql[i].Questionheader == QuestionHeader.ONECHOOES)
                {
                    Console.WriteLine("Q-chooes the correct answer, you can write correct Chooes in answer part.");

                }
                else if (Ql[i].Questionheader == QuestionHeader.MULTICHOOES)
                {
                    Console.WriteLine("Q-chooes the correct answer, you can write correct chooes sperted by , in order that you show in answer part.");

                }
                Console.WriteLine(ex.ElementAt(i).Key);
                Console.WriteLine(ex.ElementAt(i).Value);
                Console.WriteLine(" ");
                Console.Write("Your Answer is:");
                string userAnswer = Console.ReadLine();
                userAnswers.Add(userAnswer);
                if (userAnswer == questionsAnswers[i])
                {
                    studentGrade += Ql[i].QuestionMark;
                }


                Console.WriteLine(" ");

            }





        }

    }
}
