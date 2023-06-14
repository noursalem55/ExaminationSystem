using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Utilities
{
   public class QuestionList:List<Question>
    {
        public new void Add(Question item, string q)
        {
            base.Add(item);
            string file = $"E:\\Question{q}.txt";
            try
            {
                // create the file
                using (TextWriter writer = File.AppendText(file))
                {

                    writer.WriteLine(item);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
