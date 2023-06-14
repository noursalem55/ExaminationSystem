using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class FinalExam:Exam
    {
        public void ExamResult(QuestionList Ql)
        {
            for (int i = 0; i < Ql.Count; i++)
            {
                Console.WriteLine($"{Ql[i].QuestionBody}");
                Console.WriteLine($"your answer for this question is:{userAnswers[i]}");

            }
            

        }
    }
}
