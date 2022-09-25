using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project02
{
    public class CheckType
    {
        public static string checkSubjectCode()
        {
            while (true)
            {
                string result = Console.ReadLine();
                string strRegex = @"^[A-Za-z]{6}$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(result))
                {
                    return result;
                }
                else
                {
                    System.Console.WriteLine("Invalid subject code. The subject code must be 6 characters.");
                    System.Console.Write("Enter again: ");
                }
            }
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
        public static string checkSubjectName()
        {
            while (true)
            {
                string result = Console.ReadLine();
                string strRegex = @"^[A-Za-z0-9]{0,50}$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(result))
                {
                    return result;
                }
                else
                {
                    System.Console.WriteLine("Invalid subject name!. The subject name has most 50 characters.");
                    System.Console.Write("Enter again: ");
                }
            }
        }
    }
}


