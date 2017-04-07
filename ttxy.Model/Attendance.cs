﻿using System;

namespace ttxy.Model
{
    public class Attendance
    {
        private uint _student;
        private uint _course;
        private DateTime _date;

        public uint Student
        {
            get
            {
                return _student;
            }

            set
            {
                _student = value;
            }
        }

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
