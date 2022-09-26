using System;
using Project02;

namespace C_Lab1
{
    class Program
    {
        static int menu()
        {
            System.Console.Write("--School managament--\n1.Manage student\n2.Manage teacher\n3.Manage subject\n4.Manage marks\n5.Exit\nPlease choose a function: ");
            int x = checkInputMarks.checkNumber(0, 1, 5, true);
            return x;
        }

        static void Main(string[] args)
        {
            while (true) {
                int option = menu();
                switch (option) {
                    case 1: 
                        ManageStudent();
                        break;
                    
                    case 2: 
                        ManageTeacher();
                        break;
                    
                    case 3: 
                        ManageSubject();
                        break;
                    
                    case 4: 
                        ManageMarks();
                        break;
                    
                    default:
                        break;
                    
                }
                if (option == 5) break;
            }
        }
        static void ManageSubject()
        {
            Subject s = new Subject();
            s.inputSubject();
            s.printInfo();
        }

        static void ManageMarks()
        {
            Marks_Subject n = new Marks_Subject();
            n.inputMarks();
            n.printMarks();
        }

        static void ManageStudent() {
            Student n = new Student();
            n.inputStudent();
            n.printInfo();
        }

        static void ManageTeacher() {
            Teacher n = new Teacher();
            n.inputTeacher();
            n.printInfo();
        }
    }
}
