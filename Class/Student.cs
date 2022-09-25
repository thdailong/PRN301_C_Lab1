using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Project02
{
            class Student:People{
                private string _rollname;
                private string _classno;
                public string Rollname
                {
                    get { return _rollname; }
                    set { string r = value;
                        // bool sw = r.StartsWith("A12", false, CultureInfo.CurrentCulture); 
                        //     int number_ThreeLastNumber = 100;
                        // if(r.Length == 6){
                        //    string  ThreeLastNumber = r.Substring(r.Length - 3);
                        //     number_ThreeLastNumber = int.Parse(ThreeLastNumber);  
                        //} else{
                            //sw == false || r.Length != 6 || number_ThreeLastNumber < 1 || number_ThreeLastNumber > 299
                           Boolean checkrollname = isRollName(r);
                            while(checkrollname == false){
                            System.Console.WriteLine("RollNo must be in range A12001-A12999");
                            System.Console.Write("Please enter Rollname: ");
                            r = Console.ReadLine();
                            checkrollname = isRollName(r);
                            // sw = r.StartsWith("A12", false, CultureInfo.CurrentCulture);
                            // string ThreeLastNumber = r.Substring(r.Length - 3);
                            // number_ThreeLastNumber = int.Parse(ThreeLastNumber);
                        //}  
                        }
                        _rollname = r;
                    }
                }

                public string Classno
                {
                    get => _classno;
                    set { string c = value;
                        Boolean checkclassno = isClassNo(c);
                        while(checkclassno ==false){
                            System.Console.WriteLine("Classno must following format [CP / DI / DM + year + month + G/H/I/J/K/F/M + xx]");
                            System.Console.Write("Please enter your Classno: ");
                            c = System.Console.ReadLine();
                            checkclassno = isClassNo(c);
                        }
                        _classno = c;
                    }
                }

                public bool isRollName(string rollname){
                        rollname = rollname??string.Empty;
                        string rollnameRegex = @"^(A12+[0-9][0-9][1-9])$";
                        var checkrollName = new Regex(rollnameRegex, RegexOptions.IgnoreCase);
                        return checkrollName.IsMatch(rollname);
                }

                public bool isClassNo(string classno){
                    classno = classno??string.Empty;
                    string classnoRegex = @"(CP|DI|DM)[1-9][0-9]{3}(0?[1-9]|11|12|10)(G|H|I|J|K|F|M)[a-zA-Z0-9]{2}";
                    var checkClassno = new Regex(classnoRegex, RegexOptions.IgnoreCase);
                    return checkClassno.IsMatch(classno);
                }

                public Student(){}
                public Student(string _rollname, string _classno, string _id_card, string _fullname, DateTime _birthday, string _address, string _email, string _phone) : base(_id_card, _fullname, _birthday, _address, _email, _phone){
                    this.Rollname = Rollname;
                    this.Classno = Classno;
                }

                // private double[] marks;

                // public double this[int i]{
                //     get => marks[i];
                //     set => marks[i] = value;
                // }

                // public double getAvgMark(){
                //     double sum = 0, num = 0;
                //     foreach (var item in marks)
                //     {
                //         sum += item;
                //         ++num;
                //     }
                //     return sum / num;
                // }

                public override void printInfo(){
                    System.Console.WriteLine($"{Rollname}, {Classno}");
                }

                public void inputStudent(){
                    base.inputPeople();
                    System.Console.Write("Please enter your rollname: ");
                    Rollname = Console.ReadLine();
                    System.Console.Write("Please enter your classno: "); 
                    Classno = Console.ReadLine();
                }

   }
                
}
