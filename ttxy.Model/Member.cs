namespace ttxy.Model
{
    public class Member
    {
        private string _usrname;
        private string _pwd;
        private bool _is_stu;
        private uint _stnum;

        public string Usrname
        {
            get
            {
                return _usrname;
            }

            set
            {
                _usrname = value;
            }
        }

        public string Pwd
        {
            get
            {
                return _pwd;
            }

            set
            {
                _pwd = value;
            }
        }

        public bool Is_stu
        {
            get
            {
                return _is_stu;
            }

            set
            {
                _is_stu = value;
            }
        }

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
    }
}
