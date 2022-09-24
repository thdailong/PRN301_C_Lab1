using System;
namespace Project02 {
    class Teacher:People {
        private string _TeacherCode;
        public string TeacherCode
        {
            get { return _TeacherCode; }
            set { _TeacherCode = value; }
        }
        
        private string _JoinedDay;
        public string JoinedDay
        {
            get { return _JoinedDay; }
            set { _JoinedDay = value; }
        }

        
        
    }
}