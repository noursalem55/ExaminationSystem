using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class AnswerList : List<Answers>
    {
        public new void Add(Answers item, string q)
        {
            base.Add(item);
            string file = $"E:\\Answer{q}.txt";
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
