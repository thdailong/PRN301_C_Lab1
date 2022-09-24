using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Project02
{
 class People
    {
        private string _id_card;
        private string _fullname;
        private DateTime _birthday;
        private int _age;
        private string _address;
        private string _email;
        private string _phone;

        private List<People> list = null;

        public string Id_card
        {
            get { return _id_card; }
            set { string s = value;
                
                while(s.Length != 9) {
                    Console.Write("Error! Please enter ID Card has 9 digits!");
                    Console.Write("Input ID Card: ");
                    
                    s = Console.ReadLine();
                }
                _id_card = s;
            } 
             }    

        public string Fullname
        {
            get { return _fullname; }
            set { string f = value;
                while (f.Length > 50)
                {
                    System.Console.WriteLine("Error! please enter your full name < 50 characters !");
                    System.Console.Write("Enter your full name: ");
                    f = Console.ReadLine();
                }
                _fullname = f;
             }
        }
        
        public DateTime Birthday
        {
            get => _birthday; 
            set { _birthday = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        

        public string Address
        {
            get { return _address; }
            set { string a = value;
            while(a == null){
                System.Console.WriteLine("Error! your address cant't be null.");
                System.Console.Write("Enter your Address: ");
                a = Console.ReadLine();
            }
            _address = a;
             }
        }
        
    
        public string Email
        {
            get { return _email; }
            set { string e = value;
                Boolean checkEMail = isEmail(e);
                while(checkEMail == false){
                    System.Console.WriteLine("Error! Please input valid email address!");
                    System.Console.Write("Enter your email: ");
                    e = Console.ReadLine();
                }
                _email = e;
             }
        }
            
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        
        
        public People(){}
        public People(string Id_card, string Fullname, DateTime Birthday, int Age, string Address, string Email, string Phone){
            this.Id_card = Id_card;
            this.Fullname = Fullname;
            this.Birthday = Birthday;
            this.Age = Age;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
        }


        public override string ToString(){
            return string.Format(this.Fullname, this.getAge(Birthday), this.Phone);
        }

         public int getAge(DateTime birthday){
            var today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if(today.Month < Birthday.Month || today.Month == Birthday.Month && today.Day < Birthday.Day){
                age--;
            }
            return age;
        }

        public bool isEmail(string Email){
            Email = Email??string.Empty;
            string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex checkmail = new Regex(emailRegex);
            if(checkmail.IsMatch(Email)){
            return true;
            } else {
            return false;
            }
        }

        public static bool hasSpecialChar(string input){
            Regex sp_char = new Regex("[^A-Za-z0-9]");
            bool hasSpecialChar = sp_char.IsMatch(input);
            return hasSpecialChar;
        }

        public void inputPeople(){
            System.Console.Write("Please enter id card: ");
            Id_card = Console.ReadLine(); 

            System.Console.Write("Please enter full name: ");
            Fullname = Console.ReadLine(); 

            System.Console.Write("Please enter birthday: ");
            Birthday = Convert.ToDateTime(Console.ReadLine());

            System.Console.Write("Please enter address(*): ");
            Address = Console.ReadLine();

            System.Console.Write("Please enter email: ");
            Email = Console.ReadLine();

            System.Console.Write("Please enter phone: ");
            Phone= Console.ReadLine();
        }

        public void printInfo(){
            Console.WriteLine(this.Fullname, this.Birthday);
        }

        public People(string fullname){
            this.Fullname = fullname;
        }

    }

}
