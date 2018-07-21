using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// Class of calculation example
    /// Base writed by Natalya Aubury
    /// </summary>
    public class Calculator
    {
        private List<double> lstNumber = new List<double>();
        private List<Operation> lstOper = new List<Operation>();

        private static Calculator instance = null;
        private double Result = 0;

        /// <summary>
        /// Writed by Natalya Aubury
        /// </summary>
        private Calculator() { }

        /// <summary>
        /// Returns one instance
        /// Writed by Natalya Aubury
        /// </summary>
        /// <returns>Instance of Calculator</returns>
        public static Calculator GetCalculator()
        {
            if (instance == null)
                instance = new Calculator();
            return instance;

        }

        /// <summary>
        /// Clears all fields and example
        /// Writed by Natalya Aubury
        /// </summary>
        public void Clear()
        {
            if (lstNumber != null)
            {
                lstNumber.Clear();
            }
            if (lstOper != null)
            {
                lstOper.Clear();
            }
            Result = 0;
        }

        private bool AddOperation(char ch)
        {
            if (isAnotherOperation(ch))
                return true;

            switch (ch)
            {
                case '+':
                    {
                        lstOper.Add(new Sum());
                        break;
                    }
                case '-':
                    {
                        lstOper.Add(new Sub());
                        break;
                    }
                case '*':
                    {
                        lstOper.Add(new Mult());
                        break;
                    }
                case '/':
                    {
                        lstOper.Add(new Div());
                        break;
                    }
                case '^':
                    {
                        lstOper.Add(new Pow());
                        break;
                    }
                default:
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Writed by Natalya Aubury
        /// </summary>
        private bool isAnotherOperation(char ch)
        {
            switch (ch)
            {
                case 'c':
                    Clear();
                    return true;

                case '=':
                    SetResult();
                    return true;

                case '<':
                    ClearChar();
                    return true;
                default:
                    return false;


            }
        }

        /// <summary>
        /// Writed by Natalya Aubury
        /// </summary>
        public void SetResult()
        {
            int j = 0;
          Result = lstNumber[0];

            foreach (var i in lstOper)
            {
                Result = i.execute(Result, lstNumber[++j]);
               
            }
        }

        /// <summary>
        /// Clears one char in example
        /// Writed by Michail
        /// </summary>
        public void ClearChar()
        {
            if (lstNumber.Count == 0 && lstOper.Count == 0)
            {
                return;
            }
            else
            {
                string str0=null;
                string str=null;
                char ch = ' ';
              

                for(int i=0; i<lstNumber.Count;i++)
                {
                    try
                    {
                         if (lstOper[i] ==null) { ch = ' '; }
                         if (lstOper[i].ToString() == "Calculator.Sum") { ch = '+'; }
                         if (lstOper[i].ToString() == "Calculator.Sub") { ch = '-'; }
                         if (lstOper[i].ToString() == "Calculator.Mult") { ch = '*'; }
                         if (lstOper[i].ToString() == "Calculator.Div") { ch = '/'; }
                         if (lstOper[i].ToString() == "Calculator.Pow") { ch = '^'; }
                         
                    }
                    catch
                    {
                        str0 = lstNumber[i].ToString();
                        str += str0;
                        break;
                    }
                        
                        str0=lstNumber[i].ToString() + ch.ToString();
                        str += str0;
                    
                   
                    str0 = null;
                    ch = ' ';

                }
               
                Console.WriteLine("str 1 = " + str);
                string str2 = str.Remove(str.Length-1 , 1);
                Console.WriteLine("str 2 = " + str2);

                Clear();
                GetValue(str2);

            }

        }

        /// <summary>
        /// Gets object, and converted to example
        /// Writed by Honcharov Nikita. Rewrited by Igor Nebosenko
        /// </summary>
        /// <param name="obj">Object with example. Must be a string</param>
        /// <returns>true if all correct. In another variants - False</returns>
        public bool GetValue(object obj)
        {
            //this.lstNumber.Clear();
            //this.lstOper.Clear();

            string str = obj.ToString();
            StringBuilder sb = new StringBuilder();
            bool isNowDigit = true;
            if( obj == "=")
            {
               SetResult();
                return true;
            }
            if( obj == "<")
            {
                ClearChar();
                return true;
            }
            if(obj == "C" || obj == "c")
            {
                Clear();
                return true;
            }

            for (int i = 0; i < str.Length; ++i)
            {
                if (isNowDigit)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                        sb.Append(str[i]);
                    else if (str[i] == '.' || str[i] == ',')
                        sb.Append(',');
                    else if (str[i] == '-' && sb.Length == 0)
                        sb.Append('-');
                    else
                        isNowDigit = false;
                }

                if (!isNowDigit)
                {
                    lstNumber.Add(double.Parse(sb.ToString()));
                    sb.Clear();
                    if (!AddOperation(str[i]))
                        return false;
                    isNowDigit = true;
                }
            }
            if (sb.Length != 0)
                this.lstNumber.Add(double.Parse(sb.ToString()));
          
            return true;
        }

        /// <summary>
        /// Returns result.
        /// By Igor Nebosenko
        /// </summary>
        /// <returns></returns>
        public double GetResult()
        {
            return Result;
        }
    }
}