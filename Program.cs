using System;
using  Project02;

namespace C_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
             Student st = new Student();
                    st.inputStudent();
                    st.printInfo();
                    string stt = st.ToString();
                        System.Console.WriteLine(stt);
                    
        }
    }
}
