using Utilities;
public class Program
{
    public static void Main1()
    {
        //  diffrent type of Questions
        QuestionHeader myQhTF = QuestionHeader.TRUEFALSEQUESTION;
        QuestionHeader myQhOC = QuestionHeader.TRUEFALSEQUESTION;
        QuestionHeader myQhMC = QuestionHeader.TRUEFALSEQUESTION;

        // create Quetions
        TrueAndFalseQuestions firstQuestion = new TrueAndFalseQuestions("IS c# programming language", myQhTF, 10,"T");
        oneChoosesQuestion secondQuestion = new oneChoosesQuestion("what c# ", myQhOC, 10, "programming language");
        MultiChooesQuestion thirdQuestion = new MultiChooesQuestion("what is programming language exist in this list", myQhTF, 10, "c#,java ,c++");
       
        // put quetions in list
           // list-1
        QuestionList List1 = new QuestionList();
          // list-2
        QuestionList List2 = new QuestionList();

        //  add quetions in list-1 & file
        List1.Add(firstQuestion, "List1");
        List1.Add(secondQuestion, "List1");
        List1.Add(thirdQuestion, "List1");
           // show Quetions in list-one
        foreach(var item in List1)
        {
            Console.WriteLine(item);
        }
        //  add quetions in list-2 & file
        List2.Add(firstQuestion, "List2");
        List2.Add(secondQuestion, "List2");
        List2.Add(thirdQuestion, "List2");

        // show Quetions in list-two
        foreach (var item in List2)
        {
            Console.WriteLine(item);
        }
        //-----------------------------------------------------------------------
        // create diffrent type of answers
        Answers answers1 = new Answers("html", "css", "js", "bootstrap");
        Answers answers2 = new(TrueFalseChooes.True, TrueFalseChooes.False);
        Answers answers3 = new Answers("hperText", "programmingLanguge", "graphic", "nothing");

        // create list
        AnswerList l1 = new AnswerList();
        l1.Add(answers1, "l1");
        l1.Add(answers2, "l1");
        l1.Add(answers3, "l1");




    }
}