using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator.GetCalculator().GetValue("62*3-78");
            //Console.WriteLine(Calculator.GetCalculator().Display());
            //Calculator.GetCalculator().SetResult();
            //Console.WriteLine(Calculator.GetCalculator().GetResult());

            Calculator.Calculator.GetCalculator().GetValue("35*25,6/6");
            Calculator.Calculator.GetCalculator().ClearChar();
            Calculator.Calculator.GetCalculator().ClearChar();
            Calculator.Calculator.GetCalculator().ClearChar();
            Calculator.Calculator.GetCalculator().GetValue("=");
           Console.WriteLine( Calculator.Calculator.GetCalculator().GetResult());
            

            Console.Read();

        }
    }
}
