namespace ttxy.Model
{
    public class PayFor
    {
        private ushort _id;
        private string _description;

        public ushort Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }
    }
}
