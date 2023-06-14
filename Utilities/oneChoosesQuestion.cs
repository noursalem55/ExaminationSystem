using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class oneChoosesQuestion:Question
    {
        public oneChoosesQuestion(string body, QuestionHeader qh, int mark, string qrAnswer) : base(body, qh, mark, qrAnswer)
        {
           

        }
        public override string ToString()
        {
            return $"Q-{QuestionBody} ? \n {QuestionRightAnswer}";
        }
    }
}
