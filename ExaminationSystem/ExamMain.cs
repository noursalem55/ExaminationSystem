using Utilities;
public class Program2
{
    public static void Main()
    {
        //  diffrent type of Questions
        QuestionHeader myQhTF = QuestionHeader.TRUEFALSEQUESTION;
        QuestionHeader myQhOC = QuestionHeader.ONECHOOES;
        QuestionHeader myQhMC = QuestionHeader.MULTICHOOES;

        // create Quetions
        TrueAndFalseQuestions firstQuestion = new TrueAndFalseQuestions("IS c# programming language", myQhTF, 10, "T");
        oneChoosesQuestion secondQuestion = new oneChoosesQuestion("what c# ", myQhOC, 10, "programming language");
        MultiChooesQuestion thirdQuestion = new MultiChooesQuestion("what is programming language exist in this list", myQhMC, 10, "c#,js");
        TrueAndFalseQuestions Question4 = new TrueAndFalseQuestions("IS M# in .net framework", myQhTF, 10, "F");
        oneChoosesQuestion Question5 = new oneChoosesQuestion("what nullable operator ", myQhOC, 10, "?");
        MultiChooesQuestion Question6 = new MultiChooesQuestion("what is programming language exist in .net fram work", myQhMC, 10, "C#,F#");
        TrueAndFalseQuestions Question7 = new TrueAndFalseQuestions("IS F# programming language", myQhTF, 10, "T");
        oneChoosesQuestion Question8 = new oneChoosesQuestion("deiven class is a ", myQhOC, 10, "child class");
        MultiChooesQuestion Question9 = new MultiChooesQuestion("what is oop pallers ", myQhMC, 10, "inheritance,plomorphism,abstraction");

        // put quetions in list
        // list-1
        QuestionList List1 = new QuestionList();

        //  add quetions in list-1 & file
        List1.Add(firstQuestion, "List1");
        List1.Add(secondQuestion, "List1");
        List1.Add(thirdQuestion, "List1");
        List1.Add(Question4, "List1");
        List1.Add(Question5, "List1");
        List1.Add(Question6, "List1");
        //List1.Add(Question7, "List1");
        //List1.Add(Question8 ,"List1");
        //List1.Add(Question9, "List1");

        //==========================================================================
        // create diffrent type of answers
        Answers answers1 = new Answers("html", "c#", "js", "bootstrap");
        Answers answers2 = new(TrueFalseChooes.True, TrueFalseChooes.False);
        Answers answers3 = new Answers("hperText", "programming language", "graphic", "nothing");
        Answers answers4 = new(TrueFalseChooes.True, TrueFalseChooes.False);
        Answers answers5 = new Answers("!!", "!?", "?", "??");
        Answers answers6 = new Answers("C#", "N#", "F#", "B#");
        Answers answers7 = new(TrueFalseChooes.True, TrueFalseChooes.False); 
        Answers answers8 = new Answers("child class", "superClass", "class", "inclass");
        Answers answers9 = new Answers("inheritance", "plomorphism", "abstraction", "nothing");

        // create list
        AnswerList l1 = new AnswerList();
        l1.Add(answers2, "l1");
        l1.Add(answers3, "l1");
        l1.Add(answers1, "l1");
        l1.Add(answers4, "l1");
        l1.Add(answers5, "l1");
        l1.Add(answers6, "l1");
        //l1.Add(answers7, "l1");
        //l1.Add(answers8, "l1");
        //l1.Add(answers9, "l1");

        //=======================================================
        Console.WriteLine("Please Enter Type of Exam do You want. you can write (P) for practical Exam or (F) for final Exam");
        string userChooes = Console.ReadLine();
        if(userChooes == "P")
        {
            Console.Clear();
            PracticalExam firstExam = new PracticalExam();
            firstExam.ShowExam(List1, firstExam.GenerateExam(List1, l1));
            Console.WriteLine("=========================================================================");
            firstExam.ExamResult(List1);

        }else if(userChooes == "F")
        {
            
            FinalExam firstExam = new FinalExam();
            firstExam.ShowExam(List1, firstExam.GenerateExam(List1, l1));
            Console.WriteLine("=========================================================================");

            firstExam.ExamResult(List1);

        }
        else
        {
            Console.Clear();
        }

       

    }
}
