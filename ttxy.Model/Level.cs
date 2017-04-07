namespace ttxy.Model
{
    public class Level
    {
        private ushort _levid;
        private string _name;

        public ushort Levid
        {
            get
            {
                return _levid;
            }

            set
            {
                _levid = value;
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
    }
}
