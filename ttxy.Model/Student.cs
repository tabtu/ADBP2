using System;

namespace ttxy.Model
{
    public class Student
    {
        private uint _stnum;
        private string _name;
        private DateTime _birth;
        private DateTime _joindate;
        private string _mobile;
        private string _email;
        private string _address;
        private bool _active;

        public uint Stnum
        {
            get
            {
                return _stnum;
            }

            set
            {
                _stnum = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public DateTime Birth
        {
            get
            {
                return _birth;
            }

            set
            {
                _birth = value;
            }
        }

        public DateTime Joindate
        {
            get
            {
                return _joindate;
            }

            set
            {
                _joindate = value;
            }
        }

        public string Mobile
        {
            get
            {
                return _mobile;
            }

            set
            {
                _mobile = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public bool Active
        {
            get
            {
                return _active;
            }

            set
            {
                _active = value;
            }
        }
    }
}
