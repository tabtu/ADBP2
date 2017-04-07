namespace ttxy.Model
{
    public class Timetable
    {
        private uint _course;
        private short _dayofweek;
        private short _starttime;
        private short _endtime;

        public uint Course
        {
            get
            {
                return _course;
            }

            set
            {
                _course = value;
            }
        }

        public short Dayofweek
        {
            get
            {
                return _dayofweek;
            }

            set
            {
                _dayofweek = value;
            }
        }

        public short Starttime
        {
            get
            {
                return _starttime;
            }

            set
            {
                _starttime = value;
            }
        }

        public short Endtime
        {
            get
            {
                return _endtime;
            }

            set
            {
                _endtime = value;
            }
        }
    }
}
