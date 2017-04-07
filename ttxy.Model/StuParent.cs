namespace ttxy.Model
{
    public class StuParent
    {
        private uint _stnum;
        private bool _mord;
        private bool _stpar;
        private uint _spnum;

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

        public bool Mord
        {
            get
            {
                return _mord;
            }

            set
            {
                _mord = value;
            }
        }

        public bool Stpar
        {
            get
            {
                return _stpar;
            }

            set
            {
                _stpar = value;
            }
        }

        public uint Spnum
        {
            get
            {
                return _spnum;
            }

            set
            {
                _spnum = value;
            }
        }
    }
}
