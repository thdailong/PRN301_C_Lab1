using System;
using Project02;

namespace C_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
          TestSubject();
        }
        static void TestSubject(){
              Subject s = new Subject();
        s.inputSubject();
        s.printInfo(s);

        }
    }
}
