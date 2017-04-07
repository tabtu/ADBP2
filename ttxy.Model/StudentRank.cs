using System;

namespace ttxy.Model
{
    public class StudentRank
    {
        private uint _stnum;
        private uint _rank;
        private DateTime _date;

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

        public uint Rank
        {
            get
            {
                return _rank;
            }

            set
            {
                _rank = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }
    }
}
