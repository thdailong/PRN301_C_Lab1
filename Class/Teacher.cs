using System;
using System.Text.RegularExpressions;

namespace Project02 {
    class Teacher:People {
        private string _TeacherCode;
        public string TeacherCode {
            get { return _TeacherCode; }
            set {
                string s = value;
                while(!isTeacherCode(s)) {
                    Console.Write("Error! Please enter a number from A0001 to A9999 or B0001-B9999!");
                    Console.Write("Input Teacher Code: ");
                    
                    s = Console.ReadLine();
                }
                _TeacherCode = s;
            }
        }
        
        private DateTime _JoinedDay;
        public DateTime JoinedDay
        {
            get { return _JoinedDay; }
            set { 
                DateTime tmp = value; 
                _JoinedDay = tmp;
            }
        }

        public Teacher(string Id_card, string Fullname, DateTime Birthday, string Address, string Email, string Phone, string TeacherCode, DateTime JoinedDay){
            this.Id_card = Id_card;
            this.Fullname = Fullname;
            this.Birthday = Birthday;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
            this.JoinedDay = JoinedDay;
            this.TeacherCode = TeacherCode;
        }
        public Teacher() {}
        public Teacher(string fullname) {
            this.Fullname = fullname;
        }
        public void inputTeacher() {
            inputPeople();
            System.Console.Write("Please enter Joined Day: ");
            JoinedDay = Convert.ToDateTime(Console.ReadLine());
            System.Console.Write("Please enter Teacher Code: ");
            TeacherCode = Console.ReadLine(); 
        }
        public bool isTeacherCode(string s) {
            string TeacherCodeRegex = @"[AB]{1}[0-9]{4}";

            Regex check = new Regex(TeacherCodeRegex);
            if(check.IsMatch(s)){
                return true;
            } else {
                return false;
            }
        }

        public override void printInfo()
        {
            
        }
    }
}