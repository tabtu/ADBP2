namespace ttxy.Model
{
    public class Parent
    {
        private uint _Pnum;
        private string _Name;
        private string _Mobile;
        private string _Email;

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string Mobile
        {
            get
            {
                return _Mobile;
            }

            set
            {
                _Mobile = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public uint Pnum
        {
            get
            {
                return _Pnum;
            }

            set
            {
                _Pnum = value;
            }
        }
    }
}
