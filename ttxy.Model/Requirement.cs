﻿namespace ttxy.Model
{
    public class Requirement
    {
        private uint _rank;
        private uint _course;
        private string _description;

        private string _strCourse;

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

        public string StrCourse
        {
            get
            {
                return _strCourse;
            }

            set
            {
                _strCourse = value;
            }
        }
    }
}
