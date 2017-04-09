namespace ttxy.Model
{
    public class Timetable
    {
        private uint _course;
        private short _dayofweek;
        private short _starttime;
        private short _endtime;

        private string _strCourseName;
        private string _strCourseTime;

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

        public string StrCourseName
        {
            get
            {
                return _strCourseName;
            }

            set
            {
                _strCourseName = value;
            }
        }

        public string StrCourseTime
        {
            get
            {
                return _strCourseTime;
            }

            set
            {
                _strCourseTime = value;
            }
        }
    }
}
