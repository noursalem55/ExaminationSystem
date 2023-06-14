using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class PracticalExam : Exam
    {
        public void ExamResult(QuestionList Ql)
        {
            Console.WriteLine($"you score is:{studentGrade}");
            Console.WriteLine("");
            foreach (var item in Ql)
            {
                Console.WriteLine($"{item.QuestionBody}");
                Console.WriteLine($"the right soluation is:{ item.QuestionRightAnswer}");
                Console.WriteLine(" ");

            }

        }
    }
}
