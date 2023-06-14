namespace Utilities
{
    // i know very will user cannot make object from questions 
    // it only will make object from any type of question [T/F -one choose-multiChoose]
    public enum QuestionHeader
    {
        TRUEFALSEQUESTION,
        ONECHOOES,
        MULTICHOOES
    }
    public abstract class Question
    {   public static int QestionNum;
        private string questionBody;
        private QuestionHeader questionheader;
        private int questionMark;
        private string questionRightAnswer;

       public Question(string body, QuestionHeader qh,int mark,string qrAnswer)
        {
            QestionNum++;
            QuestionBody =body;
            QuestionRightAnswer = qrAnswer;
            QuestionMark = mark;
            Questionheader=qh;
        }


        public string QuestionBody { get => questionBody; set => questionBody = value; } 
        public string QuestionRightAnswer { get => questionRightAnswer; set => questionRightAnswer = value; }
        public int QuestionMark { get => questionMark; set => questionMark = value; }
        internal QuestionHeader Questionheader { get => questionheader; set => questionheader = value; }
    }
}