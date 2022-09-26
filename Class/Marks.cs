using System;
using System.Text.RegularExpressions;

namespace Project02
{
    class checkInputMarks
    {
        public static int checkNumber(int value, int min, int max, bool input)
        {
            string strRes = "";
            if (input) strRes = Console.ReadLine();
            else strRes += value;
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(strRes);
                    if (result < min || result > max)
                    {
                        throw new Exception();
                    }
                    return result;
                }
                catch (Exception e)
                {
                    System.Console.WriteLine($"Please input number in range [{min}, {max}]");
                    System.Console.Write("Enter again: ");
                    strRes = Console.ReadLine();
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
            set { _marks = checkInputMarks.checkNumber(value, 0, 100, false); }
        }
        public int passLevel
        {
            get { return _passLevel; }
            set { _passLevel = checkInputMarks.checkNumber(value, 40, 100, false); }
        }

        public bool checkPass()
        {
            if (marks < passLevel) return false;
            return true;
        }
        public abstract bool getBonus();
    }
}
