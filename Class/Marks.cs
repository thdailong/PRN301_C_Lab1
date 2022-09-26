using System;
using System.Text.RegularExpressions;

namespace Project02
{
    class checkInputMarks {
        public static string checkRoll(string str)
        {
            while (true)
            {
                string strRegex = @"A12\d{2}[1-9]$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(str))
                {
                    return str;
                }
                else
                {
                    System.Console.WriteLine("Invalid student code. The subject code must be A12001 - A12999 .");
                    System.Console.Write("Enter again: ");
                }
            }

        }
    }
    abstract class Marks
    {
        protected int _marks;
        protected int _passLevel;
        public int marks
        {
            get { return _marks; }
            set { _marks = value; }
        }
        public int passLevel
        {
            get { return _passLevel; }
            set { _passLevel = value; }
        }

        public bool checkPass() {
            if (marks < passLevel) return false;
            return true;
        }
        public abstract bool getBonus();
    }
}
