using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Project02
{
 abstract class People
    {
        private string _id_card;
        private string _fullname;
        private DateTime _birthday;
        private string _address;
        private string _email;
        private string _phone;

        public string Id_card
        {
            get { return _id_card; }
            set { string s = value;
                
                while(s.Length != 9) {
                    Console.WriteLine("Error! Please enter ID Card has 9 digits! ");
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
            set { _birthday = value;
                DateTime b = value;
                var today = DateTime.Today;
                DateTime limit = new DateTime(1900, 1, 1);    
                int x = (limit.Year *100 + limit.Month) * 100 + limit.Day;
                int y = (today.Year *100 + today.Month) * 100 + today.Day;
                int z = (b.Year *100 + b.Month) * 100 + b.Day;
             // b.Day >= limit.Day && b.Month >= limit.Month && b.Year >= limit.Year && b.Day <= today.Day && b.Month <= today.Month && b.Year <= today.Year
                while(z < x || y < z){
                    System.Console.WriteLine("Your birthday must more than or equal 01/01/1900 and less than today, please try again!");
                    System.Console.Write("Enter your birthday: ");
                    b = Convert.ToDateTime(Console.ReadLine());
                    z = (b.Year *100 + b.Month) * 100 + b.Day;
                }
                    _birthday = b;
            
             }
        }
        public string Address
        {
            get { return _address; }
            set { string a = value;
            while(a.Length == 0){
                System.Console.WriteLine("Error! your address cant't be blank.");
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
                    checkEMail = isEmail(e);
                }
                _email = e;
             }
        }
            
        public string Phone
        {
            get { return _phone; }
            set { string p = value;
            Boolean checkPhone = isNumberPhone(p);
            while (checkPhone == false){
                 System.Console.WriteLine("Error! Please input valid number phone!");
                    System.Console.Write("Enter your number phone: ");
                    p = Console.ReadLine();
                    checkPhone = isNumberPhone(p);
            }
                _phone = p;
            }
        }
        
        
        public People(){}
        public People(string Id_card, string Fullname, DateTime Birthday, string Address, string Email, string Phone){
            this.Id_card = Id_card;
            this.Fullname = Fullname;
            this.Birthday = Birthday;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
        }


        public override string ToString(){
            string ts = $"{Fullname}, {getAge(Birthday)}, {Phone}";
            return ts;
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
            string emailRegex = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + 
                                @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + 
                                @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
                    var checkmail  = new Regex(emailRegex, RegexOptions.IgnoreCase);
                    return checkmail.IsMatch(Email);
        }


        public bool isNumberPhone(string Phone){
            Phone = Phone??string.Empty;
            string phoneRegex = @"(((\+|)84)|0)(3|5|7|8|9)+([0-9]{8})\b";
            var checkphone = new Regex(phoneRegex, RegexOptions.IgnoreCase);
            return checkphone.IsMatch(Phone);
        }

        public static bool hasSpecialChar(string input){
            Regex sp_char = new Regex("[^A-Za-z0-9]");
            bool hasSpecialChar = sp_char.IsMatch(input);
            return hasSpecialChar;
        }

        public void inputPeople(){
    
            System.Console.Write("Please enter your id card: ");
            Id_card = Console.ReadLine(); 

            System.Console.Write("Please enter your full name: ");
            Fullname = Console.ReadLine(); 

            System.Console.Write("Please enter your birthday(as mm/dd/yyyy): ");
            Birthday = Convert.ToDateTime(Console.ReadLine());
    
            System.Console.Write("Please enter your address(*): ");
            Address = Console.ReadLine();

            System.Console.Write("Please enter your email: ");
            Email = Console.ReadLine();

            System.Console.Write("Please enter your phone: ");
            Phone= Console.ReadLine();

            
        }

        public abstract void printInfo();

        public People(string fullname){
            this.Fullname = fullname;
        }


    // class Program
    // {
    //     static void Main(string[] args)
    //     {   
    //     }
    // }
    }
}