using System;
namespace Project02
{
            class Student:People{
                private string _rollname;
                private string _classno;

                public string Rollname
                {
                    get { return _rollname; }
                    set { _rollname = value; }
                }

                public string Classno
                {
                    get => _classno;
                    set => _classno = value;
                }

                private double[] marks;

                public double this[int i]{
                    get => marks[i];
                    set => marks[i] = value;
                }

                public double getAvgMark(){
                    double sum = 0, num = 0;
                    foreach (var item in marks)
                    {
                        sum += item;
                        ++num;
                    }
                    return sum / num;
                }

               // public void intputStudent(string rollname, string classno):base inputPeople( Id_card, fullname, birthday, age, address, email, phone){
                    
                }
                
}
