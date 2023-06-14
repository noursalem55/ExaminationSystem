using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public enum TrueFalseChooes{
    True,
    False
    }
    public class Answers
    {
        private int Flag = 0;
        private string chooes_1;
        private string chooes_2;
        private string chooes_3;
        private string chooes_4;
        private TrueFalseChooes trueChooes;
        private TrueFalseChooes falseChooes;



        public Answers(string a, string b, string c, string d)
    {
            Flag = 0;
            Chooes_1 = a;
            Chooes_2 = b;
            Chooes_3 = c;
            Chooes_4 = d;

        }
        public Answers(TrueFalseChooes a, TrueFalseChooes b)
        {
            Flag = 1;
            TrueChooes = a ;
            FalseChooes = b;
        }  

        public string Chooes_1 { get => chooes_1; set => chooes_1 = value; }
        public string Chooes_2 { get => chooes_2; set => chooes_2 = value; }
        public string Chooes_3 { get => chooes_3; set => chooes_3 = value; }
        public string Chooes_4 { get => chooes_4; set => chooes_4 = value; }
        public TrueFalseChooes TrueChooes { get => trueChooes; set => trueChooes = value; }
        public TrueFalseChooes FalseChooes { get => falseChooes; set => falseChooes = value; }

        public override string ToString()
        {
            if(Flag == 0)
            {
                return $" a){Chooes_1} b){Chooes_2} c){Chooes_3} d){Chooes_4}";
            }
            else
            {
                return $"a){TrueChooes.ToString()} b){FalseChooes.ToString()}";
            }
            
            
           
        }
    }
}
