using System;
using System.Text.RegularExpressions;

namespace Project02
{
    class checkInput
    {
        public static string checkRoll(string str, bool input)
        {
            if (input) str = Console.ReadLine();
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
                    str = Console.ReadLine();
                }
            }

        }

        public static string checkStudentName(string str, bool input)
        {
            if (input) str = Console.ReadLine();
            while (true)
            {
                if (str.Length > 50)
                {
                    System.Console.WriteLine("Student name only valid within 50 characters!");
                    Console.Write("Enter again: ");
                    continue;
                }
                bool onlyLetter = true;
                foreach (char c in str)
                {
                    if (c == ' ' || Char.IsLetter(c)) ;
                    else
                    {
                        onlyLetter = false;
                        break;
                    }

                }
                if (onlyLetter) return str;
                System.Console.WriteLine("Student name only valid have alphabet and space character!");
                Console.Write("Enter again: ");
                str = Console.ReadLine();
            }
        }

        public static string checkSubject(string str, bool input)
        {
            if (input) str = Console.ReadLine();
            while (true)
            {
                if (str.Length == 0)
                {
                    System.Console.WriteLine("Subject should not be blank!");
                    Console.Write("Enter again: ");
                    str = Console.ReadLine();
                }
                else return str;
            }
        }


    }

    class Marks_Subject : Marks, IMarks
    {
        private string _RollNo;
        public string RollNo
        {
            get { return _RollNo; }
            set { _RollNo = checkInput.checkRoll(value, false); }
        }
        private string _StudentName;
        public string StudentName
        {
            get { return _StudentName; }
            set { _StudentName = checkInput.checkStudentName(value, false); }
        }

        private string _Subject;
        public string Subject
        {
            get { return _Subject; }
            set { _Subject = checkInput.checkSubject(value, false); }
        }

        private int _TestTime;
        public int TestTime
        {
            get { return _TestTime; }
            set { _TestTime = checkInputMarks.checkNumber(value, 1, 4, false); }
        }

        public override string ToString()
        {
            return $"Name: {StudentName}, subject: {Subject}, marks: {marks} ";
        }

        public Marks_Subject()
        {
            this._RollNo = "";
            this._StudentName = "";
            this._TestTime = 0;
            this._marks = 0;
            this._passLevel = 0;
            this._Subject = "";
        }

        public Marks_Subject(int marks, int passlevel)
        {
            this.marks = marks;
            this.passLevel = passLevel;
        }

        public void inputMarks()
        {
            System.Console.Write("Input roll no: ");
            this.RollNo = checkInput.checkRoll("", true);
            System.Console.Write("Input Student name: ");
            this.StudentName = checkInput.checkStudentName("", true);
            System.Console.Write("Input subject: ");
            this.Subject = checkInput.checkSubject("", true);
            System.Console.Write("Input test time: ");
            this.TestTime = checkInputMarks.checkNumber(0, 1, 4, true);
            System.Console.Write("Input mark: ");
            this.marks = checkInputMarks.checkNumber(0, 0, 100, true);
            System.Console.Write("Input pass level: ");
            this.passLevel = checkInputMarks.checkNumber(0, 40, 100, true);
        }

        public void printMarks() {
            System.Console.WriteLine($"Roll no: {RollNo}\nStudent name: {StudentName}");
            System.Console.WriteLine($"Subject: {Subject}\nTest time: {TestTime}");
            System.Console.WriteLine($"Marks: {marks}\nPass level: {passLevel}");
            if (checkPass()) System.Console.WriteLine("Pass: Yes");
            else System.Console.WriteLine("Pass: No");
            if (getBonus()) System.Console.WriteLine("Get Bonus: Yes");
            else System.Console.WriteLine("Get Bonus: No");
        }

        public override bool getBonus()
        {
            if (TestTime <= 2) return true;
            return false;
        }
    }
}