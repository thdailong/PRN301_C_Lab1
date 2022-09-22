using System;
namespace Project02
{
    abstract class People
    {
        private int _id_card;
        private string _fullname;
        private string _birthday;
        private int _age;
        private string _address;
        private string _email;
        private string _phone;


        public string ToString(string fullname, int age, string phone){
            string information = $"{fullname}, {age}, {phone}";
            return information;
        }

        public int Id_card
        {
            get { return _id_card; }
            set { _id_card = value; }
        }
        
    
        public string Fullname
        {
            get { return _fullname; }
            set { _fullname = value; }
        }
        
        public string Birthday
        {
            get { return _birthday; }
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
            set { _address = value; }
        }
        
    
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
                
        public string Phone
        {
            get { return _email; }
            set { _email = value; }
        }

        
        
    }
}
