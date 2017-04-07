namespace ttxy.Model
{
    public class Course
    {
        private uint _cosid;
        private string _name;
        private ushort _level;
        private bool _active;


        public uint Cosid
        {
            get
            {
                return _cosid;
            }

            set
            {
                _cosid = value;
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

        public ushort Level
        {
            get
            {
                return _level;
            }

            set
            {
                _level = value;
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
