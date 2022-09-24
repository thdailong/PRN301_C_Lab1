using System;

namespace Project02
{
    abstract class Marks
    {
        protected int _marks;
        protected int _passLevel;
        public int marks
        {
            get { return _marks; }
            set { _marks = value; }
        }
        public int passLevel
        {
            get { return _passLevel; }
            set { _passLevel = value; }
        }
        
        public bool checkPass() {
            if (marks < passLevel) return false;
            return true;
        }
        public abstract bool getBonus();
    }
}
