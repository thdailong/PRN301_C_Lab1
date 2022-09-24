using System;
using System.Text.RegularExpressions;

namespace Project02
{
    class checkInput
    {
        public static string checkRoll(string str)
        {
            while (true)
            {
                string strRegex = @"A12\d{3}$";
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

        public static string checkStudentName(string str)
        {
            while (true) {
                if (str.Length > 50) {
                    System.Console.WriteLine("Student name only valid within 50 characters!");
                    Console.Write("Enter again: ");
                    continue;
                }
                bool onlyLetter = true;
                foreach(char c in str) {
                    if (c == ' ' || Char.IsLetter(c));
                    else {
                        onlyLetter = false;
                        break;
                    }
                    
                }
                if (onlyLetter) return str;
                System.Console.WriteLine("Student name only valid have alphabet and space character!");
                Console.Write("Enter again: ");
            }
        }
    }

    class Marks_Subject : Marks, IMarks
    {
        private string _RollNo;
        public string RollNo
        {
            get { return _RollNo; }
            set { _RollNo = checkInput.checkRoll(value); }
        }
        private string _StudentName;
        public string StudentName
        {
            get { return _StudentName; }
            set { _StudentName = checkInput.checkStudentName(value); }
        }

        private string _Subject;
        public string Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }

        private int _TestTime;
        public int TestTime
        {
            get { return _TestTime; }
            set { _TestTime = value; }
        }

        public override string ToString()
        {
            return $"Name: {StudentName}, subject: {Subject}, marks: {marks} ";
        }

        public Marks_Subject()
        {
            this._RollNo = "";
            this._TestTime = 0;
            this._marks = 0;
            this._marks = 0;
            this._passLevel = 0;
        }

        public Marks_Subject(int marks, int passlevel)
        {
            this.marks = marks;
            this.passLevel = passLevel;
        }

        public void inputMarks()
        {

        }

        public void printMarks()
        {

        }

        public override bool getBonus()
        {
            return true;
        }
    }
}