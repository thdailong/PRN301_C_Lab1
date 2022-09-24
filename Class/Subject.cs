using System;
using System.Text.RegularExpressions;
namespace Project02
{
    class Subject
    {
        public Subject()
        {

        }
        public Subject(string subject_Code, string subject_Name, int theory, int practice)
        {
            Subject_Code = Subject_Code;
            Subject_Name = Subject_Name;
            Theory = Theory;
            Practice = Practice;

        }
        public string Subject_Code { get; set; }
        public string Subject_Name { get; set; }
        public int Theory { get; set; }
        public int Practice { get; set; }

        public int getTotalLesson()
        {
            return Theory + Practice;


        }
        public override string ToString()
        {
            return $"Subject Code:{Subject_Code}\nSubject Name:{Subject_Name}\nTheory:{Theory}\nPractice:{Practice}\nTotal number of lesson:{getTotalLesson()}";

        }
        public static int checkNumber(int min, int max)
        {
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result <= min || result >= max)
                    {
                        throw new Exception();
                    }
                    return result;
                }
                catch (Exception e)
                {
                    System.Console.WriteLine($"Please input number in range [{min}, {max}]");
                    System.Console.Write("Enter again: ");
                }
            }
        }




        public void inputSubject()
        {
            System.Console.Write("Enter subject code: ");
            Subject_Code = CheckType.checkSubjectCode();
            System.Console.Write("Enter subject name: ");
            Subject_Name = CheckType.checkSubjectName();
            System.Console.Write("Enter theory: ");
            Theory = CheckType.checkNumber(0, 100);
            System.Console.Write("Enter practice: ");
            Practice = CheckType.checkNumber(0, 100);
            // Subject s = new Subject(subject_code, subject_name, theory, practice);
        }

        public void printInfo(Subject s)
        {
            Console.WriteLine(s.ToString());
        }


    }
}

